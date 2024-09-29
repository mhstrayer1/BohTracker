namespace BohTracker
{
   partial class mainForm
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
         mainMenuStrip = new MenuStrip();
         fileToolStripMenuItem = new ToolStripMenuItem();
         toolStripSeparator1 = new ToolStripSeparator();
         toolStripSeparator2 = new ToolStripSeparator();
         newToolStripMenuItem = new ToolStripMenuItem();
         openToolStripMenuItem = new ToolStripMenuItem();
         toolStripSeparator3 = new ToolStripSeparator();
         saveToolStripMenuItem = new ToolStripMenuItem();
         saveAsToolStripMenuItem = new ToolStripMenuItem();
         toolStripSeparator4 = new ToolStripSeparator();
         exitToolStripMenuItem = new ToolStripMenuItem();
         mainMenuStrip.SuspendLayout();
         SuspendLayout();
         // 
         // mainMenuStrip
         // 
         mainMenuStrip.ImageScalingSize = new Size(24, 24);
         mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
         mainMenuStrip.Location = new Point(0, 0);
         mainMenuStrip.Name = "mainMenuStrip";
         mainMenuStrip.Size = new Size(1647, 33);
         mainMenuStrip.TabIndex = 0;
         mainMenuStrip.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripSeparator2, newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator3, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator4, exitToolStripMenuItem });
         fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         fileToolStripMenuItem.Size = new Size(54, 29);
         fileToolStripMenuItem.Text = "File";
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
         // newToolStripMenuItem
         // 
         newToolStripMenuItem.Name = "newToolStripMenuItem";
         newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
         newToolStripMenuItem.Size = new Size(270, 34);
         newToolStripMenuItem.Text = "&New";
         newToolStripMenuItem.Click += newToolStripMenuItem_Click;
         // 
         // openToolStripMenuItem
         // 
         openToolStripMenuItem.Name = "openToolStripMenuItem";
         openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
         openToolStripMenuItem.Size = new Size(270, 34);
         openToolStripMenuItem.Text = "&Open...";
         openToolStripMenuItem.Click += openToolStripMenuItem_Click;
         // 
         // toolStripSeparator3
         // 
         toolStripSeparator3.Name = "toolStripSeparator3";
         toolStripSeparator3.Size = new Size(267, 6);
         // 
         // saveToolStripMenuItem
         // 
         saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
         saveToolStripMenuItem.Size = new Size(270, 34);
         saveToolStripMenuItem.Text = "&Save";
         saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
         // 
         // saveAsToolStripMenuItem
         // 
         saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
         saveAsToolStripMenuItem.Size = new Size(270, 34);
         saveAsToolStripMenuItem.Text = "Save as...";
         saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
         // 
         // toolStripSeparator4
         // 
         toolStripSeparator4.Name = "toolStripSeparator4";
         toolStripSeparator4.Size = new Size(267, 6);
         // 
         // exitToolStripMenuItem
         // 
         exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
         exitToolStripMenuItem.Size = new Size(270, 34);
         exitToolStripMenuItem.Text = "E&xit";
         exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
         // 
         // mainForm
         // 
         AutoScaleDimensions = new SizeF(10F, 25F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1647, 919);
         Controls.Add(mainMenuStrip);
         MainMenuStrip = mainMenuStrip;
         Name = "mainForm";
         Text = "BOH Tracker";
         Load += mainForm_Load;
         mainMenuStrip.ResumeLayout(false);
         mainMenuStrip.PerformLayout();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private MenuStrip mainMenuStrip;
      private ToolStripMenuItem fileToolStripMenuItem;
      private ToolStripSeparator toolStripSeparator1;
      private ToolStripSeparator toolStripSeparator2;
      private ToolStripMenuItem newToolStripMenuItem;
      private ToolStripMenuItem openToolStripMenuItem;
      private ToolStripSeparator toolStripSeparator3;
      private ToolStripMenuItem saveToolStripMenuItem;
      private ToolStripMenuItem saveAsToolStripMenuItem;
      private ToolStripSeparator toolStripSeparator4;
      private ToolStripMenuItem exitToolStripMenuItem;
   }
}
