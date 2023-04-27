using UnityEngine;

namespace DesignPattern.Command
{
    public class PressKeyCommand : ICommand
    {
        private Client.MyData _myData;
        public PressKeyCommand(Client.MyData myData)
        {
            _myData = myData;
        }
        public void Excute()
        {
            _myData.txt.text = "PRESS KEY :" + KeyCode.J;
            _myData.img.color = Color.black;
        }

        public void Undo()
        {
            
        }
    }
}