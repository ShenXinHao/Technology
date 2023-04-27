using System.Collections.Generic;

namespace DesignPattern.Command
{
    public interface ICommand
    {
        void Excute();
        void Undo();
       
    }
}