
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Entry nField;

	private global::Gtk.Label label1;

	private global::Gtk.Label label2;

	private global::Gtk.Entry mField;

	private global::Gtk.Label magicResult;

	private global::Gtk.Button button;

	private global::Gtk.Label triangleResult;

	private global::Gtk.Label result;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.nField = new global::Gtk.Entry();
		this.nField.WidthRequest = 60;
		this.nField.CanFocus = true;
		this.nField.Name = "nField";
		this.nField.IsEditable = true;
		this.nField.InvisibleChar = '●';
		this.fixed1.Add(this.nField);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.nField]));
		w1.X = 20;
		w1.Y = 5;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("n:");
		this.fixed1.Add(this.label1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
		w2.X = 5;
		w2.Y = 14;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("m:");
		this.fixed1.Add(this.label2);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
		w3.X = 85;
		w3.Y = 14;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.mField = new global::Gtk.Entry();
		this.mField.WidthRequest = 60;
		this.mField.CanFocus = true;
		this.mField.Name = "mField";
		this.mField.IsEditable = true;
		this.mField.InvisibleChar = '●';
		this.fixed1.Add(this.mField);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.mField]));
		w4.X = 110;
		w4.Y = 5;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.magicResult = new global::Gtk.Label();
		this.magicResult.Name = "magicResult";
		this.magicResult.LabelProp = global::Mono.Unix.Catalog.GetString("label3");
		this.fixed1.Add(this.magicResult);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.magicResult]));
		w5.X = 5;
		w5.Y = 40;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button = new global::Gtk.Button();
		this.button.CanFocus = true;
		this.button.Events = ((global::Gdk.EventMask)(256));
		this.button.Name = "button";
		this.button.UseUnderline = true;
		this.button.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.fixed1.Add(this.button);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button]));
		w6.X = 325;
		w6.Y = 265;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.triangleResult = new global::Gtk.Label();
		this.triangleResult.Name = "triangleResult";
		this.triangleResult.LabelProp = global::Mono.Unix.Catalog.GetString("label4");
		this.fixed1.Add(this.triangleResult);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.triangleResult]));
		w7.X = 5;
		w7.Y = 55;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.result = new global::Gtk.Label();
		this.result.Name = "result";
		this.result.LabelProp = global::Mono.Unix.Catalog.GetString("label5");
		this.fixed1.Add(this.result);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.result]));
		w8.X = 5;
		w8.Y = 70;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
