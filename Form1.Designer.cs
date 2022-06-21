namespace Calculadora
{
    partial class Calculadora
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
            this.OP = new System.Windows.Forms.Label();
            this.RE = new System.Windows.Forms.Label();
            this.IgualA = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.operacion = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OP
            // 
            this.OP.AutoSize = true;
            this.OP.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OP.Location = new System.Drawing.Point(48, 31);
            this.OP.Name = "OP";
            this.OP.Size = new System.Drawing.Size(61, 13);
            this.OP.TabIndex = 34;
            this.OP.Text = "Operación";
            // 
            // RE
            // 
            this.RE.AllowDrop = true;
            this.RE.AutoSize = true;
            this.RE.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RE.Location = new System.Drawing.Point(209, 31);
            this.RE.Name = "RE";
            this.RE.Size = new System.Drawing.Size(61, 13);
            this.RE.TabIndex = 33;
            this.RE.Text = "Resultado";
            // 
            // IgualA
            // 
            this.IgualA.Location = new System.Drawing.Point(225, 179);
            this.IgualA.Name = "IgualA";
            this.IgualA.Size = new System.Drawing.Size(28, 26);
            this.IgualA.TabIndex = 32;
            this.IgualA.Text = "=";
            this.IgualA.UseVisualStyleBackColor = true;
            this.IgualA.Click += new System.EventHandler(this.IgualA_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(242, 147);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(28, 26);
            this.division.TabIndex = 31;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Location = new System.Drawing.Point(208, 147);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(28, 26);
            this.multiplicacion.TabIndex = 30;
            this.multiplicacion.Text = "x";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(242, 115);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(28, 26);
            this.resta.TabIndex = 29;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(208, 115);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(28, 26);
            this.suma.TabIndex = 28;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(70, 211);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(28, 26);
            this.num0.TabIndex = 27;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(104, 179);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(28, 26);
            this.num9.TabIndex = 26;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(70, 179);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(28, 26);
            this.num8.TabIndex = 25;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(36, 179);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(28, 26);
            this.num7.TabIndex = 24;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(104, 147);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(28, 26);
            this.num6.TabIndex = 23;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(70, 147);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(28, 26);
            this.num5.TabIndex = 22;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(36, 147);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(28, 26);
            this.num4.TabIndex = 21;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(104, 115);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(28, 26);
            this.num3.TabIndex = 20;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(70, 115);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(28, 26);
            this.num2.TabIndex = 19;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(36, 115);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(28, 26);
            this.num1.TabIndex = 18;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.EscribirLaOperacion);
            // 
            // operacion
            // 
            this.operacion.AutoSize = true;
            this.operacion.Location = new System.Drawing.Point(59, 78);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(0, 13);
            this.operacion.TabIndex = 35;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(222, 78);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 36;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 271);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.OP);
            this.Controls.Add(this.RE);
            this.Controls.Add(this.IgualA);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OP;
        private System.Windows.Forms.Label RE;
        private System.Windows.Forms.Button IgualA;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Label operacion;
        private System.Windows.Forms.Label resultado;
    }
}

