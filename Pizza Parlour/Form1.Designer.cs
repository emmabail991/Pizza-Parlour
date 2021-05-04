
namespace Pizza_Parlour
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
            this.pizzaParlour = new System.Windows.Forms.Label();
            this.NumberofToppinglabel = new System.Windows.Forms.Label();
            this.inputTopping = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pizzaParlour
            // 
            this.pizzaParlour.BackColor = System.Drawing.Color.DarkRed;
            this.pizzaParlour.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaParlour.Location = new System.Drawing.Point(12, 9);
            this.pizzaParlour.Name = "pizzaParlour";
            this.pizzaParlour.Size = new System.Drawing.Size(535, 64);
            this.pizzaParlour.TabIndex = 0;
            this.pizzaParlour.Text = "Pizza Parlour";
            this.pizzaParlour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberofToppinglabel
            // 
            this.NumberofToppinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofToppinglabel.ForeColor = System.Drawing.Color.White;
            this.NumberofToppinglabel.Location = new System.Drawing.Point(79, 163);
            this.NumberofToppinglabel.Name = "NumberofToppinglabel";
            this.NumberofToppinglabel.Size = new System.Drawing.Size(208, 31);
            this.NumberofToppinglabel.TabIndex = 1;
            this.NumberofToppinglabel.Text = "Number of Toppings";
            // 
            // inputTopping
            // 
            this.inputTopping.Location = new System.Drawing.Point(303, 169);
            this.inputTopping.Name = "inputTopping";
            this.inputTopping.Size = new System.Drawing.Size(133, 20);
            this.inputTopping.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calculateButton.Location = new System.Drawing.Point(197, 240);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(123, 43);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate ";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(81, 343);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(355, 77);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Welcome to amazing pizza pizzas parlour please enter the amount of topping!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputTopping);
            this.Controls.Add(this.NumberofToppinglabel);
            this.Controls.Add(this.pizzaParlour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Amazing  Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzaParlour;
        private System.Windows.Forms.Label NumberofToppinglabel;
        private System.Windows.Forms.TextBox inputTopping;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

