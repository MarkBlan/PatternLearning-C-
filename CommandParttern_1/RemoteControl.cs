using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParttern_1
{
    public class RemoteControl
    {

        Command[] onCommand_;

        Command[] offCommand_;


        Command undoCommand_;
        public RemoteControl()
        {
            onCommand_ = new Command[7];
            offCommand_ = new Command[7];

            Command noCommand=new NoCommand();

            for(int i=0;i<7;i++)
            {
                onCommand_[i] = noCommand;
                offCommand_[i] = noCommand;
            }

            undoCommand_ = noCommand;
        }

        public void SetCommand(int slot,Command onCommand,Command offCommand)
        {
            onCommand_[slot] = onCommand;
            offCommand_[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            onCommand_[slot].Execute();
            undoCommand_ = onCommand_[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            offCommand_[slot].Execute();
            undoCommand_ = onCommand_[slot];
        }

        public void OnUndoButtonWasPressed()
        {
            undoCommand_.UnDo();
        }
        public String toString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n=====Remote Control====\n");

            for(int i=0;i<onCommand_.Length;i++)
            {
                stringBuff.Append("[slot" + i + "]" + onCommand_[i].ToString() + "   " + offCommand_[i].ToString() + "\n");
            }

            return stringBuff.ToString();
        }
    }
}
