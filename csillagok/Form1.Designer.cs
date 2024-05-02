namespace csillagok
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            starDatumBindingSource = new BindingSource(components);
            constellationLineBindingSource = new BindingSource(components);
            studentBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)starDatumBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)constellationLineBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // starDatumBindingSource
            // 
            starDatumBindingSource.DataSource = typeof(Models.StarDatum);
            // 
            // constellationLineBindingSource
            // 
            constellationLineBindingSource.DataSource = typeof(Models.ConstellationLine);
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // button1
            // 
            button1.Location = new Point(0, 1);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)starDatumBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)constellationLineBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource studentBindingSource;
        private BindingSource constellationLineBindingSource;
        private Button button1;
        private BindingSource starDatumBindingSource;
    }
}