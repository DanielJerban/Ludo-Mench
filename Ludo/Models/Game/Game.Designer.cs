using Ludo.Extensions;
using System.Drawing;

namespace Ludo.Models.Game
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.bluePawn3 = new System.Windows.Forms.Button();
            this.bluePawn1 = new System.Windows.Forms.Button();
            this.bluePawn0 = new System.Windows.Forms.Button();
            this.bluePawn2 = new System.Windows.Forms.Button();
            this.yellowPawn3 = new System.Windows.Forms.Button();
            this.yellowPawn1 = new System.Windows.Forms.Button();
            this.yellowPawn0 = new System.Windows.Forms.Button();
            this.yellowPawn2 = new System.Windows.Forms.Button();
            this.greenPawn3 = new System.Windows.Forms.Button();
            this.greenPawn1 = new System.Windows.Forms.Button();
            this.greenPawn0 = new System.Windows.Forms.Button();
            this.greenPawn2 = new System.Windows.Forms.Button();
            this.redPawn3 = new System.Windows.Forms.Button();
            this.redPawn2 = new System.Windows.Forms.Button();
            this.redPawn1 = new System.Windows.Forms.Button();
            this.redPawn0 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEscapedCount = new System.Windows.Forms.Label();
            this.pbEscapedPawn = new System.Windows.Forms.PictureBox();
            this.lblEscaped = new System.Windows.Forms.Label();
            this.lblStandart = new System.Windows.Forms.Label();
            this.lblStandartName = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnDiceStandart = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscapedPawn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 83);
            this.label1.TabIndex = 83;
            this.label1.Text = "Created and Designed\r\nby\r\nDaniel Jerban";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bluePawn3
            // 
            this.bluePawn3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bluePawn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bluePawn3.BackgroundImage")));
            this.bluePawn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bluePawn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bluePawn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluePawn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePawn3.Location = new System.Drawing.Point(153, 29);
            this.bluePawn3.Name = "bluePawn3";
            this.bluePawn3.Size = new System.Drawing.Size(25, 25);
            this.bluePawn3.TabIndex = 82;
            this.bluePawn3.UseVisualStyleBackColor = false;
            this.bluePawn3.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // bluePawn1
            // 
            this.bluePawn1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bluePawn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bluePawn1.BackgroundImage")));
            this.bluePawn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bluePawn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bluePawn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluePawn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePawn1.Location = new System.Drawing.Point(153, -2);
            this.bluePawn1.Name = "bluePawn1";
            this.bluePawn1.Size = new System.Drawing.Size(25, 25);
            this.bluePawn1.TabIndex = 81;
            this.bluePawn1.UseVisualStyleBackColor = false;
            this.bluePawn1.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // bluePawn0
            // 
            this.bluePawn0.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bluePawn0.BackgroundImage = global::Ludo.Properties.Resources.PawnGreen;
            this.bluePawn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bluePawn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bluePawn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluePawn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePawn0.Location = new System.Drawing.Point(122, -2);
            this.bluePawn0.Name = "bluePawn0";
            this.bluePawn0.Size = new System.Drawing.Size(25, 25);
            this.bluePawn0.TabIndex = 80;
            this.bluePawn0.UseVisualStyleBackColor = false;
            this.bluePawn0.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // bluePawn2
            // 
            this.bluePawn2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bluePawn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bluePawn2.BackgroundImage")));
            this.bluePawn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bluePawn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bluePawn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluePawn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePawn2.Location = new System.Drawing.Point(122, 29);
            this.bluePawn2.Name = "bluePawn2";
            this.bluePawn2.Size = new System.Drawing.Size(25, 25);
            this.bluePawn2.TabIndex = 79;
            this.bluePawn2.UseVisualStyleBackColor = false;
            this.bluePawn2.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // yellowPawn3
            // 
            this.yellowPawn3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.yellowPawn3.BackgroundImage = global::Ludo.Properties.Resources.PawnYellow;
            this.yellowPawn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yellowPawn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yellowPawn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowPawn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowPawn3.Location = new System.Drawing.Point(153, 473);
            this.yellowPawn3.Name = "yellowPawn3";
            this.yellowPawn3.Size = new System.Drawing.Size(25, 25);
            this.yellowPawn3.TabIndex = 78;
            this.yellowPawn3.UseVisualStyleBackColor = false;
            this.yellowPawn3.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // yellowPawn1
            // 
            this.yellowPawn1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.yellowPawn1.BackgroundImage = global::Ludo.Properties.Resources.PawnYellow;
            this.yellowPawn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yellowPawn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yellowPawn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowPawn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowPawn1.Location = new System.Drawing.Point(153, 442);
            this.yellowPawn1.Name = "yellowPawn1";
            this.yellowPawn1.Size = new System.Drawing.Size(25, 25);
            this.yellowPawn1.TabIndex = 77;
            this.yellowPawn1.UseVisualStyleBackColor = false;
            this.yellowPawn1.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // yellowPawn0
            // 
            this.yellowPawn0.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.yellowPawn0.BackgroundImage = global::Ludo.Properties.Resources.PawnYellow;
            this.yellowPawn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yellowPawn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yellowPawn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowPawn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowPawn0.Location = new System.Drawing.Point(122, 442);
            this.yellowPawn0.Name = "yellowPawn0";
            this.yellowPawn0.Size = new System.Drawing.Size(25, 25);
            this.yellowPawn0.TabIndex = 76;
            this.yellowPawn0.UseVisualStyleBackColor = false;
            this.yellowPawn0.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // yellowPawn2
            // 
            this.yellowPawn2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.yellowPawn2.BackgroundImage = global::Ludo.Properties.Resources.PawnYellow;
            this.yellowPawn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yellowPawn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yellowPawn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowPawn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowPawn2.Location = new System.Drawing.Point(122, 473);
            this.yellowPawn2.Name = "yellowPawn2";
            this.yellowPawn2.Size = new System.Drawing.Size(25, 25);
            this.yellowPawn2.TabIndex = 75;
            this.yellowPawn2.UseVisualStyleBackColor = false;
            this.yellowPawn2.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // greenPawn3
            // 
            this.greenPawn3.BackColor = System.Drawing.Color.DarkGreen;
            this.greenPawn3.BackgroundImage = global::Ludo.Properties.Resources.PawnBlue;
            this.greenPawn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.greenPawn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.greenPawn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenPawn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenPawn3.Location = new System.Drawing.Point(597, 473);
            this.greenPawn3.Name = "greenPawn3";
            this.greenPawn3.Size = new System.Drawing.Size(25, 25);
            this.greenPawn3.TabIndex = 74;
            this.greenPawn3.UseVisualStyleBackColor = false;
            this.greenPawn3.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // greenPawn1
            // 
            this.greenPawn1.BackColor = System.Drawing.Color.DarkGreen;
            this.greenPawn1.BackgroundImage = global::Ludo.Properties.Resources.PawnBlue;
            this.greenPawn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.greenPawn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.greenPawn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenPawn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenPawn1.Location = new System.Drawing.Point(597, 442);
            this.greenPawn1.Name = "greenPawn1";
            this.greenPawn1.Size = new System.Drawing.Size(25, 25);
            this.greenPawn1.TabIndex = 73;
            this.greenPawn1.UseVisualStyleBackColor = false;
            this.greenPawn1.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // greenPawn0
            // 
            this.greenPawn0.BackColor = System.Drawing.Color.DarkGreen;
            this.greenPawn0.BackgroundImage = global::Ludo.Properties.Resources.PawnBlue;
            this.greenPawn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.greenPawn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.greenPawn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenPawn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenPawn0.Location = new System.Drawing.Point(566, 442);
            this.greenPawn0.Name = "greenPawn0";
            this.greenPawn0.Size = new System.Drawing.Size(25, 25);
            this.greenPawn0.TabIndex = 72;
            this.greenPawn0.UseVisualStyleBackColor = false;
            this.greenPawn0.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // greenPawn2
            // 
            this.greenPawn2.BackColor = System.Drawing.Color.DarkGreen;
            this.greenPawn2.BackgroundImage = global::Ludo.Properties.Resources.PawnBlue;
            this.greenPawn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.greenPawn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.greenPawn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenPawn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenPawn2.Location = new System.Drawing.Point(566, 473);
            this.greenPawn2.Name = "greenPawn2";
            this.greenPawn2.Size = new System.Drawing.Size(25, 25);
            this.greenPawn2.TabIndex = 71;
            this.greenPawn2.UseVisualStyleBackColor = false;
            this.greenPawn2.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // redPawn3
            // 
            this.redPawn3.BackColor = System.Drawing.Color.DarkRed;
            this.redPawn3.BackgroundImage = global::Ludo.Properties.Resources.PawnRed;
            this.redPawn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redPawn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.redPawn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redPawn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redPawn3.Location = new System.Drawing.Point(597, 29);
            this.redPawn3.Name = "redPawn3";
            this.redPawn3.Size = new System.Drawing.Size(25, 25);
            this.redPawn3.TabIndex = 70;
            this.redPawn3.UseVisualStyleBackColor = false;
            this.redPawn3.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // redPawn2
            // 
            this.redPawn2.BackColor = System.Drawing.Color.DarkRed;
            this.redPawn2.BackgroundImage = global::Ludo.Properties.Resources.PawnRed;
            this.redPawn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redPawn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.redPawn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redPawn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redPawn2.Location = new System.Drawing.Point(597, -2);
            this.redPawn2.Name = "redPawn2";
            this.redPawn2.Size = new System.Drawing.Size(25, 25);
            this.redPawn2.TabIndex = 69;
            this.redPawn2.UseVisualStyleBackColor = false;
            this.redPawn2.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // redPawn1
            // 
            this.redPawn1.BackColor = System.Drawing.Color.DarkRed;
            this.redPawn1.BackgroundImage = global::Ludo.Properties.Resources.PawnRed;
            this.redPawn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redPawn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.redPawn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redPawn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redPawn1.Location = new System.Drawing.Point(566, -2);
            this.redPawn1.Name = "redPawn1";
            this.redPawn1.Size = new System.Drawing.Size(25, 25);
            this.redPawn1.TabIndex = 68;
            this.redPawn1.UseVisualStyleBackColor = false;
            this.redPawn1.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // redPawn0
            // 
            this.redPawn0.BackColor = System.Drawing.Color.DarkRed;
            this.redPawn0.BackgroundImage = global::Ludo.Properties.Resources.PawnRed;
            this.redPawn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redPawn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.redPawn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redPawn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redPawn0.Location = new System.Drawing.Point(566, 29);
            this.redPawn0.Name = "redPawn0";
            this.redPawn0.Size = new System.Drawing.Size(25, 25);
            this.redPawn0.TabIndex = 67;
            this.redPawn0.UseVisualStyleBackColor = false;
            this.redPawn0.Click += new System.EventHandler(this.HandlePawnClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // lblEscapedCount
            // 
            this.lblEscapedCount.AutoSize = true;
            this.lblEscapedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEscapedCount.ForeColor = System.Drawing.Color.Black;
            this.lblEscapedCount.Location = new System.Drawing.Point(95, 58);
            this.lblEscapedCount.Name = "lblEscapedCount";
            this.lblEscapedCount.Size = new System.Drawing.Size(20, 13);
            this.lblEscapedCount.TabIndex = 65;
            this.lblEscapedCount.Text = "x0";
            // 
            // pbEscapedPawn
            // 
            this.pbEscapedPawn.BackColor = System.Drawing.Color.DarkRed;
            this.pbEscapedPawn.BackgroundImage = global::Ludo.Properties.Resources.PawnRed;
            this.pbEscapedPawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEscapedPawn.Location = new System.Drawing.Point(66, 45);
            this.pbEscapedPawn.Name = "pbEscapedPawn";
            this.pbEscapedPawn.Size = new System.Drawing.Size(25, 25);
            this.pbEscapedPawn.TabIndex = 64;
            this.pbEscapedPawn.TabStop = false;
            // 
            // lblEscaped
            // 
            this.lblEscaped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEscaped.ForeColor = System.Drawing.Color.Black;
            this.lblEscaped.Location = new System.Drawing.Point(1, 34);
            this.lblEscaped.Name = "lblEscaped";
            this.lblEscaped.Size = new System.Drawing.Size(61, 48);
            this.lblEscaped.TabIndex = 63;
            this.lblEscaped.Text = "Escaped pawns:";
            this.lblEscaped.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStandart
            // 
            this.lblStandart.AutoSize = true;
            this.lblStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStandart.ForeColor = System.Drawing.Color.Black;
            this.lblStandart.Location = new System.Drawing.Point(47, 149);
            this.lblStandart.Name = "lblStandart";
            this.lblStandart.Size = new System.Drawing.Size(14, 13);
            this.lblStandart.TabIndex = 62;
            this.lblStandart.Text = "0";
            this.lblStandart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStandartName
            // 
            this.lblStandartName.AutoSize = true;
            this.lblStandartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStandartName.ForeColor = System.Drawing.Color.Black;
            this.lblStandartName.Location = new System.Drawing.Point(21, 90);
            this.lblStandartName.Name = "lblStandartName";
            this.lblStandartName.Size = new System.Drawing.Size(72, 13);
            this.lblStandartName.TabIndex = 61;
            this.lblStandartName.Text = "Throw Dice";
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Black;
            this.lblTurn.Location = new System.Drawing.Point(0, -2);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(116, 44);
            this.lblTurn.TabIndex = 60;
            this.lblTurn.Text = "lblTurn";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDiceStandart
            // 
            this.btnDiceStandart.BackgroundImage = global::Ludo.Properties.Resources.Standart;
            this.btnDiceStandart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiceStandart.FlatAppearance.BorderSize = 0;
            this.btnDiceStandart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiceStandart.Location = new System.Drawing.Point(34, 106);
            this.btnDiceStandart.Name = "btnDiceStandart";
            this.btnDiceStandart.Size = new System.Drawing.Size(40, 40);
            this.btnDiceStandart.TabIndex = 59;
            this.btnDiceStandart.UseVisualStyleBackColor = true;
            this.btnDiceStandart.Click += new System.EventHandler(this.HandleDiceClick);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(12, 206);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(93, 13);
            this.lblWinner.TabIndex = 84;
            this.lblWinner.Text = "Player X is Winner";
            this.lblWinner.Visible = false;
            // 
            // Game
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(622, 500);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bluePawn3);
            this.Controls.Add(this.bluePawn1);
            this.Controls.Add(this.bluePawn0);
            this.Controls.Add(this.bluePawn2);
            this.Controls.Add(this.yellowPawn3);
            this.Controls.Add(this.yellowPawn1);
            this.Controls.Add(this.yellowPawn0);
            this.Controls.Add(this.yellowPawn2);
            this.Controls.Add(this.greenPawn3);
            this.Controls.Add(this.greenPawn1);
            this.Controls.Add(this.greenPawn0);
            this.Controls.Add(this.greenPawn2);
            this.Controls.Add(this.redPawn3);
            this.Controls.Add(this.redPawn2);
            this.Controls.Add(this.redPawn1);
            this.Controls.Add(this.redPawn0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEscapedCount);
            this.Controls.Add(this.pbEscapedPawn);
            this.Controls.Add(this.lblEscaped);
            this.Controls.Add(this.lblStandart);
            this.Controls.Add(this.lblStandartName);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnDiceStandart);
            this.Name = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscapedPawn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bluePawn3;
        private System.Windows.Forms.Button bluePawn1;
        private System.Windows.Forms.Button bluePawn0;
        private System.Windows.Forms.Button bluePawn2;
        private System.Windows.Forms.Button yellowPawn3;
        private System.Windows.Forms.Button yellowPawn1;
        private System.Windows.Forms.Button yellowPawn0;
        private System.Windows.Forms.Button yellowPawn2;
        private System.Windows.Forms.Button greenPawn3;
        private System.Windows.Forms.Button greenPawn1;
        private System.Windows.Forms.Button greenPawn0;
        private System.Windows.Forms.Button greenPawn2;
        private System.Windows.Forms.Button redPawn3;
        private System.Windows.Forms.Button redPawn2;
        private System.Windows.Forms.Button redPawn1;
        private System.Windows.Forms.Button redPawn0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEscapedCount;
        private System.Windows.Forms.PictureBox pbEscapedPawn;
        private System.Windows.Forms.Label lblEscaped;
        private System.Windows.Forms.Label lblStandart;
        private System.Windows.Forms.Label lblStandartName;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnDiceStandart;
        private System.Windows.Forms.Label lblWinner;
    }
}