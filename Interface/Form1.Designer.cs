﻿namespace Interface
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
            this.trackBar_scaleZ = new System.Windows.Forms.TrackBar();
            this.trackBar_ScaleY = new System.Windows.Forms.TrackBar();
            this.trackBar_scaleX = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_rotate = new System.Windows.Forms.Panel();
            this.button_rotate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_customY2 = new System.Windows.Forms.TextBox();
            this.textBox_customX2 = new System.Windows.Forms.TextBox();
            this.textBox_customY1 = new System.Windows.Forms.TextBox();
            this.textBox_customX1 = new System.Windows.Forms.TextBox();
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
            this.radioButton_reflectX = new System.Windows.Forms.RadioButton();
            this.radioButton_reflectY = new System.Windows.Forms.RadioButton();
            this.radioButton_reflectZ = new System.Windows.Forms.RadioButton();
            this.button_reflect = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_customZ1 = new System.Windows.Forms.TextBox();
            this.textBox_customZ2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.panel_reflect.SuspendLayout();
            this.panel_scale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_scaleZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_scaleX)).BeginInit();
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
            this.panel_reflect.Controls.Add(this.button_reflect);
            this.panel_reflect.Controls.Add(this.radioButton_reflectZ);
            this.panel_reflect.Controls.Add(this.radioButton_reflectY);
            this.panel_reflect.Controls.Add(this.radioButton_reflectX);
            resources.ApplyResources(this.panel_reflect, "panel_reflect");
            this.panel_reflect.Name = "panel_reflect";
            // 
            // panel_scale
            // 
            this.panel_scale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_scale.Controls.Add(this.trackBar_scaleZ);
            this.panel_scale.Controls.Add(this.trackBar_ScaleY);
            this.panel_scale.Controls.Add(this.trackBar_scaleX);
            this.panel_scale.Controls.Add(this.label11);
            this.panel_scale.Controls.Add(this.label10);
            this.panel_scale.Controls.Add(this.label9);
            resources.ApplyResources(this.panel_scale, "panel_scale");
            this.panel_scale.Name = "panel_scale";
            // 
            // trackBar_scaleZ
            // 
            resources.ApplyResources(this.trackBar_scaleZ, "trackBar_scaleZ");
            this.trackBar_scaleZ.Name = "trackBar_scaleZ";
            this.trackBar_scaleZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_scaleZ.Value = 5;
            // 
            // trackBar_ScaleY
            // 
            resources.ApplyResources(this.trackBar_ScaleY, "trackBar_ScaleY");
            this.trackBar_ScaleY.Name = "trackBar_ScaleY";
            this.trackBar_ScaleY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_ScaleY.Value = 5;
            // 
            // trackBar_scaleX
            // 
            resources.ApplyResources(this.trackBar_scaleX, "trackBar_scaleX");
            this.trackBar_scaleX.Name = "trackBar_scaleX";
            this.trackBar_scaleX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_scaleX.Value = 5;
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
            this.panel_rotate.Controls.Add(this.textBox_customZ2);
            this.panel_rotate.Controls.Add(this.textBox_customZ1);
            this.panel_rotate.Controls.Add(this.label13);
            this.panel_rotate.Controls.Add(this.label12);
            this.panel_rotate.Controls.Add(this.button_rotate);
            this.panel_rotate.Controls.Add(this.label8);
            this.panel_rotate.Controls.Add(this.label7);
            this.panel_rotate.Controls.Add(this.textBox_customY2);
            this.panel_rotate.Controls.Add(this.textBox_customX2);
            this.panel_rotate.Controls.Add(this.textBox_customY1);
            this.panel_rotate.Controls.Add(this.textBox_customX1);
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
            // textBox_customY2
            // 
            resources.ApplyResources(this.textBox_customY2, "textBox_customY2");
            this.textBox_customY2.Name = "textBox_customY2";
            // 
            // textBox_customX2
            // 
            resources.ApplyResources(this.textBox_customX2, "textBox_customX2");
            this.textBox_customX2.Name = "textBox_customX2";
            // 
            // textBox_customY1
            // 
            resources.ApplyResources(this.textBox_customY1, "textBox_customY1");
            this.textBox_customY1.Name = "textBox_customY1";
            // 
            // textBox_customX1
            // 
            resources.ApplyResources(this.textBox_customX1, "textBox_customX1");
            this.textBox_customX1.Name = "textBox_customX1";
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
            // radioButton_reflectX
            // 
            resources.ApplyResources(this.radioButton_reflectX, "radioButton_reflectX");
            this.radioButton_reflectX.Name = "radioButton_reflectX";
            this.radioButton_reflectX.TabStop = true;
            this.radioButton_reflectX.UseVisualStyleBackColor = true;
            // 
            // radioButton_reflectY
            // 
            resources.ApplyResources(this.radioButton_reflectY, "radioButton_reflectY");
            this.radioButton_reflectY.Name = "radioButton_reflectY";
            this.radioButton_reflectY.TabStop = true;
            this.radioButton_reflectY.UseVisualStyleBackColor = true;
            // 
            // radioButton_reflectZ
            // 
            resources.ApplyResources(this.radioButton_reflectZ, "radioButton_reflectZ");
            this.radioButton_reflectZ.Name = "radioButton_reflectZ";
            this.radioButton_reflectZ.TabStop = true;
            this.radioButton_reflectZ.UseVisualStyleBackColor = true;
            // 
            // button_reflect
            // 
            resources.ApplyResources(this.button_reflect, "button_reflect");
            this.button_reflect.Name = "button_reflect";
            this.button_reflect.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // textBox_customZ1
            // 
            resources.ApplyResources(this.textBox_customZ1, "textBox_customZ1");
            this.textBox_customZ1.Name = "textBox_customZ1";
            // 
            // textBox_customZ2
            // 
            resources.ApplyResources(this.textBox_customZ2, "textBox_customZ2");
            this.textBox_customZ2.Name = "textBox_customZ2";
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_scaleZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_scaleX)).EndInit();
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
        private System.Windows.Forms.TextBox textBox_customY2;
        private System.Windows.Forms.TextBox textBox_customX2;
        private System.Windows.Forms.TextBox textBox_customY1;
        private System.Windows.Forms.TextBox textBox_customX1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_rotate;
        private System.Windows.Forms.TrackBar trackBar_scaleZ;
        private System.Windows.Forms.TrackBar trackBar_ScaleY;
        private System.Windows.Forms.TrackBar trackBar_scaleX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_reflect;
        private System.Windows.Forms.RadioButton radioButton_reflectZ;
        private System.Windows.Forms.RadioButton radioButton_reflectY;
        private System.Windows.Forms.RadioButton radioButton_reflectX;
        private System.Windows.Forms.TextBox textBox_customZ2;
        private System.Windows.Forms.TextBox textBox_customZ1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

