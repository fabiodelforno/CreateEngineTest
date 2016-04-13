namespace CreateEngineTest
{
    partial class engineTest
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceV = new System.Windows.Forms.TextBox();
            this.destV = new System.Windows.Forms.TextBox();
            this.tenButton = new System.Windows.Forms.RadioButton();
            this.twentyButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.attrNBox1 = new System.Windows.Forms.TextBox();
            this.attrEBox1 = new System.Windows.Forms.TextBox();
            this.attrNBox2 = new System.Windows.Forms.TextBox();
            this.attrNBox3 = new System.Windows.Forms.TextBox();
            this.attrNBox4 = new System.Windows.Forms.TextBox();
            this.attrNBox5 = new System.Windows.Forms.TextBox();
            this.attrEBox2 = new System.Windows.Forms.TextBox();
            this.attrEBox3 = new System.Windows.Forms.TextBox();
            this.attrEBox4 = new System.Windows.Forms.TextBox();
            this.attrEBox5 = new System.Windows.Forms.TextBox();
            this.typeTreeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SourceV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DestV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type Tree";
            // 
            // sourceV
            // 
            this.sourceV.Location = new System.Drawing.Point(37, 60);
            this.sourceV.Name = "sourceV";
            this.sourceV.Size = new System.Drawing.Size(33, 20);
            this.sourceV.TabIndex = 3;
            // 
            // destV
            // 
            this.destV.Location = new System.Drawing.Point(120, 60);
            this.destV.Name = "destV";
            this.destV.Size = new System.Drawing.Size(32, 20);
            this.destV.TabIndex = 4;
            // 
            // tenButton
            // 
            this.tenButton.AutoSize = true;
            this.tenButton.Location = new System.Drawing.Point(32, 168);
            this.tenButton.Name = "tenButton";
            this.tenButton.Size = new System.Drawing.Size(62, 17);
            this.tenButton.TabIndex = 6;
            this.tenButton.TabStop = true;
            this.tenButton.Text = "10 User";
            this.tenButton.UseVisualStyleBackColor = true;
            // 
            // twentyButton
            // 
            this.twentyButton.AutoSize = true;
            this.twentyButton.Location = new System.Drawing.Point(32, 191);
            this.twentyButton.Name = "twentyButton";
            this.twentyButton.Size = new System.Drawing.Size(62, 17);
            this.twentyButton.TabIndex = 7;
            this.twentyButton.TabStop = true;
            this.twentyButton.Text = "20 User";
            this.twentyButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Concorrenzialità";
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(37, 241);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(87, 40);
            this.go.TabIndex = 9;
            this.go.Text = "GO!";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Node Attribute";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Edge Attribute";
            // 
            // attrNBox1
            // 
            this.attrNBox1.Location = new System.Drawing.Point(167, 115);
            this.attrNBox1.Name = "attrNBox1";
            this.attrNBox1.Size = new System.Drawing.Size(72, 20);
            this.attrNBox1.TabIndex = 12;
            // 
            // attrEBox1
            // 
            this.attrEBox1.Location = new System.Drawing.Point(269, 115);
            this.attrEBox1.Name = "attrEBox1";
            this.attrEBox1.Size = new System.Drawing.Size(81, 20);
            this.attrEBox1.TabIndex = 13;
            // 
            // attrNBox2
            // 
            this.attrNBox2.Location = new System.Drawing.Point(167, 132);
            this.attrNBox2.Name = "attrNBox2";
            this.attrNBox2.Size = new System.Drawing.Size(72, 20);
            this.attrNBox2.TabIndex = 14;
            // 
            // attrNBox3
            // 
            this.attrNBox3.Location = new System.Drawing.Point(167, 148);
            this.attrNBox3.Name = "attrNBox3";
            this.attrNBox3.Size = new System.Drawing.Size(72, 20);
            this.attrNBox3.TabIndex = 15;
            // 
            // attrNBox4
            // 
            this.attrNBox4.Location = new System.Drawing.Point(167, 167);
            this.attrNBox4.Name = "attrNBox4";
            this.attrNBox4.Size = new System.Drawing.Size(72, 20);
            this.attrNBox4.TabIndex = 16;
            // 
            // attrNBox5
            // 
            this.attrNBox5.Location = new System.Drawing.Point(167, 186);
            this.attrNBox5.Name = "attrNBox5";
            this.attrNBox5.Size = new System.Drawing.Size(72, 20);
            this.attrNBox5.TabIndex = 17;
            // 
            // attrEBox2
            // 
            this.attrEBox2.Location = new System.Drawing.Point(269, 134);
            this.attrEBox2.Name = "attrEBox2";
            this.attrEBox2.Size = new System.Drawing.Size(81, 20);
            this.attrEBox2.TabIndex = 18;
            // 
            // attrEBox3
            // 
            this.attrEBox3.Location = new System.Drawing.Point(269, 153);
            this.attrEBox3.Name = "attrEBox3";
            this.attrEBox3.Size = new System.Drawing.Size(81, 20);
            this.attrEBox3.TabIndex = 19;
            // 
            // attrEBox4
            // 
            this.attrEBox4.Location = new System.Drawing.Point(269, 172);
            this.attrEBox4.Name = "attrEBox4";
            this.attrEBox4.Size = new System.Drawing.Size(81, 20);
            this.attrEBox4.TabIndex = 20;
            // 
            // attrEBox5
            // 
            this.attrEBox5.Location = new System.Drawing.Point(269, 191);
            this.attrEBox5.Name = "attrEBox5";
            this.attrEBox5.Size = new System.Drawing.Size(81, 20);
            this.attrEBox5.TabIndex = 21;
            // 
            // typeTreeBox
            // 
            this.typeTreeBox.FormattingEnabled = true;
            this.typeTreeBox.Location = new System.Drawing.Point(209, 59);
            this.typeTreeBox.Name = "typeTreeBox";
            this.typeTreeBox.Size = new System.Drawing.Size(121, 21);
            this.typeTreeBox.TabIndex = 22;
            // 
            // engineTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 375);
            this.Controls.Add(this.typeTreeBox);
            this.Controls.Add(this.attrEBox5);
            this.Controls.Add(this.attrEBox4);
            this.Controls.Add(this.attrEBox3);
            this.Controls.Add(this.attrEBox2);
            this.Controls.Add(this.attrNBox5);
            this.Controls.Add(this.attrNBox4);
            this.Controls.Add(this.attrNBox3);
            this.Controls.Add(this.attrNBox2);
            this.Controls.Add(this.attrEBox1);
            this.Controls.Add(this.attrNBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.go);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.twentyButton);
            this.Controls.Add(this.tenButton);
            this.Controls.Add(this.destV);
            this.Controls.Add(this.sourceV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "engineTest";
            this.Text = "EngineTest";
            this.Load += new System.EventHandler(this.engineTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sourceV;
        private System.Windows.Forms.TextBox destV;
        private System.Windows.Forms.RadioButton tenButton;
        private System.Windows.Forms.RadioButton twentyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox attrNBox1;
        private System.Windows.Forms.TextBox attrEBox1;
        private System.Windows.Forms.TextBox attrNBox2;
        private System.Windows.Forms.TextBox attrNBox3;
        private System.Windows.Forms.TextBox attrNBox4;
        private System.Windows.Forms.TextBox attrNBox5;
        private System.Windows.Forms.TextBox attrEBox2;
        private System.Windows.Forms.TextBox attrEBox3;
        private System.Windows.Forms.TextBox attrEBox4;
        private System.Windows.Forms.TextBox attrEBox5;
        private System.Windows.Forms.ComboBox typeTreeBox;
    }
}

