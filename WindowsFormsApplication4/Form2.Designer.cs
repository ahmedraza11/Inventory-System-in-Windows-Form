namespace WindowsFormsApplication4
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inventeryDataSet2 = new WindowsFormsApplication4.InventeryDataSet2();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableAdapter = new WindowsFormsApplication4.InventeryDataSet2TableAdapters.dataTableAdapter();
            this.dataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inventeryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventeryDataSet2
            // 
            this.inventeryDataSet2.DataSetName = "InventeryDataSet2";
            this.inventeryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "data";
            this.dataBindingSource.DataSource = this.inventeryDataSet2;
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // dataBindingSource1
            // 
            this.dataBindingSource1.DataMember = "data";
            this.dataBindingSource1.DataSource = this.inventeryDataSet2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 577);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventeryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InventeryDataSet2 inventeryDataSet2;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private InventeryDataSet2TableAdapters.dataTableAdapter dataTableAdapter;
        private System.Windows.Forms.BindingSource dataBindingSource1;

    }
}