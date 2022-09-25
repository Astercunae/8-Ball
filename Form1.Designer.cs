namespace Magic_8_Ball
{
    partial class MagicEightBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagicEightBall));
            this.submitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.predictionText = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Black;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(12, 417);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(202, 47);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Tell me!";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 362);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Напиши сюда свой вопрос";
            this.textBox1.Size = new System.Drawing.Size(202, 49);
            this.textBox1.TabIndex = 1;
            // 
            // predictionText
            // 
            this.predictionText.BackColor = System.Drawing.Color.Transparent;
            this.predictionText.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.predictionText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.predictionText.Location = new System.Drawing.Point(333, 173);
            this.predictionText.Name = "predictionText";
            this.predictionText.Size = new System.Drawing.Size(129, 120);
            this.predictionText.TabIndex = 2;
            this.predictionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearBtn
            // 
            this.clearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearBtn.BackgroundImage")));
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.Location = new System.Drawing.Point(12, 331);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(25, 25);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // MagicEightBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.predictionText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MagicEightBall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button submitButton;
        private TextBox textBox1;
        private Label predictionText;
        private Button clearBtn;
    }
}