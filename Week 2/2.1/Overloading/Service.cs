using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Overloadingdemo
{


    //为什么要用overload，是为了调用者可以选择只传入 serviceId，或者同时传入 serviceId 和 serviceName。
    internal class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public bool IsRunning { get; set; }
        public Service()
        {
            ServiceId = 200;
            ServiceName = string.Empty;
            IsRunning = false;
        }

        //overload constructor
        //There is no limit to how many constructors ,since you can invoke only one out of it
        //When you create the object, you invoke only one constructor out of it.
    

        public Service(int serviceId)
        {
            ServiceId = serviceId;
        }
        public void StartService (int serviceId)
        {
            //logic to start
            IsRunning = true;  //启用了第一个StartService 方法 , IsRunning 设置为 true。并将 IsRunning 设置为 true。

        }
        public void StartService (int serviceID, string serviceName)
        {
            IsRunning = true;//第二个 StartService 方法, 接受两个参数：int serviceID 和 string serviceName。并将 IsRunning 设置为 true。
        }
    }
}

