using System.Drawing;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CountOfElementsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOfIndividsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CrossoverRateTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MutateChanceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NumberOfLivesTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.FunctionsGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RightBorderTextBox = new System.Windows.Forms.TextBox();
            this.LeftBorderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChangeableParameters = new System.Windows.Forms.GroupBox();
            this.NumberOfLives = new System.Windows.Forms.PictureBox();
            this.MutationChance = new System.Windows.Forms.PictureBox();
            this.CrossoverRate = new System.Windows.Forms.PictureBox();
            this.PopulationError = new System.Windows.Forms.PictureBox();
            this.StartGeneticButton = new System.Windows.Forms.Button();
            this.MinimumTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.FunctionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.ChangeableParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutationChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossoverRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationError)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountOfElementsTextBox
            // 
            this.CountOfElementsTextBox.Enabled = false;
            this.CountOfElementsTextBox.Location = new System.Drawing.Point(206, 31);
            this.CountOfElementsTextBox.Name = "CountOfElementsTextBox";
            this.CountOfElementsTextBox.Size = new System.Drawing.Size(124, 22);
            this.CountOfElementsTextBox.TabIndex = 0;
            this.CountOfElementsTextBox.Text = " ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество переменных:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Размер популяции:";
            // 
            // NumberOfIndividsTextBox
            // 
            this.NumberOfIndividsTextBox.Location = new System.Drawing.Point(206, 35);
            this.NumberOfIndividsTextBox.Name = "NumberOfIndividsTextBox";
            this.NumberOfIndividsTextBox.Size = new System.Drawing.Size(124, 22);
            this.NumberOfIndividsTextBox.TabIndex = 7;
            this.NumberOfIndividsTextBox.Text = "2000";
            this.NumberOfIndividsTextBox.TextChanged += new System.EventHandler(this.NumberOfIndividsTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вероятность скрещивания:";
            // 
            // CrossoverRateTextBox
            // 
            this.CrossoverRateTextBox.Location = new System.Drawing.Point(206, 63);
            this.CrossoverRateTextBox.Name = "CrossoverRateTextBox";
            this.CrossoverRateTextBox.Size = new System.Drawing.Size(124, 22);
            this.CrossoverRateTextBox.TabIndex = 9;
            this.CrossoverRateTextBox.Text = "0.5";
            this.CrossoverRateTextBox.TextChanged += new System.EventHandler(this.CrossoverRateTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Вероятность мутации:";
            // 
            // MutateChanceTextBox
            // 
            this.MutateChanceTextBox.Location = new System.Drawing.Point(206, 91);
            this.MutateChanceTextBox.Name = "MutateChanceTextBox";
            this.MutateChanceTextBox.Size = new System.Drawing.Size(124, 22);
            this.MutateChanceTextBox.TabIndex = 11;
            this.MutateChanceTextBox.Text = "0.5";
            this.MutateChanceTextBox.TextChanged += new System.EventHandler(this.MutateChanceTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество итераций:";
            // 
            // NumberOfLivesTextBox
            // 
            this.NumberOfLivesTextBox.Location = new System.Drawing.Point(206, 119);
            this.NumberOfLivesTextBox.Name = "NumberOfLivesTextBox";
            this.NumberOfLivesTextBox.Size = new System.Drawing.Size(124, 22);
            this.NumberOfLivesTextBox.TabIndex = 13;
            this.NumberOfLivesTextBox.Text = "2000";
            this.NumberOfLivesTextBox.TextChanged += new System.EventHandler(this.NumberOfLivesTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 53);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 38);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // CheckBox1
            // 
            this.CheckBox1.Location = new System.Drawing.Point(6, 50);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(22, 24);
            this.CheckBox1.TabIndex = 17;
            this.CheckBox1.Text = "\r\n";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FunctionsGroupBox
            // 
            this.FunctionsGroupBox.Controls.Add(this.CheckBox5);
            this.FunctionsGroupBox.Controls.Add(this.pictureBox5);
            this.FunctionsGroupBox.Controls.Add(this.CheckBox4);
            this.FunctionsGroupBox.Controls.Add(this.CheckBox3);
            this.FunctionsGroupBox.Controls.Add(this.pictureBox4);
            this.FunctionsGroupBox.Controls.Add(this.pictureBox3);
            this.FunctionsGroupBox.Controls.Add(this.CheckBox1);
            this.FunctionsGroupBox.Controls.Add(this.CheckBox2);
            this.FunctionsGroupBox.Controls.Add(this.pictureBox2);
            this.FunctionsGroupBox.Controls.Add(this.pictureBox1);
            this.FunctionsGroupBox.Location = new System.Drawing.Point(438, 12);
            this.FunctionsGroupBox.Name = "FunctionsGroupBox";
            this.FunctionsGroupBox.Size = new System.Drawing.Size(350, 594);
            this.FunctionsGroupBox.TabIndex = 18;
            this.FunctionsGroupBox.TabStop = false;
            this.FunctionsGroupBox.Text = "Функции";
            // 
            // CheckBox5
            // 
            this.CheckBox5.Location = new System.Drawing.Point(6, 339);
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.Size = new System.Drawing.Size(26, 24);
            this.CheckBox5.TabIndex = 24;
            this.CheckBox5.UseVisualStyleBackColor = true;
            this.CheckBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(47, 319);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(297, 59);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // CheckBox4
            // 
            this.CheckBox4.Location = new System.Drawing.Point(6, 256);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(22, 24);
            this.CheckBox4.TabIndex = 22;
            this.CheckBox4.Text = "\r\n";
            this.CheckBox4.UseVisualStyleBackColor = true;
            this.CheckBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // CheckBox3
            // 
            this.CheckBox3.Location = new System.Drawing.Point(6, 182);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(22, 24);
            this.CheckBox3.TabIndex = 21;
            this.CheckBox3.Text = "\r\n";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(47, 239);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(297, 59);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(47, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 53);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // CheckBox2
            // 
            this.CheckBox2.Location = new System.Drawing.Point(6, 118);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(22, 24);
            this.CheckBox2.TabIndex = 18;
            this.CheckBox2.Text = "\r\n";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Правая граница:";
            // 
            // RightBorderTextBox
            // 
            this.RightBorderTextBox.Enabled = false;
            this.RightBorderTextBox.Location = new System.Drawing.Point(206, 88);
            this.RightBorderTextBox.Name = "RightBorderTextBox";
            this.RightBorderTextBox.Size = new System.Drawing.Size(124, 22);
            this.RightBorderTextBox.TabIndex = 5;
            this.RightBorderTextBox.Text = " ";
            // 
            // LeftBorderTextBox
            // 
            this.LeftBorderTextBox.Enabled = false;
            this.LeftBorderTextBox.Location = new System.Drawing.Point(206, 58);
            this.LeftBorderTextBox.Name = "LeftBorderTextBox";
            this.LeftBorderTextBox.Size = new System.Drawing.Size(124, 22);
            this.LeftBorderTextBox.TabIndex = 3;
            this.LeftBorderTextBox.Text = " ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Левая граница:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RightBorderTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CountOfElementsTextBox);
            this.groupBox2.Controls.Add(this.LeftBorderTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(18, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 117);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Неизменяемые параметры";
            // 
            // ChangeableParameters
            // 
            this.ChangeableParameters.Controls.Add(this.NumberOfLives);
            this.ChangeableParameters.Controls.Add(this.MutationChance);
            this.ChangeableParameters.Controls.Add(this.CrossoverRate);
            this.ChangeableParameters.Controls.Add(this.PopulationError);
            this.ChangeableParameters.Controls.Add(this.label4);
            this.ChangeableParameters.Controls.Add(this.NumberOfIndividsTextBox);
            this.ChangeableParameters.Controls.Add(this.label5);
            this.ChangeableParameters.Controls.Add(this.label7);
            this.ChangeableParameters.Controls.Add(this.NumberOfLivesTextBox);
            this.ChangeableParameters.Controls.Add(this.CrossoverRateTextBox);
            this.ChangeableParameters.Controls.Add(this.MutateChanceTextBox);
            this.ChangeableParameters.Controls.Add(this.label6);
            this.ChangeableParameters.Location = new System.Drawing.Point(18, 12);
            this.ChangeableParameters.Name = "ChangeableParameters";
            this.ChangeableParameters.Size = new System.Drawing.Size(357, 180);
            this.ChangeableParameters.TabIndex = 22;
            this.ChangeableParameters.TabStop = false;
            this.ChangeableParameters.Text = "Изменяемые параметры";
            // 
            // NumberOfLives
            // 
            this.NumberOfLives.Image = ((System.Drawing.Image)(resources.GetObject("NumberOfLives.Image")));
            this.NumberOfLives.Location = new System.Drawing.Point(337, 120);
            this.NumberOfLives.Name = "NumberOfLives";
            this.NumberOfLives.Size = new System.Drawing.Size(20, 21);
            this.NumberOfLives.TabIndex = 28;
            this.NumberOfLives.TabStop = false;
            this.NumberOfLives.Visible = false;
            // 
            // MutationChance
            // 
            this.MutationChance.Image = ((System.Drawing.Image)(resources.GetObject("MutationChance.Image")));
            this.MutationChance.Location = new System.Drawing.Point(337, 92);
            this.MutationChance.Name = "MutationChance";
            this.MutationChance.Size = new System.Drawing.Size(20, 21);
            this.MutationChance.TabIndex = 28;
            this.MutationChance.TabStop = false;
            this.MutationChance.Visible = false;
            // 
            // CrossoverRate
            // 
            this.CrossoverRate.Image = ((System.Drawing.Image)(resources.GetObject("CrossoverRate.Image")));
            this.CrossoverRate.Location = new System.Drawing.Point(336, 64);
            this.CrossoverRate.Name = "CrossoverRate";
            this.CrossoverRate.Size = new System.Drawing.Size(20, 21);
            this.CrossoverRate.TabIndex = 28;
            this.CrossoverRate.TabStop = false;
            this.CrossoverRate.Visible = false;
            // 
            // PopulationError
            // 
            this.PopulationError.Image = ((System.Drawing.Image)(resources.GetObject("PopulationError.Image")));
            this.PopulationError.Location = new System.Drawing.Point(336, 36);
            this.PopulationError.Name = "PopulationError";
            this.PopulationError.Size = new System.Drawing.Size(20, 21);
            this.PopulationError.TabIndex = 27;
            this.PopulationError.TabStop = false;
            this.PopulationError.Visible = false;
            // 
            // StartGeneticButton
            // 
            this.StartGeneticButton.Location = new System.Drawing.Point(11, 245);
            this.StartGeneticButton.Name = "StartGeneticButton";
            this.StartGeneticButton.Size = new System.Drawing.Size(336, 34);
            this.StartGeneticButton.TabIndex = 23;
            this.StartGeneticButton.Text = "Начать поиск минимума";
            this.StartGeneticButton.UseVisualStyleBackColor = true;
            this.StartGeneticButton.Click += new System.EventHandler(this.StartGeneticButton_Click);
            // 
            // MinimumTextBox
            // 
            this.MinimumTextBox.Location = new System.Drawing.Point(11, 21);
            this.MinimumTextBox.Multiline = true;
            this.MinimumTextBox.Name = "MinimumTextBox";
            this.MinimumTextBox.Size = new System.Drawing.Size(336, 218);
            this.MinimumTextBox.TabIndex = 25;
            this.MinimumTextBox.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinimumTextBox);
            this.groupBox1.Controls.Add(this.StartGeneticButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 285);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Найденный минимум";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChangeableParameters);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FunctionsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneticAlgorithm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.FunctionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ChangeableParameters.ResumeLayout(false);
            this.ChangeableParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutationChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossoverRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationError)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox CheckBox5;

        private System.Windows.Forms.PictureBox pictureBox5;

        private System.Windows.Forms.CheckBox CheckBox3;
        private System.Windows.Forms.CheckBox CheckBox4;

        private System.Windows.Forms.PictureBox pictureBox4;

        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.PictureBox CrossoverRate;
        private System.Windows.Forms.PictureBox MutationChance;
        private System.Windows.Forms.PictureBox NumberOfLives;

        private System.Windows.Forms.PictureBox PopulationError;

        private System.Windows.Forms.Button StartGeneticButton;
        private System.Windows.Forms.TextBox MinimumTextBox;

        private System.Windows.Forms.GroupBox ChangeableParameters;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.CheckBox CheckBox2;

        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.GroupBox FunctionsGroupBox;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.TextBox NumberOfLivesTextBox;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MutateChanceTextBox;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CrossoverRateTextBox;

        private System.Windows.Forms.TextBox RightBorderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberOfIndividsTextBox;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LeftBorderTextBox;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox CountOfElementsTextBox;

        #endregion
    }
}