﻿namespace Onela
{
    partial class Form2
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
            this.button_cancelAddContacts = new System.Windows.Forms.Button();
            this.button_createContacts = new System.Windows.Forms.Button();
            this.label_newContact = new System.Windows.Forms.Label();
            this.textBox_firstnameNewContacts = new System.Windows.Forms.RichTextBox();
            this.pictureBox_newContacts = new System.Windows.Forms.PictureBox();
            this.button_addPhotoNewContacts = new System.Windows.Forms.Button();
            this.textBox_lastnameNewContacts = new System.Windows.Forms.RichTextBox();
            this.textBox_numberNewContacts = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_newContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancelAddContacts
            // 
            this.button_cancelAddContacts.Location = new System.Drawing.Point(12, 12);
            this.button_cancelAddContacts.Name = "button_cancelAddContacts";
            this.button_cancelAddContacts.Size = new System.Drawing.Size(52, 23);
            this.button_cancelAddContacts.TabIndex = 0;
            this.button_cancelAddContacts.Text = "Annuler";
            this.button_cancelAddContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_cancelAddContacts.UseVisualStyleBackColor = true;
            this.button_cancelAddContacts.Click += new System.EventHandler(this.button_cancelAddContacts_Click);
            // 
            // button_createContacts
            // 
            this.button_createContacts.Location = new System.Drawing.Point(230, 12);
            this.button_createContacts.Name = "button_createContacts";
            this.button_createContacts.Size = new System.Drawing.Size(41, 23);
            this.button_createContacts.TabIndex = 1;
            this.button_createContacts.Text = "Créer";
            this.button_createContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_createContacts.UseVisualStyleBackColor = true;
            // 
            // label_newContact
            // 
            this.label_newContact.AutoSize = true;
            this.label_newContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newContact.Location = new System.Drawing.Point(87, 17);
            this.label_newContact.Name = "label_newContact";
            this.label_newContact.Size = new System.Drawing.Size(120, 18);
            this.label_newContact.TabIndex = 2;
            this.label_newContact.Text = "Nouveau contact";
            // 
            // textBox_firstnameNewContacts
            // 
            this.textBox_firstnameNewContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_firstnameNewContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstnameNewContacts.Location = new System.Drawing.Point(12, 198);
            this.textBox_firstnameNewContacts.Name = "textBox_firstnameNewContacts";
            this.textBox_firstnameNewContacts.Size = new System.Drawing.Size(123, 24);
            this.textBox_firstnameNewContacts.TabIndex = 4;
            this.textBox_firstnameNewContacts.Text = "Prénom";
            // 
            // pictureBox_newContacts
            // 
            this.pictureBox_newContacts.Location = new System.Drawing.Point(90, 38);
            this.pictureBox_newContacts.Name = "pictureBox_newContacts";
            this.pictureBox_newContacts.Size = new System.Drawing.Size(117, 100);
            this.pictureBox_newContacts.TabIndex = 5;
            this.pictureBox_newContacts.TabStop = false;
            // 
            // button_addPhotoNewContacts
            // 
            this.button_addPhotoNewContacts.Location = new System.Drawing.Point(99, 144);
            this.button_addPhotoNewContacts.Name = "button_addPhotoNewContacts";
            this.button_addPhotoNewContacts.Size = new System.Drawing.Size(99, 23);
            this.button_addPhotoNewContacts.TabIndex = 6;
            this.button_addPhotoNewContacts.Text = "Ajouter une photo";
            this.button_addPhotoNewContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_addPhotoNewContacts.UseVisualStyleBackColor = true;
            // 
            // textBox_lastnameNewContacts
            // 
            this.textBox_lastnameNewContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_lastnameNewContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastnameNewContacts.Location = new System.Drawing.Point(12, 228);
            this.textBox_lastnameNewContacts.Name = "textBox_lastnameNewContacts";
            this.textBox_lastnameNewContacts.Size = new System.Drawing.Size(123, 24);
            this.textBox_lastnameNewContacts.TabIndex = 7;
            this.textBox_lastnameNewContacts.Text = "Nom";
            // 
            // textBox_numberNewContacts
            // 
            this.textBox_numberNewContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_numberNewContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_numberNewContacts.Location = new System.Drawing.Point(12, 258);
            this.textBox_numberNewContacts.Name = "textBox_numberNewContacts";
            this.textBox_numberNewContacts.Size = new System.Drawing.Size(123, 24);
            this.textBox_numberNewContacts.TabIndex = 8;
            this.textBox_numberNewContacts.Text = "Numéro ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 307);
            this.Controls.Add(this.textBox_numberNewContacts);
            this.Controls.Add(this.textBox_lastnameNewContacts);
            this.Controls.Add(this.button_addPhotoNewContacts);
            this.Controls.Add(this.pictureBox_newContacts);
            this.Controls.Add(this.textBox_firstnameNewContacts);
            this.Controls.Add(this.label_newContact);
            this.Controls.Add(this.button_createContacts);
            this.Controls.Add(this.button_cancelAddContacts);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_newContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancelAddContacts;
        private System.Windows.Forms.Button button_createContacts;
        private System.Windows.Forms.Label label_newContact;
        private System.Windows.Forms.RichTextBox textBox_firstnameNewContacts;
        private System.Windows.Forms.PictureBox pictureBox_newContacts;
        private System.Windows.Forms.Button button_addPhotoNewContacts;
        private System.Windows.Forms.RichTextBox textBox_lastnameNewContacts;
        private System.Windows.Forms.RichTextBox textBox_numberNewContacts;
    }
}