
// This file has been generated by the GUI designer. Do not modify.
namespace CWindow
{
	public partial class MyWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget CWindow.MyWindow
			this.Name = "CWindow.MyWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("MyWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child CWindow.MyWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Has cantado windows");
			this.vbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
