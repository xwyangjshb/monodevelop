// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Gettext.Translator {
    
    
    public partial class LanguageChooserDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Image image1;
        
        private Gtk.Label label1;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment GtkAlignment2;
        
        private Gtk.Table tableKnown;
        
        private Gtk.CheckButton checkbuttonUseCoutry;
        
        private Gtk.ComboBox comboboxCountry;
        
        private Gtk.ComboBox comboboxLanguage;
        
        private Gtk.Label label3;
        
        private Gtk.Label labelCountry;
        
        private Gtk.RadioButton radiobuttonKnown;
        
        private Gtk.Frame frame2;
        
        private Gtk.Alignment GtkAlignment3;
        
        private Gtk.HBox hboxUser;
        
        private Gtk.Label label2;
        
        private Gtk.Entry entryLocale;
        
        private Gtk.RadioButton radiobuttonCustom;
        
        private Gtk.Button button1;
        
        private Gtk.Button buttonOK;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.Gettext.Translator.LanguageChooserDialog
            this.Events = ((Gdk.EventMask)(256));
            this.Name = "MonoDevelop.Gettext.Translator.LanguageChooserDialog";
            this.Title = Mono.Unix.Catalog.GetString("Choose language for translation");
            this.Icon = Gdk.Pixbuf.LoadFromResource("locale_16x16.png");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.Resizable = false;
            this.AllowGrow = false;
            this.Gravity = ((Gdk.Gravity)(5));
            this.SkipTaskbarHint = true;
            this.HasSeparator = false;
            // Internal child MonoDevelop.Gettext.Translator.LanguageChooserDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(256));
            w1.Name = "dialog_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 16;
            this.vbox2.BorderWidth = ((uint)(8));
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 8;
            // Container child hbox1.Gtk.Box+BoxChild
            this.image1 = new Gtk.Image();
            this.image1.Name = "image1";
            this.image1.Pixbuf = Gdk.Pixbuf.LoadFromResource("locale.svg");
            this.hbox1.Add(this.image1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.image1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("<big><b>Create New Localization</b></big>");
            this.label1.UseMarkup = true;
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w3.Position = 1;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 8;
            // Container child vbox3.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(0));
            this.frame1.LabelXalign = 0F;
            // Container child frame1.Gtk.Container+ContainerChild
            this.GtkAlignment2 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment2.Name = "GtkAlignment2";
            this.GtkAlignment2.LeftPadding = ((uint)(12));
            // Container child GtkAlignment2.Gtk.Container+ContainerChild
            this.tableKnown = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.tableKnown.Name = "tableKnown";
            this.tableKnown.RowSpacing = ((uint)(6));
            this.tableKnown.ColumnSpacing = ((uint)(6));
            // Container child tableKnown.Gtk.Table+TableChild
            this.checkbuttonUseCoutry = new Gtk.CheckButton();
            this.checkbuttonUseCoutry.CanFocus = true;
            this.checkbuttonUseCoutry.Name = "checkbuttonUseCoutry";
            this.checkbuttonUseCoutry.Label = Mono.Unix.Catalog.GetString("Use Country Code");
            this.checkbuttonUseCoutry.DrawIndicator = true;
            this.checkbuttonUseCoutry.UseUnderline = true;
            this.tableKnown.Add(this.checkbuttonUseCoutry);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.tableKnown[this.checkbuttonUseCoutry]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableKnown.Gtk.Table+TableChild
            this.comboboxCountry = new Gtk.ComboBox();
            this.comboboxCountry.Name = "comboboxCountry";
            this.tableKnown.Add(this.comboboxCountry);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.tableKnown[this.comboboxCountry]));
            w6.TopAttach = ((uint)(2));
            w6.BottomAttach = ((uint)(3));
            w6.LeftAttach = ((uint)(1));
            w6.RightAttach = ((uint)(2));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableKnown.Gtk.Table+TableChild
            this.comboboxLanguage = new Gtk.ComboBox();
            this.comboboxLanguage.Name = "comboboxLanguage";
            this.tableKnown.Add(this.comboboxLanguage);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.tableKnown[this.comboboxLanguage]));
            w7.LeftAttach = ((uint)(1));
            w7.RightAttach = ((uint)(2));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableKnown.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Language:");
            this.tableKnown.Add(this.label3);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.tableKnown[this.label3]));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableKnown.Gtk.Table+TableChild
            this.labelCountry = new Gtk.Label();
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Xalign = 0F;
            this.labelCountry.LabelProp = Mono.Unix.Catalog.GetString("Country:");
            this.tableKnown.Add(this.labelCountry);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.tableKnown[this.labelCountry]));
            w9.TopAttach = ((uint)(2));
            w9.BottomAttach = ((uint)(3));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            this.GtkAlignment2.Add(this.tableKnown);
            this.frame1.Add(this.GtkAlignment2);
            this.radiobuttonKnown = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Known Language"));
            this.radiobuttonKnown.Name = "radiobuttonKnown";
            this.radiobuttonKnown.Active = true;
            this.radiobuttonKnown.DrawIndicator = true;
            this.radiobuttonKnown.UseUnderline = true;
            this.radiobuttonKnown.Group = new GLib.SList(System.IntPtr.Zero);
            this.frame1.LabelWidget = this.radiobuttonKnown;
            this.vbox3.Add(this.frame1);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox3[this.frame1]));
            w12.Position = 0;
            w12.Expand = false;
            w12.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.frame2 = new Gtk.Frame();
            this.frame2.Name = "frame2";
            this.frame2.ShadowType = ((Gtk.ShadowType)(0));
            this.frame2.LabelXalign = 0F;
            // Container child frame2.Gtk.Container+ContainerChild
            this.GtkAlignment3 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment3.Name = "GtkAlignment3";
            this.GtkAlignment3.LeftPadding = ((uint)(12));
            // Container child GtkAlignment3.Gtk.Container+ContainerChild
            this.hboxUser = new Gtk.HBox();
            this.hboxUser.Name = "hboxUser";
            this.hboxUser.Spacing = 6;
            // Container child hboxUser.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Locale:");
            this.hboxUser.Add(this.label2);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hboxUser[this.label2]));
            w13.Position = 0;
            w13.Expand = false;
            w13.Fill = false;
            // Container child hboxUser.Gtk.Box+BoxChild
            this.entryLocale = new Gtk.Entry();
            this.entryLocale.CanFocus = true;
            this.entryLocale.Name = "entryLocale";
            this.entryLocale.IsEditable = true;
            this.entryLocale.InvisibleChar = '●';
            this.hboxUser.Add(this.entryLocale);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hboxUser[this.entryLocale]));
            w14.Position = 1;
            this.GtkAlignment3.Add(this.hboxUser);
            this.frame2.Add(this.GtkAlignment3);
            this.radiobuttonCustom = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("User Defined Locale"));
            this.radiobuttonCustom.Name = "radiobuttonCustom";
            this.radiobuttonCustom.DrawIndicator = true;
            this.radiobuttonCustom.UseUnderline = true;
            this.radiobuttonCustom.Group = this.radiobuttonKnown.Group;
            this.frame2.LabelWidget = this.radiobuttonCustom;
            this.vbox3.Add(this.frame2);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox3[this.frame2]));
            w17.Position = 1;
            w17.Expand = false;
            w17.Fill = false;
            this.vbox2.Add(this.vbox3);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
            w18.Position = 1;
            w18.Expand = false;
            w18.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w19.Position = 0;
            w19.Expand = false;
            w19.Fill = false;
            // Internal child MonoDevelop.Gettext.Translator.LanguageChooserDialog.ActionArea
            Gtk.HButtonBox w20 = this.ActionArea;
            w20.Name = "MonoDevelop.Gettext.LanguageChooserDialog_ActionArea";
            w20.Spacing = 6;
            w20.BorderWidth = ((uint)(5));
            w20.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child MonoDevelop.Gettext.LanguageChooserDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button1 = new Gtk.Button();
            this.button1.CanDefault = true;
            this.button1.CanFocus = true;
            this.button1.Name = "button1";
            this.button1.UseStock = true;
            this.button1.UseUnderline = true;
            this.button1.Label = "gtk-cancel";
            this.AddActionWidget(this.button1, -6);
            Gtk.ButtonBox.ButtonBoxChild w21 = ((Gtk.ButtonBox.ButtonBoxChild)(w20[this.button1]));
            w21.Expand = false;
            w21.Fill = false;
            // Container child MonoDevelop.Gettext.LanguageChooserDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOK = new Gtk.Button();
            this.buttonOK.CanDefault = true;
            this.buttonOK.CanFocus = true;
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseStock = true;
            this.buttonOK.UseUnderline = true;
            this.buttonOK.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOK, -5);
            Gtk.ButtonBox.ButtonBoxChild w22 = ((Gtk.ButtonBox.ButtonBoxChild)(w20[this.buttonOK]));
            w22.Position = 1;
            w22.Expand = false;
            w22.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 361;
            this.DefaultHeight = 330;
            this.Show();
            this.checkbuttonUseCoutry.Clicked += new System.EventHandler(this.ChangeSensitivity);
            this.entryLocale.Changed += new System.EventHandler(this.OnEntryLocaleChanged);
        }
    }
}
