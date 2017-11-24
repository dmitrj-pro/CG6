namespace Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel_reflect = new System.Windows.Forms.Panel();
            this.panel_scale = new System.Windows.Forms.Panel();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_rotate = new System.Windows.Forms.Panel();
            this.button_rotate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_rotateAngle = new System.Windows.Forms.TextBox();
            this.radioButton_rotateCustom = new System.Windows.Forms.RadioButton();
            this.radioButton_rotateZ = new System.Windows.Forms.RadioButton();
            this.radioButton_rotateY = new System.Windows.Forms.RadioButton();
            this.radioButton_ratateX = new System.Windows.Forms.RadioButton();
            this.panel_displ = new System.Windows.Forms.Panel();
            this.button_move = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_displZ = new System.Windows.Forms.TextBox();
            this.textBox_displY = new System.Windows.Forms.TextBox();
            this.textBox_displX = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.panel_reflect.SuspendLayout();
            this.panel_scale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel_rotate.SuspendLayout();
            this.panel_displ.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel
            // 
            resources.ApplyResources(this.panel, "panel");
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.panel_reflect);
            this.panel.Controls.Add(this.panel_scale);
            this.panel.Controls.Add(this.panel_rotate);
            this.panel.Controls.Add(this.panel_displ);
            this.panel.Controls.Add(this.comboBox1);
            this.panel.Name = "panel";
            // 
            // panel_reflect
            // 
            this.panel_reflect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_reflect.Controls.Add(this.button3);
            this.panel_reflect.Controls.Add(this.radioButton7);
            this.panel_reflect.Controls.Add(this.radioButton6);
            this.panel_reflect.Controls.Add(this.radioButton5);
            resources.ApplyResources(this.panel_reflect, "panel_reflect");
            this.panel_reflect.Name = "panel_reflect";
            // 
            // panel_scale
            // 
            this.panel_scale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_scale.Controls.Add(this.trackBar3);
            this.panel_scale.Controls.Add(this.trackBar2);
            this.panel_scale.Controls.Add(this.trackBar1);
            this.panel_scale.Controls.Add(this.label11);
            this.panel_scale.Controls.Add(this.label10);
            this.panel_scale.Controls.Add(this.label9);
            resources.ApplyResources(this.panel_scale, "panel_scale");
            this.panel_scale.Name = "panel_scale";
            // 
            // trackBar3
            // 
            resources.ApplyResources(this.trackBar3, "trackBar3");
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Value = 5;
            // 
            // trackBar2
            // 
            resources.ApplyResources(this.trackBar2, "trackBar2");
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 5;
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 5;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // panel_rotate
            // 
            this.panel_rotate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_rotate.Controls.Add(this.button_rotate);
            this.panel_rotate.Controls.Add(this.label8);
            this.panel_rotate.Controls.Add(this.label7);
            this.panel_rotate.Controls.Add(this.textBox5);
            this.panel_rotate.Controls.Add(this.textBox4);
            this.panel_rotate.Controls.Add(this.textBox3);
            this.panel_rotate.Controls.Add(this.textBox2);
            this.panel_rotate.Controls.Add(this.label6);
            this.panel_rotate.Controls.Add(this.label5);
            this.panel_rotate.Controls.Add(this.label4);
            this.panel_rotate.Controls.Add(this.textBox_rotateAngle);
            this.panel_rotate.Controls.Add(this.radioButton_rotateCustom);
            this.panel_rotate.Controls.Add(this.radioButton_rotateZ);
            this.panel_rotate.Controls.Add(this.radioButton_rotateY);
            this.panel_rotate.Controls.Add(this.radioButton_ratateX);
            resources.ApplyResources(this.panel_rotate, "panel_rotate");
            this.panel_rotate.Name = "panel_rotate";
            // 
            // button_rotate
            // 
            resources.ApplyResources(this.button_rotate, "button_rotate");
            this.button_rotate.Name = "button_rotate";
            this.button_rotate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox_rotateAngle
            // 
            resources.ApplyResources(this.textBox_rotateAngle, "textBox_rotateAngle");
            this.textBox_rotateAngle.Name = "textBox_rotateAngle";
            // 
            // radioButton_rotateCustom
            // 
            resources.ApplyResources(this.radioButton_rotateCustom, "radioButton_rotateCustom");
            this.radioButton_rotateCustom.Name = "radioButton_rotateCustom";
            this.radioButton_rotateCustom.TabStop = true;
            this.radioButton_rotateCustom.UseVisualStyleBackColor = true;
            // 
            // radioButton_rotateZ
            // 
            resources.ApplyResources(this.radioButton_rotateZ, "radioButton_rotateZ");
            this.radioButton_rotateZ.Name = "radioButton_rotateZ";
            this.radioButton_rotateZ.TabStop = true;
            this.radioButton_rotateZ.UseVisualStyleBackColor = true;
            // 
            // radioButton_rotateY
            // 
            resources.ApplyResources(this.radioButton_rotateY, "radioButton_rotateY");
            this.radioButton_rotateY.Name = "radioButton_rotateY";
            this.radioButton_rotateY.TabStop = true;
            this.radioButton_rotateY.UseVisualStyleBackColor = true;
            // 
            // radioButton_ratateX
            // 
            resources.ApplyResources(this.radioButton_ratateX, "radioButton_ratateX");
            this.radioButton_ratateX.Name = "radioButton_ratateX";
            this.radioButton_ratateX.TabStop = true;
            this.radioButton_ratateX.UseVisualStyleBackColor = true;
            // 
            // panel_displ
            // 
            this.panel_displ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_displ.Controls.Add(this.button_move);
            this.panel_displ.Controls.Add(this.label3);
            this.panel_displ.Controls.Add(this.label2);
            this.panel_displ.Controls.Add(this.label1);
            this.panel_displ.Controls.Add(this.textBox_displZ);
            this.panel_displ.Controls.Add(this.textBox_displY);
            this.panel_displ.Controls.Add(this.textBox_displX);
            resources.ApplyResources(this.panel_displ, "panel_displ");
            this.panel_displ.Name = "panel_displ";
            // 
            // button_move
            // 
            resources.ApplyResources(this.button_move, "button_move");
            this.button_move.Name = "button_move";
            this.button_move.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_displZ
            // 
            resources.ApplyResources(this.textBox_displZ, "textBox_displZ");
            this.textBox_displZ.Name = "textBox_displZ";
            this.textBox_displZ.TextChanged += new System.EventHandler(this.textBox_displX_TextChanged);
            // 
            // textBox_displY
            // 
            resources.ApplyResources(this.textBox_displY, "textBox_displY");
            this.textBox_displY.Name = "textBox_displY";
            this.textBox_displY.TextChanged += new System.EventHandler(this.textBox_displX_TextChanged);
            // 
            // textBox_displX
            // 
            resources.ApplyResources(this.textBox_displX, "textBox_displX");
            this.textBox_displX.Name = "textBox_displX";
            this.textBox_displX.TextChanged += new System.EventHandler(this.textBox_displX_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_clear
            // 
            resources.ApplyResources(this.button_clear, "button_clear");
            this.button_clear.Name = "button_clear";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            resources.ApplyResources(this.radioButton5, "radioButton5");
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            resources.ApplyResources(this.radioButton6, "radioButton6");
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            resources.ApplyResources(this.radioButton7, "radioButton7");
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel_reflect.ResumeLayout(false);
            this.panel_reflect.PerformLayout();
            this.panel_scale.ResumeLayout(false);
            this.panel_scale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel_rotate.ResumeLayout(false);
            this.panel_rotate.PerformLayout();
            this.panel_displ.ResumeLayout(false);
            this.panel_displ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel_reflect;
        private System.Windows.Forms.Panel panel_scale;
        private System.Windows.Forms.Panel panel_displ;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_displZ;
        private System.Windows.Forms.TextBox textBox_displY;
        private System.Windows.Forms.TextBox textBox_displX;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.Panel panel_rotate;
        private System.Windows.Forms.RadioButton radioButton_rotateZ;
        private System.Windows.Forms.RadioButton radioButton_rotateY;
        private System.Windows.Forms.RadioButton radioButton_ratateX;
        private System.Windows.Forms.TextBox textBox_rotateAngle;
        private System.Windows.Forms.RadioButton radioButton_rotateCustom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_rotate;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}

