using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Debugger.Dicas
{
    public class InvocadorInfoPropertyChanged
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                OnPropertyChanged(); // Por meio do CallerMemberName
            }
        }

        private string matricula;
        public string Matricula
        {
            get { return matricula; }
            set
            {
                matricula = value;
                OnPropertyChanged("Matricula");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                var eventArgs = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, eventArgs);
            }
        }
    }
}
