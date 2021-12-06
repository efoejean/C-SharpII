
namespace Exercise1Shapes
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
            this.cubeLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.cubeSurfaceAreaLabel = new System.Windows.Forms.Label();
            this.surfaceAreaLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.cubeVolumeLabel = new System.Windows.Forms.Label();
            this.cubeSizeTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.enlargeButton = new System.Windows.Forms.Button();
            this.negativeButton = new System.Windows.Forms.Button();
            this.sphereLabel = new System.Windows.Forms.Label();
            this.sphereSizeTextBox = new System.Windows.Forms.TextBox();
            this.sphereVolumeLabel = new System.Windows.Forms.Label();
            this.sphereSurfaceAreaLabel = new System.Windows.Forms.Label();
            this.tetraLabel = new System.Windows.Forms.Label();
            this.tetraSizeTextBox = new System.Windows.Forms.TextBox();
            this.tetraVolumeLabel = new System.Windows.Forms.Label();
            this.tetraSurfaceAreaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cubeLabel
            // 
            this.cubeLabel.AutoSize = true;
            this.cubeLabel.Location = new System.Drawing.Point(58, 96);
            this.cubeLabel.Name = "cubeLabel";
            this.cubeLabel.Size = new System.Drawing.Size(35, 13);
            this.cubeLabel.TabIndex = 0;
            this.cubeLabel.Text = "Cube:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(154, 62);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Size";
            // 
            // cubeSurfaceAreaLabel
            // 
            this.cubeSurfaceAreaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubeSurfaceAreaLabel.Location = new System.Drawing.Point(355, 96);
            this.cubeSurfaceAreaLabel.Name = "cubeSurfaceAreaLabel";
            this.cubeSurfaceAreaLabel.Size = new System.Drawing.Size(82, 23);
            this.cubeSurfaceAreaLabel.TabIndex = 3;
            // 
            // surfaceAreaLabel
            // 
            this.surfaceAreaLabel.AutoSize = true;
            this.surfaceAreaLabel.Location = new System.Drawing.Point(368, 62);
            this.surfaceAreaLabel.Name = "surfaceAreaLabel";
            this.surfaceAreaLabel.Size = new System.Drawing.Size(69, 13);
            this.surfaceAreaLabel.TabIndex = 4;
            this.surfaceAreaLabel.Text = "Surface Area";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(262, 62);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeLabel.TabIndex = 5;
            this.volumeLabel.Text = "Volume";
            // 
            // cubeVolumeLabel
            // 
            this.cubeVolumeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubeVolumeLabel.Location = new System.Drawing.Point(247, 96);
            this.cubeVolumeLabel.Name = "cubeVolumeLabel";
            this.cubeVolumeLabel.Size = new System.Drawing.Size(74, 23);
            this.cubeVolumeLabel.TabIndex = 6;
            // 
            // cubeSizeTextBox
            // 
            this.cubeSizeTextBox.Location = new System.Drawing.Point(124, 99);
            this.cubeSizeTextBox.Name = "cubeSizeTextBox";
            this.cubeSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cubeSizeTextBox.TabIndex = 7;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(472, 91);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(91, 34);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create bigger shapes";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // enlargeButton
            // 
            this.enlargeButton.Location = new System.Drawing.Point(472, 151);
            this.enlargeButton.Name = "enlargeButton";
            this.enlargeButton.Size = new System.Drawing.Size(91, 23);
            this.enlargeButton.TabIndex = 9;
            this.enlargeButton.Text = "Enlarge 10%";
            this.enlargeButton.UseVisualStyleBackColor = true;
            this.enlargeButton.Click += new System.EventHandler(this.enlargeButton_Click);
            // 
            // negativeButton
            // 
            this.negativeButton.Location = new System.Drawing.Point(472, 187);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(91, 38);
            this.negativeButton.TabIndex = 10;
            this.negativeButton.Text = "Try a negative size";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.negativeButton_Click);
            // 
            // sphereLabel
            // 
            this.sphereLabel.AutoSize = true;
            this.sphereLabel.Location = new System.Drawing.Point(61, 151);
            this.sphereLabel.Name = "sphereLabel";
            this.sphereLabel.Size = new System.Drawing.Size(44, 13);
            this.sphereLabel.TabIndex = 11;
            this.sphereLabel.Text = "Sphere:";
            // 
            // sphereSizeTextBox
            // 
            this.sphereSizeTextBox.Location = new System.Drawing.Point(124, 151);
            this.sphereSizeTextBox.Name = "sphereSizeTextBox";
            this.sphereSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sphereSizeTextBox.TabIndex = 12;
            // 
            // sphereVolumeLabel
            // 
            this.sphereVolumeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sphereVolumeLabel.Location = new System.Drawing.Point(247, 150);
            this.sphereVolumeLabel.Name = "sphereVolumeLabel";
            this.sphereVolumeLabel.Size = new System.Drawing.Size(74, 23);
            this.sphereVolumeLabel.TabIndex = 13;
            // 
            // sphereSurfaceAreaLabel
            // 
            this.sphereSurfaceAreaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sphereSurfaceAreaLabel.Location = new System.Drawing.Point(355, 150);
            this.sphereSurfaceAreaLabel.Name = "sphereSurfaceAreaLabel";
            this.sphereSurfaceAreaLabel.Size = new System.Drawing.Size(82, 23);
            this.sphereSurfaceAreaLabel.TabIndex = 14;
            // 
            // tetraLabel
            // 
            this.tetraLabel.AutoSize = true;
            this.tetraLabel.Location = new System.Drawing.Point(64, 210);
            this.tetraLabel.Name = "tetraLabel";
            this.tetraLabel.Size = new System.Drawing.Size(32, 13);
            this.tetraLabel.TabIndex = 15;
            this.tetraLabel.Text = "Tetra";
            // 
            // tetraSizeTextBox
            // 
            this.tetraSizeTextBox.Location = new System.Drawing.Point(124, 202);
            this.tetraSizeTextBox.Name = "tetraSizeTextBox";
            this.tetraSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.tetraSizeTextBox.TabIndex = 16;
            // 
            // tetraVolumeLabel
            // 
            this.tetraVolumeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tetraVolumeLabel.Location = new System.Drawing.Point(247, 202);
            this.tetraVolumeLabel.Name = "tetraVolumeLabel";
            this.tetraVolumeLabel.Size = new System.Drawing.Size(74, 23);
            this.tetraVolumeLabel.TabIndex = 17;
            // 
            // tetraSurfaceAreaLabel
            // 
            this.tetraSurfaceAreaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tetraSurfaceAreaLabel.Location = new System.Drawing.Point(353, 202);
            this.tetraSurfaceAreaLabel.Name = "tetraSurfaceAreaLabel";
            this.tetraSurfaceAreaLabel.Size = new System.Drawing.Size(84, 23);
            this.tetraSurfaceAreaLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 318);
            this.Controls.Add(this.tetraSurfaceAreaLabel);
            this.Controls.Add(this.tetraVolumeLabel);
            this.Controls.Add(this.tetraSizeTextBox);
            this.Controls.Add(this.tetraLabel);
            this.Controls.Add(this.sphereSurfaceAreaLabel);
            this.Controls.Add(this.sphereVolumeLabel);
            this.Controls.Add(this.sphereSizeTextBox);
            this.Controls.Add(this.sphereLabel);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.enlargeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cubeSizeTextBox);
            this.Controls.Add(this.cubeVolumeLabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.surfaceAreaLabel);
            this.Controls.Add(this.cubeSurfaceAreaLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.cubeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cubeLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label cubeSurfaceAreaLabel;
        private System.Windows.Forms.Label surfaceAreaLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label cubeVolumeLabel;
        private System.Windows.Forms.TextBox cubeSizeTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button enlargeButton;
        private System.Windows.Forms.Button negativeButton;
        private System.Windows.Forms.Label sphereLabel;
        private System.Windows.Forms.TextBox sphereSizeTextBox;
        private System.Windows.Forms.Label sphereVolumeLabel;
        private System.Windows.Forms.Label sphereSurfaceAreaLabel;
        private System.Windows.Forms.Label tetraLabel;
        private System.Windows.Forms.TextBox tetraSizeTextBox;
        private System.Windows.Forms.Label tetraVolumeLabel;
        private System.Windows.Forms.Label tetraSurfaceAreaLabel;
    }
}

