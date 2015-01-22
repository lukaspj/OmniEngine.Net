using System;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.Base.Creators
{
   /// <summary>
   /// 
   /// </summary>
   public class SimComponentInstance : NetObjectInstance
   {
      public SimComponentInstance(string _name = "", string _className = "SimComponent", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public bool Template
      {
         set { Fields["Template"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator SimComponent(SimComponentInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         SimComponent ret = new SimComponent();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(SimComponentInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
