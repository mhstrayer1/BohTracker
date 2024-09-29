namespace BohTracker
{
   partial class Form1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         menuStrip1 = new MenuStrip();
         fileToolStripMenuItem = new ToolStripMenuItem();
         newToolStripMenuItem = new ToolStripMenuItem();
         openToolStripMenuItem = new ToolStripMenuItem();
         toolStripSeparator = new ToolStripSeparator();
         saveToolStripMenuItem = new ToolStripMenuItem();
         saveAsToolStripMenuItem = new ToolStripMenuItem();
         toolStripSeparator1 = new ToolStripSeparator();
         toolStripSeparator2 = new ToolStripSeparator();
         exitToolStripMenuItem = new ToolStripMenuItem();
         menuStrip1.SuspendLayout();
         SuspendLayout();
         // 
         // menuStrip1
         // 
         menuStrip1.ImageScalingSize = new Size(24, 24);
         menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
         menuStrip1.Location = new Point(0, 0);
         menuStrip1.Name = "menuStrip1";
         menuStrip1.Size = new Size(1046, 33);
         menuStrip1.TabIndex = 0;
         menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, toolStripSeparator2, exitToolStripMenuItem });
         fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         fileToolStripMenuItem.Size = new Size(54, 29);
         fileToolStripMenuItem.Text = "&File";
         // 
         // newToolStripMenuItem
         // 
         newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
         newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
         newToolStripMenuItem.Name = "newToolStripMenuItem";
         newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
         newToolStripMenuItem.Size = new Size(270, 34);
         newToolStripMenuItem.Text = "&New";
         // 
         // openToolStripMenuItem
         // 
         openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
         openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
         openToolStripMenuItem.Name = "openToolStripMenuItem";
         openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
         openToolStripMenuItem.Size = new Size(270, 34);
         openToolStripMenuItem.Text = "&Open";
         // 
         // toolStripSeparator
         // 
         toolStripSeparator.Name = "toolStripSeparator";
         toolStripSeparator.Size = new Size(267, 6);
         // 
         // saveToolStripMenuItem
         // 
         saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
         saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
         saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
         saveToolStripMenuItem.Size = new Size(270, 34);
         saveToolStripMenuItem.Text = "&Save";
         // 
         // saveAsToolStripMenuItem
         // 
         saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
         saveAsToolStripMenuItem.Size = new Size(270, 34);
         saveAsToolStripMenuItem.Text = "Save &As";
         // 
         // toolStripSeparator1
         // 
         toolStripSeparator1.Name = "toolStripSeparator1";
         toolStripSeparator1.Size = new Size(267, 6);
         // 
         // toolStripSeparator2
         // 
         toolStripSeparator2.Name = "toolStripSeparator2";
         toolStripSeparator2.Size = new Size(267, 6);
         // 
         // exitToolStripMenuItem
         // 
         exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         exitToolStripMenuItem.Size = new Size(270, 34);
         exitToolStripMenuItem.Text = "E&xit";
         exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(10F, 25F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1046, 583);
         Controls.Add(menuStrip1);
         Name = "Form1";
         Text = "Form1";
         Load += Form1_Load;
         menuStrip1.ResumeLayout(false);
         menuStrip1.PerformLayout();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private MenuStrip menuStrip1;
      private ToolStripMenuItem fileToolStripMenuItem;
      private ToolStripMenuItem newToolStripMenuItem;
      private ToolStripMenuItem openToolStripMenuItem;
      private ToolStripSeparator toolStripSeparator;
      private ToolStripMenuItem saveToolStripMenuItem;
      private ToolStripMenuItem saveAsToolStripMenuItem;
      private ToolStripSeparator toolStripSeparator1;
      private ToolStripSeparator toolStripSeparator2;
      private ToolStripMenuItem exitToolStripMenuItem;
   }
}
