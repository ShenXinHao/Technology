using System;
using System.Collections.Generic;
using Common;
using DesignPattern.Iterator;
using DesignPattern.Iterator.Interface;
using UnityEngine;

namespace DesignPattern.Command
{
    public class GameManager : MonoSingleton<GameManager>
    {       
    
        private Queue<ICommand> _commands = new Queue<ICommand>();
        //private Box _box;
        private void Start()
        {
            var aggregate = new Aggregate();
            aggregate.AddData(new SpecialData(1,"第一个数据"));
            aggregate.AddData(new SpecialData(2,"第二个数据"));
            aggregate.AddData(new SpecialData(3,"第三个数据"));
            foreach (SpecialData data  in aggregate)
            {
                Debug.LogFormat("data..id = {0}.. name = {1}",data.id, data.name);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                ICommand jump = new JumpCommand();
                _commands.Enqueue(jump);
                jump.Excute();
                
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                var jump = _commands.Dequeue();
                jump.Undo();
            }
        }
    }
}