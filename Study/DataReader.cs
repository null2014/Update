using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class DataReader
    {
        //可空数据字段
        public int? numberValue = null;
        public bool? boolValue = null;
        //可空返回类型
        public int? GetFromData()
        {
            return numberValue;
        }
        public bool? GetBoolData()
        {
            return boolValue;
        }
    }

    class Motocycle
    {
        public int driverIntensity;
        public string driverName;
        public void SetDriverName(string name)
        {
            this.driverName= name;//如果这个driverName 改为name，没有加this，调用的时候，输出name为空字符串
        }
    }
}
