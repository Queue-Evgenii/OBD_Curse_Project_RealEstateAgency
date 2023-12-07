
namespace RealEstateAgency
{
    partial class FormTemp
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
            this.publicationsListLayout = new System.Windows.Forms.TableLayoutPanel();
            this.publicationsListWrapper = new System.Windows.Forms.Panel();
            this.publicationsListWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // publicationsListLayout
            // 
            this.publicationsListLayout.AutoSize = true;
            this.publicationsListLayout.ColumnCount = 3;
            this.publicationsListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.06475F));
            this.publicationsListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.20144F));
            this.publicationsListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.73381F));
            this.publicationsListLayout.Location = new System.Drawing.Point(3, 3);
            this.publicationsListLayout.Name = "publicationsListLayout";
            this.publicationsListLayout.RowCount = 5;
            this.publicationsListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.publicationsListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.publicationsListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.publicationsListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.publicationsListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.publicationsListLayout.Size = new System.Drawing.Size(358, 500);
            this.publicationsListLayout.TabIndex = 5;
            // 
            // publicationsListWrapper
            // 
            this.publicationsListWrapper.AutoSize = true;
            this.publicationsListWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.publicationsListWrapper.Controls.Add(this.publicationsListLayout);
            this.publicationsListWrapper.Location = new System.Drawing.Point(342, 13);
            this.publicationsListWrapper.Name = "publicationsListWrapper";
            this.publicationsListWrapper.Size = new System.Drawing.Size(364, 506);
            this.publicationsListWrapper.TabIndex = 8;
            // 
            // FormTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.publicationsListWrapper);
            this.Name = "FormTemp";
            this.Text = "FormTemp";
            this.publicationsListWrapper.ResumeLayout(false);
            this.publicationsListWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel publicationsListLayout;
        private System.Windows.Forms.Panel publicationsListWrapper;
    }
}