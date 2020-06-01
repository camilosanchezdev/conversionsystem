namespace ConversionSystem
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.decimalBtn = new System.Windows.Forms.Button();
            this.binrayBtn = new System.Windows.Forms.Button();
            this.octalBtn = new System.Windows.Forms.Button();
            this.hexaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.decimalTextBox = new System.Windows.Forms.TextBox();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.octalTextBox = new System.Windows.Forms.TextBox();
            this.hexadecimalTextBox = new System.Windows.Forms.TextBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion System";
            // 
            // decimalBtn
            // 
            this.decimalBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.decimalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalBtn.Location = new System.Drawing.Point(29, 127);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(208, 39);
            this.decimalBtn.TabIndex = 1;
            this.decimalBtn.Text = "Decimal to";
            this.decimalBtn.UseVisualStyleBackColor = false;
            this.decimalBtn.Click += new System.EventHandler(this.decimalBtn_Click);
            // 
            // binrayBtn
            // 
            this.binrayBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.binrayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binrayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binrayBtn.Location = new System.Drawing.Point(29, 196);
            this.binrayBtn.Name = "binrayBtn";
            this.binrayBtn.Size = new System.Drawing.Size(208, 39);
            this.binrayBtn.TabIndex = 2;
            this.binrayBtn.Text = "Binary to";
            this.binrayBtn.UseVisualStyleBackColor = false;
            this.binrayBtn.Click += new System.EventHandler(this.binrayBtn_Click);
            // 
            // octalBtn
            // 
            this.octalBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.octalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.octalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octalBtn.Location = new System.Drawing.Point(29, 266);
            this.octalBtn.Name = "octalBtn";
            this.octalBtn.Size = new System.Drawing.Size(208, 39);
            this.octalBtn.TabIndex = 3;
            this.octalBtn.Text = "Octal to";
            this.octalBtn.UseVisualStyleBackColor = false;
            this.octalBtn.Click += new System.EventHandler(this.octalBtn_Click);
            // 
            // hexaBtn
            // 
            this.hexaBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.hexaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hexaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexaBtn.Location = new System.Drawing.Point(29, 330);
            this.hexaBtn.Name = "hexaBtn";
            this.hexaBtn.Size = new System.Drawing.Size(208, 39);
            this.hexaBtn.TabIndex = 4;
            this.hexaBtn.Text = "Hexadecimal to";
            this.hexaBtn.UseVisualStyleBackColor = false;
            this.hexaBtn.Click += new System.EventHandler(this.hexaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Decimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Binary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Octal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hexadecimal";
            // 
            // decimalTextBox
            // 
            this.decimalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalTextBox.Location = new System.Drawing.Point(528, 127);
            this.decimalTextBox.Name = "decimalTextBox";
            this.decimalTextBox.Size = new System.Drawing.Size(236, 30);
            this.decimalTextBox.TabIndex = 9;
            this.decimalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalTextBox_KeyPress);
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTextBox.Location = new System.Drawing.Point(528, 196);
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.ReadOnly = true;
            this.binaryTextBox.Size = new System.Drawing.Size(236, 30);
            this.binaryTextBox.TabIndex = 10;
            this.binaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.binaryTextBox_KeyPress);
            // 
            // octalTextBox
            // 
            this.octalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octalTextBox.Location = new System.Drawing.Point(528, 266);
            this.octalTextBox.Name = "octalTextBox";
            this.octalTextBox.ReadOnly = true;
            this.octalTextBox.Size = new System.Drawing.Size(236, 30);
            this.octalTextBox.TabIndex = 11;
            this.octalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.octalTextBox_KeyPress);
            // 
            // hexadecimalTextBox
            // 
            this.hexadecimalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexadecimalTextBox.Location = new System.Drawing.Point(528, 330);
            this.hexadecimalTextBox.Name = "hexadecimalTextBox";
            this.hexadecimalTextBox.ReadOnly = true;
            this.hexadecimalTextBox.Size = new System.Drawing.Size(236, 30);
            this.hexadecimalTextBox.TabIndex = 12;
            // 
            // convertBtn
            // 
            this.convertBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.convertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.Location = new System.Drawing.Point(359, 390);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(178, 39);
            this.convertBtn.TabIndex = 13;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(580, 390);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(184, 39);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.hexadecimalTextBox);
            this.Controls.Add(this.octalTextBox);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.decimalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hexaBtn);
            this.Controls.Add(this.octalBtn);
            this.Controls.Add(this.binrayBtn);
            this.Controls.Add(this.decimalBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversion System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decimalBtn;
        private System.Windows.Forms.Button binrayBtn;
        private System.Windows.Forms.Button octalBtn;
        private System.Windows.Forms.Button hexaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox decimalTextBox;
        private System.Windows.Forms.TextBox binaryTextBox;
        private System.Windows.Forms.TextBox octalTextBox;
        private System.Windows.Forms.TextBox hexadecimalTextBox;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

