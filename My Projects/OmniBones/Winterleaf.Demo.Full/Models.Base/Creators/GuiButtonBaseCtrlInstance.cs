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
   public class GuiButtonBaseCtrlInstance : GuiControlInstance
   {
      public GuiButtonBaseCtrlInstance(string _name = "", string _className = "GuiButtonBaseCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public TypeGuiButtonType buttonType
      {
         set { Fields["buttonType"] = value.ToString(); }
      }

      public TypeImageFilename changeTexture
      {
         set { Fields["changeTexture"] = value.ToString(); }
      }

      public int groupNum
      {
         set { Fields["groupNum"] = value.ToString(); }
      }

      public String text
      {
         set { Fields["text"] = value.ToString(); }
      }

      public String textID
      {
         set { Fields["textID"] = value.ToString(); }
      }

      public bool useMouseEvents
      {
         set { Fields["useMouseEvents"] = value.ToString(); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiButtonBaseCtrl(GuiButtonBaseCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiButtonBaseCtrl ret = new GuiButtonBaseCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiButtonBaseCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
