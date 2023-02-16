namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.trackBarPSize = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPCol = new System.Windows.Forms.Label();
            this.labelACol = new System.Windows.Forms.Label();
            this.labelLcol = new System.Windows.Forms.Label();
            this.labelLineSize = new System.Windows.Forms.Label();
            this.labelAxisSize = new System.Windows.Forms.Label();
            this.trackLSize = new System.Windows.Forms.TrackBar();
            this.trackASize = new System.Windows.Forms.TrackBar();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.buttonForAxisChanger = new System.Windows.Forms.Button();
            this.buttonForLineChanger = new System.Windows.Forms.Button();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.labelForChoosingType = new System.Windows.Forms.Label();
            this.radioForCircleChoose = new System.Windows.Forms.RadioButton();
            this.radioForRecChoose = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackASize)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(586, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x1";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX1.Location = new System.Drawing.Point(572, 52);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(42, 20);
            this.textBoxX1.TabIndex = 2;
            this.textBoxX1.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(10, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 436);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "x2";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX2.Location = new System.Drawing.Point(648, 52);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(42, 20);
            this.textBoxX2.TabIndex = 2;
            this.textBoxX2.Text = "10";
            // 
            // trackBarPSize
            // 
            this.trackBarPSize.Location = new System.Drawing.Point(62, 0);
            this.trackBarPSize.Minimum = 1;
            this.trackBarPSize.Name = "trackBarPSize";
            this.trackBarPSize.Size = new System.Drawing.Size(90, 45);
            this.trackBarPSize.TabIndex = 4;
            this.trackBarPSize.Value = 1;
            this.trackBarPSize.Scroll += new System.EventHandler(this.TrackBarPSize_Scroll);
            this.trackBarPSize.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // buttonP
            // 
            this.buttonP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonP.Location = new System.Drawing.Point(604, 146);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(75, 23);
            this.buttonP.TabIndex = 5;
            this.buttonP.Text = "color";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "a";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(572, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "2";
            // 
            // b
            // 
            this.b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(553, 105);
            this.b.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(13, 13);
            this.b.TabIndex = 9;
            this.b.Text = "b";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "c";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(572, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "3";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(572, 123);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Point size";
            // 
            // labelPCol
            // 
            this.labelPCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPCol.AutoSize = true;
            this.labelPCol.Location = new System.Drawing.Point(547, 151);
            this.labelPCol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPCol.Name = "labelPCol";
            this.labelPCol.Size = new System.Drawing.Size(57, 13);
            this.labelPCol.TabIndex = 14;
            this.labelPCol.Text = "Point color";
            // 
            // labelACol
            // 
            this.labelACol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelACol.AutoSize = true;
            this.labelACol.Location = new System.Drawing.Point(547, 177);
            this.labelACol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelACol.Name = "labelACol";
            this.labelACol.Size = new System.Drawing.Size(52, 13);
            this.labelACol.TabIndex = 15;
            this.labelACol.Text = "Axis color";
            // 
            // labelLcol
            // 
            this.labelLcol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLcol.AutoSize = true;
            this.labelLcol.Location = new System.Drawing.Point(547, 207);
            this.labelLcol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLcol.Name = "labelLcol";
            this.labelLcol.Size = new System.Drawing.Size(53, 13);
            this.labelLcol.TabIndex = 16;
            this.labelLcol.Text = "Line color";
            // 
            // labelLineSize
            // 
            this.labelLineSize.AutoSize = true;
            this.labelLineSize.Location = new System.Drawing.Point(169, 11);
            this.labelLineSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLineSize.Name = "labelLineSize";
            this.labelLineSize.Size = new System.Drawing.Size(48, 13);
            this.labelLineSize.TabIndex = 19;
            this.labelLineSize.Text = "Line size";
            // 
            // labelAxisSize
            // 
            this.labelAxisSize.AutoSize = true;
            this.labelAxisSize.Location = new System.Drawing.Point(356, 11);
            this.labelAxisSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAxisSize.Name = "labelAxisSize";
            this.labelAxisSize.Size = new System.Drawing.Size(47, 13);
            this.labelAxisSize.TabIndex = 20;
            this.labelAxisSize.Text = "Axis size";
            // 
            // trackLSize
            // 
            this.trackLSize.Location = new System.Drawing.Point(218, 0);
            this.trackLSize.Minimum = 1;
            this.trackLSize.Name = "trackLSize";
            this.trackLSize.Size = new System.Drawing.Size(90, 45);
            this.trackLSize.TabIndex = 21;
            this.trackLSize.Value = 1;
            this.trackLSize.Scroll += new System.EventHandler(this.TrackLSize_Scroll);
            // 
            // trackASize
            // 
            this.trackASize.Location = new System.Drawing.Point(406, 0);
            this.trackASize.Minimum = 1;
            this.trackASize.Name = "trackASize";
            this.trackASize.Size = new System.Drawing.Size(90, 45);
            this.trackASize.TabIndex = 22;
            this.trackASize.Value = 1;
            this.trackASize.Scroll += new System.EventHandler(this.TrackASize_Scroll);
            // 
            // buttonForAxisChanger
            // 
            this.buttonForAxisChanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForAxisChanger.Location = new System.Drawing.Point(604, 173);
            this.buttonForAxisChanger.Name = "buttonForAxisChanger";
            this.buttonForAxisChanger.Size = new System.Drawing.Size(75, 23);
            this.buttonForAxisChanger.TabIndex = 23;
            this.buttonForAxisChanger.Text = "color";
            this.buttonForAxisChanger.UseVisualStyleBackColor = true;
            this.buttonForAxisChanger.Click += new System.EventHandler(this.buttonForAxisChanger_Click);
            // 
            // buttonForLineChanger
            // 
            this.buttonForLineChanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForLineChanger.Location = new System.Drawing.Point(604, 202);
            this.buttonForLineChanger.Name = "buttonForLineChanger";
            this.buttonForLineChanger.Size = new System.Drawing.Size(75, 23);
            this.buttonForLineChanger.TabIndex = 24;
            this.buttonForLineChanger.Text = "color";
            this.buttonForLineChanger.UseVisualStyleBackColor = true;
            this.buttonForLineChanger.Click += new System.EventHandler(this.buttonForLineChanger_Click);
            // 
            // labelForChoosingType
            // 
            this.labelForChoosingType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForChoosingType.AutoSize = true;
            this.labelForChoosingType.Location = new System.Drawing.Point(547, 249);
            this.labelForChoosingType.Name = "labelForChoosingType";
            this.labelForChoosingType.Size = new System.Drawing.Size(92, 13);
            this.labelForChoosingType.TabIndex = 25;
            this.labelForChoosingType.Text = "Choose point type";
            // 
            // radioForCircleChoose
            // 
            this.radioForCircleChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioForCircleChoose.AutoSize = true;
            this.radioForCircleChoose.Location = new System.Drawing.Point(556, 280);
            this.radioForCircleChoose.Name = "radioForCircleChoose";
            this.radioForCircleChoose.Size = new System.Drawing.Size(51, 17);
            this.radioForCircleChoose.TabIndex = 26;
            this.radioForCircleChoose.TabStop = true;
            this.radioForCircleChoose.Text = "Circle";
            this.radioForCircleChoose.UseVisualStyleBackColor = true;
            this.radioForCircleChoose.CheckedChanged += new System.EventHandler(this.radioForCircleChoose_CheckedChanged);
            // 
            // radioForRecChoose
            // 
            this.radioForRecChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioForRecChoose.AutoSize = true;
            this.radioForRecChoose.Location = new System.Drawing.Point(556, 303);
            this.radioForRecChoose.Name = "radioForRecChoose";
            this.radioForRecChoose.Size = new System.Drawing.Size(74, 17);
            this.radioForRecChoose.TabIndex = 27;
            this.radioForRecChoose.TabStop = true;
            this.radioForRecChoose.Text = "Rectangle";
            this.radioForRecChoose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 511);
            this.Controls.Add(this.radioForRecChoose);
            this.Controls.Add(this.radioForCircleChoose);
            this.Controls.Add(this.labelForChoosingType);
            this.Controls.Add(this.buttonForLineChanger);
            this.Controls.Add(this.buttonForAxisChanger);
            this.Controls.Add(this.trackASize);
            this.Controls.Add(this.trackLSize);
            this.Controls.Add(this.labelAxisSize);
            this.Controls.Add(this.labelLineSize);
            this.Controls.Add(this.labelLcol);
            this.Controls.Add(this.labelACol);
            this.Controls.Add(this.labelPCol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.trackBarPSize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackASize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TrackBar trackBarPSize;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPCol;
        private System.Windows.Forms.Label labelACol;
        private System.Windows.Forms.Label labelLcol;
        private System.Windows.Forms.Label labelLineSize;
        private System.Windows.Forms.Label labelAxisSize;
        private System.Windows.Forms.TrackBar trackLSize;
        private System.Windows.Forms.TrackBar trackASize;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button buttonForAxisChanger;
        private System.Windows.Forms.Button buttonForLineChanger;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.Label labelForChoosingType;
        private System.Windows.Forms.RadioButton radioForCircleChoose;
        private System.Windows.Forms.RadioButton radioForRecChoose;
    }
}

