using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Builder
{
    public class Computer
    {
        public void Build(string keyboard, string monitor, string mouse, string cpu)
        {
            var keyBoardBuilder = new KeyBoardBuilder(new KeyBoard(keyboard));
            var monitorBuilder  = new MonitorBuilder(new Monitor(monitor));
            var mouseBuilder  = new MouseBuilder(new Mouse(mouse));
            var cpuBuilder  = new CPUBuilder(new CPU(cpu));
            keyBoardBuilder.Build("KeyBoard");
            monitorBuilder.Build("Monitor");
            mouseBuilder.Build("Mouse");
            cpuBuilder.Build("CPU");
            Console.WriteLine("PC assembled");
        }
    }
}
