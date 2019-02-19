//
// BlameView.cs
//
// Author:
//       Mike Krüger <mkrueger@novell.com>
//
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using MonoDevelop.Components;
using MonoDevelop.Core;
using MonoDevelop.Ide.Gui.Content;
using Mono.TextEditor;
using System;
using System.Linq;

namespace MonoDevelop.VersionControl.Views
{
	public interface IBlameView
	{	
	}
	
	internal class BlameView : BaseView, IBlameView, IClipboardHandler
	{
		BlameWidget widget;
		VersionControlDocumentInfo info;
		
		public override Control Control { 
			get {
				if (widget == null)
					widget = new BlameWidget (info);
				return widget;
			}
		}
		
		public BlameView (VersionControlDocumentInfo info) : base (GettextCatalog.GetString ("Authors"), GettextCatalog.GetString ("Shows the authors of the current file"))
		{
			this.info = info;
		}
		
		#region IAttachableViewContent implementation
		protected override void OnSelected ()
		{
			info.Start ();
			BlameWidget blameWidget = Control.GetNativeWidget<BlameWidget> ();
			blameWidget.Reset ();
			var buffer = info.Document.GetContent<MonoDevelop.Ide.Editor.TextEditor> ();
			if (buffer != null) {
				if (!(buffer.TextView is MonoTextEditor)) {
					//compatibility for other not MonoTextEditor editors
					var loc = buffer.CaretLocation;
					int line = loc.Line < 1 ? 1 : loc.Line;
					int column = loc.Column < 1 ? 1 : loc.Column;
					blameWidget.Editor.SetCaretTo (line, column, highlight: false, centerCaret: false);
				}
			}
		}

		protected override void OnDeselected ()
		{
			var buffer = info.Document.GetContent<MonoDevelop.Ide.Editor.TextEditor> () ;
			if (buffer != null) {
				var blameWidget = Control.GetNativeWidget<BlameWidget> ();

				if (buffer.TextView is MonoTextEditor exEditor) {
					if (blameWidget.Revision == null)
						exEditor.Document.UpdateFoldSegments (blameWidget.Editor.Document.FoldSegments.Select (f => new Mono.TextEditor.FoldSegment (f)));
					exEditor.SetCaretTo (blameWidget.Editor.Caret.Line, blameWidget.Editor.Caret.Column);
					exEditor.VAdjustment.Value = blameWidget.Editor.VAdjustment.Value;
				} else {
					//compatibility for other not MonoTextEditor editors
					buffer.ScrollTo (new Ide.Editor.DocumentLocation (blameWidget.Editor.YToLine (blameWidget.Editor.VAdjustment.Value), 1));
					buffer.SetCaretLocation (blameWidget.Editor.Caret.Line, blameWidget.Editor.Caret.Column, usePulseAnimation: false, centerCaret: false);
				}
			}
		}

		#endregion

		#region IClipboardHandler implementation
		void IClipboardHandler.Cut ()
		{
		}

		void IClipboardHandler.Copy ()
		{
			this.widget.Editor.RunAction (ClipboardActions.Copy);
		}

		void IClipboardHandler.Paste ()
		{
		}

		void IClipboardHandler.Delete ()
		{
		}

		void IClipboardHandler.SelectAll ()
		{
			this.widget.Editor.RunAction (SelectionActions.SelectAll);
		}

		bool IClipboardHandler.EnableCut {
			get {
				return false;
			}
		}

		bool IClipboardHandler.EnableCopy {
			get {
				return this.widget.Editor.IsSomethingSelected;
			}
		}

		bool IClipboardHandler.EnablePaste {
			get {
				return false;
			}
		}

		bool IClipboardHandler.EnableDelete {
			get {
				return false;
			}
		}

		bool IClipboardHandler.EnableSelectAll {
			get {
				return true;
			}
		}
		#endregion
	}
}

