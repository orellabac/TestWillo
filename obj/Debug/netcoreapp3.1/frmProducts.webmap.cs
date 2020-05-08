#pragma warning disable
#line 1 "frmProducts.cs"
#pragma warning disable
#line 1 "frmProducts.cs"
using System;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmProducts
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[33];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_NewMode)>0)
{yield return "NewMode";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_EditMode)>0)
{yield return "EditMode";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_CancellingMode)>0)
{yield return "CancellingMode";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_CurrentProductID)>0)
{yield return "CurrentProductID";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0)
{yield return "visualControls";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0)
{yield return "components";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0)
{yield return "ToolTipMain";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_6)>0)
{yield return "_txtField_6";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_0)>0)
{yield return "_txtField_0";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_5)>0)
{yield return "_txtField_5";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmbCategory)>0)
{yield return "cmbCategory";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_4)>0)
{yield return "_txtField_4";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_3)>0)
{yield return "_txtField_3";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_2)>0)
{yield return "_txtField_2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_1)>0)
{yield return "_txtField_1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Check1)>0)
{yield return "Check1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtCategory)>0)
{yield return "txtCategory";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label7)>0)
{yield return "Label7";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label3)>0)
{yield return "Label3";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label2)>0)
{yield return "Label2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label1)>0)
{yield return "Label1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0)
{yield return "Label4";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label5)>0)
{yield return "Label5";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label6)>0)
{yield return "Label6";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label11)>0)
{yield return "Label11";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label15)>0)
{yield return "Label15";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Frame1)>0)
{yield return "Frame1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_dcProducts)>0)
{yield return "dcProducts";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ImageList1)>0)
{yield return "ImageList1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Toolbar1_Buttons_Button1)>0)
{yield return "Toolbar1_Buttons_Button1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Toolbar1_Buttons_Button2)>0)
{yield return "Toolbar1_Buttons_Button2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Toolbar1_Buttons_Button3)>0)
{yield return "Toolbar1_Buttons_Button3";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button4)>0)
{yield return "Toolbar1_Buttons_Button4";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button5)>0)
{yield return "Toolbar1_Buttons_Button5";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button6)>0)
{yield return "Toolbar1_Buttons_Button6";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1)>0)
{yield return "Toolbar1";
}
if((_Mobilize_DirtyFlag_1&_Mobilize_Dirty_txtField)>0)
{yield return "txtField";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "NewMode":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_NewMode)>0;
case "EditMode":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_EditMode)>0;
case "CancellingMode":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_CancellingMode)>0;
case "CurrentProductID":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_CurrentProductID)>0;
case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "_txtField_6":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_6)>0;
case "_txtField_0":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_0)>0;
case "_txtField_5":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_5)>0;
case "cmbCategory":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmbCategory)>0;
case "_txtField_4":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_4)>0;
case "_txtField_3":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_3)>0;
case "_txtField_2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_2)>0;
case "_txtField_1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__txtField_1)>0;
case "Check1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Check1)>0;
case "txtCategory":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtCategory)>0;
case "Label7":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label7)>0;
case "Label3":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label3)>0;
case "Label2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label2)>0;
case "Label1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label1)>0;
case "Label4":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0;
case "Label5":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label5)>0;
case "Label6":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label6)>0;
case "Label11":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label11)>0;
case "Label15":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label15)>0;
case "Frame1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Frame1)>0;
case "dcProducts":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_dcProducts)>0;
case "ImageList1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ImageList1)>0;
case "Toolbar1_Buttons_Button1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Toolbar1_Buttons_Button1)>0;
case "Toolbar1_Buttons_Button2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Toolbar1_Buttons_Button2)>0;
case "Toolbar1_Buttons_Button3":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Toolbar1_Buttons_Button3)>0;
case "Toolbar1_Buttons_Button4":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button4)>0;
case "Toolbar1_Buttons_Button5":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button5)>0;
case "Toolbar1_Buttons_Button6":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1_Buttons_Button6)>0;
case "Toolbar1":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_Toolbar1)>0;
case "txtField":return (_Mobilize_DirtyFlag_1&_Mobilize_Dirty_txtField)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["_txtField_6"]=_Mobilize_References[3];
refs["_txtField_0"]=_Mobilize_References[4];
refs["_txtField_5"]=_Mobilize_References[5];
refs["cmbCategory"]=_Mobilize_References[6];
refs["_txtField_4"]=_Mobilize_References[7];
refs["_txtField_3"]=_Mobilize_References[8];
refs["_txtField_2"]=_Mobilize_References[9];
refs["_txtField_1"]=_Mobilize_References[10];
refs["Check1"]=_Mobilize_References[11];
refs["txtCategory"]=_Mobilize_References[12];
refs["Label7"]=_Mobilize_References[13];
refs["Label3"]=_Mobilize_References[14];
refs["Label2"]=_Mobilize_References[15];
refs["Label1"]=_Mobilize_References[16];
refs["Label4"]=_Mobilize_References[17];
refs["Label5"]=_Mobilize_References[18];
refs["Label6"]=_Mobilize_References[19];
refs["Label11"]=_Mobilize_References[20];
refs["Label15"]=_Mobilize_References[21];
refs["Frame1"]=_Mobilize_References[22];
refs["dcProducts"]=_Mobilize_References[23];
refs["ImageList1"]=_Mobilize_References[24];
refs["Toolbar1_Buttons_Button1"]=_Mobilize_References[25];
refs["Toolbar1_Buttons_Button2"]=_Mobilize_References[26];
refs["Toolbar1_Buttons_Button3"]=_Mobilize_References[27];
refs["Toolbar1_Buttons_Button4"]=_Mobilize_References[28];
refs["Toolbar1_Buttons_Button5"]=_Mobilize_References[29];
refs["Toolbar1_Buttons_Button6"]=_Mobilize_References[30];
refs["Toolbar1"]=_Mobilize_References[31];
refs["txtField"]=_Mobilize_References[32];
return refs;
}
protected override void _Mobilize_CleanChanges()
{if(!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew||((Mobilize.WebMap.Common.Core.IObservable)this).RefCount>0)
{this._Mobilize_DirtyFlag_0=0;
this._Mobilize_DirtyFlag_1=0;
this._Mobilize_LoadedFlag_0=0;
this._Mobilize_LoadedFlag_1=0;
this._Mobilize_ControlFlag=0;
}
base._Mobilize_CleanChanges();}
protected override System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
{foreach ( var baseRef in base._Mobilize_GetReferences()) {yield return baseRef;
}var ref_visualControls=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.visualControls);if(ref_visualControls!=null)yield return ref_visualControls;
var ref_components=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.components);if(ref_components!=null)yield return ref_components;
var ref_ToolTipMain=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.ToolTipMain);if(ref_ToolTipMain!=null)yield return ref_ToolTipMain;
var ref__txtField_6=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_6;if(ref__txtField_6!=null)yield return ref__txtField_6;
var ref__txtField_0=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_0;if(ref__txtField_0!=null)yield return ref__txtField_0;
var ref__txtField_5=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_5;if(ref__txtField_5!=null)yield return ref__txtField_5;
var ref_cmbCategory=(Mobilize.WebMap.Common.Core.IObservable)this.cmbCategory;if(ref_cmbCategory!=null)yield return ref_cmbCategory;
var ref__txtField_4=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_4;if(ref__txtField_4!=null)yield return ref__txtField_4;
var ref__txtField_3=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_3;if(ref__txtField_3!=null)yield return ref__txtField_3;
var ref__txtField_2=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_2;if(ref__txtField_2!=null)yield return ref__txtField_2;
var ref__txtField_1=(Mobilize.WebMap.Common.Core.IObservable)this._txtField_1;if(ref__txtField_1!=null)yield return ref__txtField_1;
var ref_Check1=(Mobilize.WebMap.Common.Core.IObservable)this.Check1;if(ref_Check1!=null)yield return ref_Check1;
var ref_txtCategory=(Mobilize.WebMap.Common.Core.IObservable)this.txtCategory;if(ref_txtCategory!=null)yield return ref_txtCategory;
var ref_Label7=(Mobilize.WebMap.Common.Core.IObservable)this.Label7;if(ref_Label7!=null)yield return ref_Label7;
var ref_Label3=(Mobilize.WebMap.Common.Core.IObservable)this.Label3;if(ref_Label3!=null)yield return ref_Label3;
var ref_Label2=(Mobilize.WebMap.Common.Core.IObservable)this.Label2;if(ref_Label2!=null)yield return ref_Label2;
var ref_Label1=(Mobilize.WebMap.Common.Core.IObservable)this.Label1;if(ref_Label1!=null)yield return ref_Label1;
var ref_Label4=(Mobilize.WebMap.Common.Core.IObservable)this.Label4;if(ref_Label4!=null)yield return ref_Label4;
var ref_Label5=(Mobilize.WebMap.Common.Core.IObservable)this.Label5;if(ref_Label5!=null)yield return ref_Label5;
var ref_Label6=(Mobilize.WebMap.Common.Core.IObservable)this.Label6;if(ref_Label6!=null)yield return ref_Label6;
var ref_Label11=(Mobilize.WebMap.Common.Core.IObservable)this.Label11;if(ref_Label11!=null)yield return ref_Label11;
var ref_Label15=(Mobilize.WebMap.Common.Core.IObservable)this.Label15;if(ref_Label15!=null)yield return ref_Label15;
var ref_Frame1=(Mobilize.WebMap.Common.Core.IObservable)this.Frame1;if(ref_Frame1!=null)yield return ref_Frame1;
var ref_dcProducts=(Mobilize.WebMap.Common.Core.IObservable)this.dcProducts;if(ref_dcProducts!=null)yield return ref_dcProducts;
var ref_ImageList1=(Mobilize.WebMap.Common.Core.IObservable)this.ImageList1;if(ref_ImageList1!=null)yield return ref_ImageList1;
var ref_Toolbar1_Buttons_Button1=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button1;if(ref_Toolbar1_Buttons_Button1!=null)yield return ref_Toolbar1_Buttons_Button1;
var ref_Toolbar1_Buttons_Button2=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button2;if(ref_Toolbar1_Buttons_Button2!=null)yield return ref_Toolbar1_Buttons_Button2;
var ref_Toolbar1_Buttons_Button3=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button3;if(ref_Toolbar1_Buttons_Button3!=null)yield return ref_Toolbar1_Buttons_Button3;
var ref_Toolbar1_Buttons_Button4=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button4;if(ref_Toolbar1_Buttons_Button4!=null)yield return ref_Toolbar1_Buttons_Button4;
var ref_Toolbar1_Buttons_Button5=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button5;if(ref_Toolbar1_Buttons_Button5!=null)yield return ref_Toolbar1_Buttons_Button5;
var ref_Toolbar1_Buttons_Button6=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1_Buttons_Button6;if(ref_Toolbar1_Buttons_Button6!=null)yield return ref_Toolbar1_Buttons_Button6;
var ref_Toolbar1=(Mobilize.WebMap.Common.Core.IObservable)this.Toolbar1;if(ref_Toolbar1!=null)yield return ref_Toolbar1;
var ref_txtField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.txtField);if(ref_txtField!=null)yield return ref_txtField;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_DirtyFlag_1;
private uint _Mobilize_LoadedFlag_0;
private uint _Mobilize_LoadedFlag_1;
const uint _Mobilize_Dirty_NewMode=(uint)1<<0;
const uint _Mobilize_Dirty_EditMode=(uint)1<<1;
const uint _Mobilize_Dirty_CancellingMode=(uint)1<<2;
const uint _Mobilize_Dirty_CurrentProductID=(uint)1<<3;
const uint _Mobilize_Dirty_visualControls=(uint)1<<4;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<5;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<6;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty__txtField_6=(uint)1<<7;
const uint _Mobilize_Loaded__txtField_6=(uint)1<<3;
const uint _Mobilize_Dirty__txtField_0=(uint)1<<8;
const uint _Mobilize_Loaded__txtField_0=(uint)1<<4;
const uint _Mobilize_Dirty__txtField_5=(uint)1<<9;
const uint _Mobilize_Loaded__txtField_5=(uint)1<<5;
const uint _Mobilize_Dirty_cmbCategory=(uint)1<<10;
const uint _Mobilize_Loaded_cmbCategory=(uint)1<<6;
const uint _Mobilize_Dirty__txtField_4=(uint)1<<11;
const uint _Mobilize_Loaded__txtField_4=(uint)1<<7;
const uint _Mobilize_Dirty__txtField_3=(uint)1<<12;
const uint _Mobilize_Loaded__txtField_3=(uint)1<<8;
const uint _Mobilize_Dirty__txtField_2=(uint)1<<13;
const uint _Mobilize_Loaded__txtField_2=(uint)1<<9;
const uint _Mobilize_Dirty__txtField_1=(uint)1<<14;
const uint _Mobilize_Loaded__txtField_1=(uint)1<<10;
const uint _Mobilize_Dirty_Check1=(uint)1<<15;
const uint _Mobilize_Loaded_Check1=(uint)1<<11;
const uint _Mobilize_Dirty_txtCategory=(uint)1<<16;
const uint _Mobilize_Loaded_txtCategory=(uint)1<<12;
const uint _Mobilize_Dirty_Label7=(uint)1<<17;
const uint _Mobilize_Loaded_Label7=(uint)1<<13;
const uint _Mobilize_Dirty_Label3=(uint)1<<18;
const uint _Mobilize_Loaded_Label3=(uint)1<<14;
const uint _Mobilize_Dirty_Label2=(uint)1<<19;
const uint _Mobilize_Loaded_Label2=(uint)1<<15;
const uint _Mobilize_Dirty_Label1=(uint)1<<20;
const uint _Mobilize_Loaded_Label1=(uint)1<<16;
const uint _Mobilize_Dirty_Label4=(uint)1<<21;
const uint _Mobilize_Loaded_Label4=(uint)1<<17;
const uint _Mobilize_Dirty_Label5=(uint)1<<22;
const uint _Mobilize_Loaded_Label5=(uint)1<<18;
const uint _Mobilize_Dirty_Label6=(uint)1<<23;
const uint _Mobilize_Loaded_Label6=(uint)1<<19;
const uint _Mobilize_Dirty_Label11=(uint)1<<24;
const uint _Mobilize_Loaded_Label11=(uint)1<<20;
const uint _Mobilize_Dirty_Label15=(uint)1<<25;
const uint _Mobilize_Loaded_Label15=(uint)1<<21;
const uint _Mobilize_Dirty_Frame1=(uint)1<<26;
const uint _Mobilize_Loaded_Frame1=(uint)1<<22;
const uint _Mobilize_Dirty_dcProducts=(uint)1<<27;
const uint _Mobilize_Loaded_dcProducts=(uint)1<<23;
const uint _Mobilize_Dirty_ImageList1=(uint)1<<28;
const uint _Mobilize_Loaded_ImageList1=(uint)1<<24;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button1=(uint)1<<29;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button1=(uint)1<<25;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button2=(uint)1<<30;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button2=(uint)1<<26;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button3=(uint)1<<31;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button3=(uint)1<<27;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button4=(uint)1<<32;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button4=(uint)1<<28;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button5=(uint)1<<33;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button5=(uint)1<<29;
const uint _Mobilize_Dirty_Toolbar1_Buttons_Button6=(uint)1<<34;
const uint _Mobilize_Loaded_Toolbar1_Buttons_Button6=(uint)1<<30;
const uint _Mobilize_Dirty_Toolbar1=(uint)1<<35;
const uint _Mobilize_Loaded_Toolbar1=(uint)1<<31;
const uint _Mobilize_Dirty_txtField=(uint)1<<36;
const uint _Mobilize_Loaded_txtField=(uint)1<<32;
private void Mobilize_Initialize_Properties()
{
#line 17
                                         this.NewMode=false;
#line hidden
 
#line 20
                                          this.EditMode=false;
#line hidden
 
#line 23
                                                this.CancellingMode=false;
#line hidden
 
#line 26
                                                   this.CurrentProductID="";
#line hidden
 
#line 48
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "_txtField_6", "_txtField_0", "_txtField_5", "cmbCategory", "_txtField_4", "_txtField_3", "_txtField_2", "_txtField_1", "Check1", "txtCategory", "Label7", "Label3", "Label2", "Label1", "Label4", "Label5", "Label6", "Label11", "Label15", "Frame1", "dcProducts", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField"};
#line hidden
 
#line 146
                                                           this.txtField=new Mobilize.Web.TextBox[7];
#line hidden
 }
#line 13
    

#line hidden
                                         
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool NewMode_k__BackingField;
#line 17
                                         

      [Intercepted]

      private bool NewMode 
#line 17
                           { 
#line 17
                             get                                
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.NewMode_k__BackingField;} 
#line 17

#line 17
                                  set                                     
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_NewMode;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.NewMode_k__BackingField=(bool)value;} 
#line 17
                                       } 
#line 18

#line hidden
                                          
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool EditMode_k__BackingField;
#line 20
                                          

      [Intercepted]
      private bool EditMode 
#line 20
                            { 
#line 20
                              get                                 
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.EditMode_k__BackingField;} 
#line 20

#line 20
                                   set                                      
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_EditMode;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.EditMode_k__BackingField=(bool)value;} 
#line 20
                                        } 
#line 21

#line hidden
                                                
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool CancellingMode_k__BackingField;
#line 23
                                                

      [Intercepted]
      private bool CancellingMode 
#line 23
                                  { 
#line 23
                                    get                                       
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.CancellingMode_k__BackingField;} 
#line 23

#line 23
                                         set                                            
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CancellingMode;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CancellingMode_k__BackingField=(bool)value;} 
#line 23
                                              } 
#line 24

#line hidden
                                                   
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string CurrentProductID_k__BackingField;
#line 26
                                                   

      [Intercepted]
      public string CurrentProductID 
#line 26
                                     { 
#line 26
                                       get                                          
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.CurrentProductID_k__BackingField;} 
#line 26

#line 26
                                            set                                               
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CurrentProductID;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CurrentProductID_k__BackingField=(string)value;} 
#line 26
                                                 } 
#line 27


      public frmProducts()
      	: base()
      {

#line hidden
this.Mobilize_Initialize_Properties();
#line 31
      	if (m_vb6FormDefInstance == null)
         {
         	if (m_InitializingDefInstance)
         	{
         		m_vb6FormDefInstance = this;
         	}
         	else
         	{
         		try
         		{
         			//For the start-up form, the first instance created is the default instance.
         			if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint != null && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
                  {
                  	m_vb6FormDefInstance = this;
                  }
               }
               catch
               {
               }
            }
         }
         //This call is required by the Windows Form Designer.
         InitializeComponent();
         ReLoadForm(false);
      }


      //SKS Demo TODO: Go the the designer and change the data binding of _txtField_4 like this:
      //_txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2");


      private void cmbCategory_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
      {
      	if (cmbCategory.Items.Count == 0 || cmbCategory.SelectedIndex == -1)
         {
         	return;
         }
         txtCategory.Text = cmbCategory.GetItemData(cmbCategory.SelectedIndex).ToString();
      }


      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      	CurrentProductID = Convert.ToString(dcProducts.Recordset["ProductId"]);
      }

      private void txtCategory_TextChanged(Object eventSender, EventArgs eventArgs)
      {
      	if (cmbCategory.Items.Count == 0)
         {
         	modFunctions.LoadCombo("Categories", cmbCategory, "CategoryName", "CategoryID");
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (String.IsNullOrEmpty(txtCategory.Text))
         {
         	cmbCategory.SelectedIndex = -1;
         	return;
         }
         int Index = -1;
         int tempForEndVar = cmbCategory.Items.Count;
         for (modMain.i = 0; modMain.i <= tempForEndVar; modMain.i++)
         {
         	if (cmbCategory.GetItemData(modMain.i) == StringsHelper.ToDoubleSafe(txtCategory.Text))
            {
            	Index = modMain.i;
            	break;
            }
         }
         cmbCategory.SelectedIndex = modMain.i;
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080

      private void Form_Load()
      {
      	txtCategory.Height = 0;
      	txtCategory.Width = 0;
      	dcProducts.ConnectionString = modMain.ConnectionString;
      	NewMode = false;
      	EditMode = false;
      	CancellingMode = false;
      	if (cmbCategory.Items.Count == 0)
         {
         	modFunctions.LoadCombo("Categories", cmbCategory, "CategoryName", "CategoryID");
         }
      }

      private void Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
      {
         Mobilize.Web.ToolStripItem Button = (Mobilize.Web.ToolStripItem) eventSender;
         object x = null;
         //SKS Demo TODO: dcProducts.SetFocus()
         switch(Button.Text)
         {
         	case "Add" :
         		//Add new record 
         		NewMode = true;
         		dcProducts.Recordset.AddNew();
         		dcProducts.Recordset["UnitsInStock"] = 0;
         		dcProducts.Recordset["UnitsOnOrder"] = 0;
         		dcProducts.Recordset["Discontinued"] = 0;
         		break;
         	case "Edit" :
         		//Edit mode 
         		EditMode = true;
         		//dcProducts.Recordset.EditMode = 
         		break;
         	case "Save" :
         		//Save data 
         		dcProducts.Recordset.Update();
         		dcProducts.Recordset.Requery();  // SQLite ODBC driver needs to requery the info 
         		EditMode = false;
         		NewMode = false;
         		break;
         	case "Delete" :
         		//Delete record 
         		if ( Mobilize.Web.MessageBox.Show("Are you sure you want to delete this record?", "Delete record", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) == Mobilize.Web.DialogResult.Yes)
               {
               	dcProducts.Recordset.Delete();
               	dcProducts.Recordset.Requery();
               }
               break;
            case "Search" :
               //Search for records 
               modFunctions.SearchShow("Products", "ProductName", "product");
               break;
            case "Cancel" :
               CancellingMode = true;
               //Cancel edited changes 
               EditMode = false;
               NewMode = false;
               dcProducts.Recordset.CancelUpdate();
               dcProducts.Recordset.Requery();
               CancellingMode = false;
               this.Close();
               break;
         }
      }
public class _Mobilize_SharedState :Mobilize.WebMap.Common.Core.IObservable,Mobilize.WebMap.Common.Core.IDelta{
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[1];
Mobilize.WebMap.Common.Core.Identifier Mobilize.WebMap.Common.Core.IObservable.MobilizeId{get ;set ;}=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.IdentifierService.GetIdentifier();
Mobilize.WebMap.Common.Core.ReferenceMap Mobilize.WebMap.Common.Core.IObservable.References{
get=>this._Mobilize_GetReferenceMap(new Mobilize.WebMap.Common.Core.ReferenceMap());
set=>throw new System.NotImplementedException();}

protected uint _Mobilize_ControlFlag=1;
bool Mobilize.WebMap.Common.Core.ITrackable.IsNew {get =>(this._Mobilize_ControlFlag&_Mobilize_IsNew_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<0:this._Mobilize_ControlFlag&0<<0;
}
Mobilize.WebMap.Common.Core.IDelta Mobilize.WebMap.Common.Core.ITrackable.Delta =>this;
void Mobilize.WebMap.Common.Core.ITrackable.CleanChanges ()=>_Mobilize_CleanChanges();
protected virtual void _Mobilize_CleanChanges ()
{if(!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew||((Mobilize.WebMap.Common.Core.IObservable)this).RefCount>0)
{this._Mobilize_DirtyFlag_0=0;
this._Mobilize_LoadedFlag_0=0;
this._Mobilize_ControlFlag=0;
}
}
protected virtual Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{refs["m_vb6FormDefInstance"]=_Mobilize_References[0];
return refs;
}
private int _Mobilize_RefCount=0;
int Mobilize.WebMap.Common.Core.IObservable.DecrementRefCount ()
{return System.Threading.Interlocked.Decrement(ref _Mobilize_RefCount);
}
int Mobilize.WebMap.Common.Core.IObservable.IncrementRefCount ()
{return System.Threading.Interlocked.Increment(ref _Mobilize_RefCount);
}
int Mobilize.WebMap.Common.Core.IObservable.RefCount{get
{return _Mobilize_RefCount;
}
}
System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> Mobilize.WebMap.Common.Core.IObservable.GetReferences()
{return this._Mobilize_GetReferences();
}
protected virtual System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences(){var ref_m_vb6FormDefInstance=(Mobilize.WebMap.Common.Core.IObservable)this.m_vb6FormDefInstance;if(ref_m_vb6FormDefInstance!=null)yield return ref_m_vb6FormDefInstance;
yield break ;
}
const uint _Mobilize_IsNew_Flag=(uint)1<<0;
protected const uint _Mobilize_HasChanged_Flag=(uint)1<<1;
bool Mobilize.WebMap.Common.Core.ITrackable.HasChanged{get=>(this._Mobilize_ControlFlag&_Mobilize_HasChanged_Flag)>0;}
const uint _Mobilize_IsRefresh_Flag=(uint)1<<2;
bool Mobilize.WebMap.Common.Core.ITrackable.IsRefresh {get =>(this._Mobilize_ControlFlag&_Mobilize_IsRefresh_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<2:this._Mobilize_ControlFlag&0<<2;
}
const uint _Mobilize_IsMarked_Flag=(uint)1<<3;
bool Mobilize.WebMap.Common.Core.ITrackable.IsMarked {get =>(this._Mobilize_ControlFlag&_Mobilize_IsMarked_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<3:this._Mobilize_ControlFlag&0<<3;
}
bool Mobilize.WebMap.Common.Core.IDelta.IsNew{get =>(this._Mobilize_ControlFlag&_Mobilize_IsNew_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<0:this._Mobilize_ControlFlag&0<<0;
}Mobilize.WebMap.Common.Core.IObservable Mobilize.WebMap.Common.Core.IDelta.Target{get =>this;
set =>throw new System.NotImplementedException();
}System.Collections.Generic.IEnumerable<string> Mobilize.WebMap.Common.Core.IDelta.Changes=>this._Mobilize_GetChanges();
bool Mobilize.WebMap.Common.Core.IDelta.HasChanges(string propertyName)=>this._Mobilize_HasChanges(propertyName);
protected virtual System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_vb6FormDefInstance)>0)
{yield return "m_vb6FormDefInstance";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_InitializingDefInstance)>0)
{yield return "m_InitializingDefInstance";
}
yield break ;
}
protected virtual bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "m_vb6FormDefInstance":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_vb6FormDefInstance)>0;
case "m_InitializingDefInstance":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_InitializingDefInstance)>0;
}return false;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_LoadedFlag_0;
const uint _Mobilize_Dirty_m_vb6FormDefInstance=(uint)1<<0;
const uint _Mobilize_Loaded_m_vb6FormDefInstance=(uint)1<<0;
const uint _Mobilize_Dirty_m_InitializingDefInstance=(uint)1<<1;

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private SKS.frmProducts m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmProducts>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmProducts>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmProducts)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmProducts)value;}}
#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool m_InitializingDefInstance_k__BackingField;
internal bool m_InitializingDefInstance {get
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.m_InitializingDefInstance_k__BackingField;}set
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_InitializingDefInstance;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_InitializingDefInstance_k__BackingField=(bool)value;}}}
   	//Private Sub txtField_KeyPress(Index As Integer, KeyAscii As Integer)
   	//If Index = 0 Then
   	//    KeyAscii = Asc(UCase(Chr(KeyAscii)))
   	//ElseIf Index = 4 Or Index = 5 Then
   	//    Select Case KeyAscii
   	//        Case vbKey0 To vbKey9
   	//        Case vbKeyBack, vbKeyClear, vbKeyDelete
   	//        Case vbKeyLeft, vbKeyRight, vbKeyUp, vbKeyDown, vbKeyTab
   	//        Case Else
   	//            KeyAscii = 0
   	//            Beep
   	//    End Select
   	//End If
   	//End Sub

   }
}
#pragma warning restore
