
namespace BugJump
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lowerColumn = new System.Windows.Forms.PictureBox();
            this.debugConsole = new System.Windows.Forms.PictureBox();
            this.upperColumn = new System.Windows.Forms.PictureBox();
            this.debugBug = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lowerColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugConsole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugBug)).BeginInit();
            this.SuspendLayout();
            // 
            // lowerColumn
            // 
            this.lowerColumn.Image = global::BugJump.Properties.Resources.lowerColumn1;
            this.lowerColumn.Location = new System.Drawing.Point(369, 443);
            this.lowerColumn.Name = "lowerColumn";
            this.lowerColumn.Size = new System.Drawing.Size(105, 227);
            this.lowerColumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowerColumn.TabIndex = 3;
            this.lowerColumn.TabStop = false;
            // 
            // debugConsole
            // 
            this.debugConsole.Image = global::BugJump.Properties.Resources.debugConsole;
            this.debugConsole.Location = new System.Drawing.Point(0, 656);
            this.debugConsole.Name = "debugConsole";
            this.debugConsole.Size = new System.Drawing.Size(801, 104);
            this.debugConsole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.debugConsole.TabIndex = 2;
            this.debugConsole.TabStop = false;
            // 
            // upperColumn
            // 
            this.upperColumn.Image = global::BugJump.Properties.Resources.upperColumn1;
            this.upperColumn.Location = new System.Drawing.Point(457, -8);
            this.upperColumn.Name = "upperColumn";
            this.upperColumn.Size = new System.Drawing.Size(100, 207);
            this.upperColumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upperColumn.TabIndex = 1;
            this.upperColumn.TabStop = false;
            // 
            // debugBug
            // 
            this.debugBug.Image = global::BugJump.Properties.Resources.debugBug1;
            this.debugBug.Location = new System.Drawing.Point(36, 134);
            this.debugBug.Name = "debugBug";
            this.debugBug.Size = new System.Drawing.Size(102, 100);
            this.debugBug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.debugBug.TabIndex = 0;
            this.debugBug.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.scoreText.Location = new System.Drawing.Point(12, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(250, 35);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Clean Code Streak: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 763);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.debugConsole);
            this.Controls.Add(this.upperColumn);
            this.Controls.Add(this.debugBug);
            this.Controls.Add(this.lowerColumn);
            this.Name = "Form";
            this.Text = "Bug Jump";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.lowerColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugConsole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugBug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox debugBug;
        private System.Windows.Forms.PictureBox upperColumn;
        private System.Windows.Forms.PictureBox debugConsole;
        private System.Windows.Forms.PictureBox lowerColumn;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

