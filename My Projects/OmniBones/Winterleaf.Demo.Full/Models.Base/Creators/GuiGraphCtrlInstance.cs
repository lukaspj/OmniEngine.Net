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
   public class GuiGraphCtrlInstance : GuiControlInstance
   {
      public GuiGraphCtrlInstance(string _name = "", string _className = "GuiGraphCtrl", ObjectType pObjectType = ObjectType.Instance)
         : base(_name, _className, pObjectType)
      {
      }


      public float centerY
      {
         set { Fields["centerY"] = value.ToString(); }
      }

      private FieldWrapper<ColorF> _plotColor = new FieldWrapper<ColorF>();
      public FieldWrapper<ColorF> plotColor
      {
         get { _plotColor.Set(ref mFieldsDictionary, "plotColor"); return _plotColor; }
         set { _plotColor.Set(ref mFieldsDictionary, "plotColor"); }
      }

      private FieldWrapper<int> _plotInterval = new FieldWrapper<int>();
      public FieldWrapper<int> plotInterval
      {
         get { _plotInterval.Set(ref mFieldsDictionary, "plotInterval"); return _plotInterval; }
         set { _plotInterval.Set(ref mFieldsDictionary, "plotInterval"); }
      }

      private FieldWrapper<int> _plotType = new FieldWrapper<int>();
      public FieldWrapper<int> plotType
      {
         get { _plotType.Set(ref mFieldsDictionary, "plotType"); return _plotType; }
         set { _plotType.Set(ref mFieldsDictionary, "plotType"); }
      }

      private FieldWrapper<String> _plotVariable = new FieldWrapper<String>();
      public FieldWrapper<String> plotVariable
      {
         get { _plotVariable.Set(ref mFieldsDictionary, "plotVariable"); return _plotVariable; }
         set { _plotVariable.Set(ref mFieldsDictionary, "plotVariable"); }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator GuiGraphCtrl(GuiGraphCtrlInstance inst)
      {
         UInt32 r;
         string id = Omni.self.Evaluate("return " + inst.ToString(), true);
         if(!UInt32.TryParse(id, out r))
            return null;
         GuiGraphCtrl ret = new GuiGraphCtrl();
         ret.SetUpObject(r);
         return ret;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inst"></param>
      /// <returns></returns>
      public static implicit operator string(GuiGraphCtrlInstance inst)
      {
         return Omni.self.Evaluate("return " + inst.ToString(), true);
      }
   }
}
