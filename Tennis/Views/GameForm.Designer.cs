// GameForm.Designer.cs
using System.Windows.Forms;

namespace Tennis.Views
{
    partial class GameForm
    {
        /// <summary>
        /// Nécessaire pour le concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libère les ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur

        /// <summary>
        /// Requiert une méthode de conception - ne peut être modifiée
        /// à l'aide de l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GameForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 800); // Définissez la taille souhaitée pour le formulaire
            this.Name = "GameForm";
            this.Text = "Tennis Game"; // Titre du formulaire
            this.ResumeLayout(false);
        }

        #endregion
    }
}
