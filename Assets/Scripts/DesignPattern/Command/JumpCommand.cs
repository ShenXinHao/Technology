using UnityEngine;

namespace DesignPattern.Command
{
    public class JumpCommand : ICommand
    {
        private Box box;

        public JumpCommand()
        {
            this.box = GameObject.FindGameObjectWithTag("Player").GetComponent<Box>();
        }
        public void Excute()
        {
            box.Jump(1);
        }

        public void Undo()
        {
            box.Jump(-1);
        }
    }
}