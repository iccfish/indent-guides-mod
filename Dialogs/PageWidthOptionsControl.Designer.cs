namespace IndentGuide
{
    partial class PageWidthOptionsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageWidthOptionsControl));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.linePreviewHighlight = new IndentGuide.LinePreview();
			this.lstLocations = new System.Windows.Forms.ListBox();
			this.linePreview = new IndentGuide.LinePreview();
			this.gridLineStyle = new System.Windows.Forms.PropertyGrid();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAddLocation = new System.Windows.Forms.Button();
			this.btnRemoveLocation = new System.Windows.Forms.Button();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.linePreviewHighlight, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.lstLocations, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.linePreview, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.gridLineStyle, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.toolTip.SetToolTip(this.tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
			// 
			// linePreviewHighlight
			// 
			resources.ApplyResources(this.linePreviewHighlight, "linePreviewHighlight");
			this.linePreviewHighlight.BackColor = System.Drawing.SystemColors.Window;
			this.linePreviewHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.linePreviewHighlight.Name = "linePreviewHighlight";
			this.linePreviewHighlight.Style = IndentGuide.LineStyle.Solid;
			this.toolTip.SetToolTip(this.linePreviewHighlight, resources.GetString("linePreviewHighlight.ToolTip"));
			// 
			// lstLocations
			// 
			resources.ApplyResources(this.lstLocations, "lstLocations");
			this.lstLocations.FormattingEnabled = true;
			this.lstLocations.Name = "lstLocations";
			this.tableLayoutPanel2.SetRowSpan(this.lstLocations, 4);
			this.toolTip.SetToolTip(this.lstLocations, resources.GetString("lstLocations.ToolTip"));
			this.lstLocations.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged);
			this.lstLocations.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstLocations_Format);
			// 
			// linePreview
			// 
			resources.ApplyResources(this.linePreview, "linePreview");
			this.linePreview.BackColor = System.Drawing.SystemColors.Window;
			this.linePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.linePreview.Name = "linePreview";
			this.linePreview.Style = IndentGuide.LineStyle.Solid;
			this.toolTip.SetToolTip(this.linePreview, resources.GetString("linePreview.ToolTip"));
			// 
			// gridLineStyle
			// 
			resources.ApplyResources(this.gridLineStyle, "gridLineStyle");
			this.gridLineStyle.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gridLineStyle.CommandsVisibleIfAvailable = false;
			this.gridLineStyle.Name = "gridLineStyle";
			this.gridLineStyle.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.tableLayoutPanel2.SetRowSpan(this.gridLineStyle, 4);
			this.gridLineStyle.ToolbarVisible = false;
			this.toolTip.SetToolTip(this.gridLineStyle, resources.GetString("gridLineStyle.ToolTip"));
			this.gridLineStyle.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.gridLineStyle_PropertyValueChanged);
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.btnAddLocation, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRemoveLocation, 2, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.toolTip.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
			// 
			// btnAddLocation
			// 
			resources.ApplyResources(this.btnAddLocation, "btnAddLocation");
			this.btnAddLocation.Name = "btnAddLocation";
			this.toolTip.SetToolTip(this.btnAddLocation, resources.GetString("btnAddLocation.ToolTip"));
			this.btnAddLocation.UseVisualStyleBackColor = true;
			this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
			// 
			// btnRemoveLocation
			// 
			resources.ApplyResources(this.btnRemoveLocation, "btnRemoveLocation");
			this.btnRemoveLocation.Name = "btnRemoveLocation";
			this.toolTip.SetToolTip(this.btnRemoveLocation, resources.GetString("btnRemoveLocation.ToolTip"));
			this.btnRemoveLocation.UseVisualStyleBackColor = true;
			this.btnRemoveLocation.Click += new System.EventHandler(this.btnRemoveLocation_Click);
			// 
			// PageWidthOptionsControl
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "PageWidthOptionsControl";
			this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LinePreview linePreview;
        private System.Windows.Forms.PropertyGrid gridLineStyle;
        private LinePreview linePreviewHighlight;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnRemoveLocation;
    }
}
