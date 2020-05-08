#pragma warning disable
#line 1 "frmAbout.cs"
#pragma warning disable
#line 1 "frmAbout.cs"
using System;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;

namespace SKS
{

   [Observable]
   internal partial class frmAbout
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[12];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0)
{yield return "visualControls";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0)
{yield return "components";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0)
{yield return "ToolTipMain";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_picIcon)>0)
{yield return "picIcon";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdOK)>0)
{yield return "cmdOK";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Line1_1)>0)
{yield return "_Line1_1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblDescription)>0)
{yield return "lblDescription";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblTitle)>0)
{yield return "lblTitle";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Line1_0)>0)
{yield return "_Line1_0";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblVersion)>0)
{yield return "lblVersion";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblDisclaimer)>0)
{yield return "lblDisclaimer";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Line1)>0)
{yield return "Line1";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "picIcon":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_picIcon)>0;
case "cmdOK":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdOK)>0;
case "_Line1_1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Line1_1)>0;
case "lblDescription":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblDescription)>0;
case "lblTitle":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblTitle)>0;
case "_Line1_0":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Line1_0)>0;
case "lblVersion":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblVersion)>0;
case "lblDisclaimer":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblDisclaimer)>0;
case "Line1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Line1)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["picIcon"]=_Mobilize_References[3];
refs["cmdOK"]=_Mobilize_References[4];
refs["_Line1_1"]=_Mobilize_References[5];
refs["lblDescription"]=_Mobilize_References[6];
refs["lblTitle"]=_Mobilize_References[7];
refs["_Line1_0"]=_Mobilize_References[8];
refs["lblVersion"]=_Mobilize_References[9];
refs["lblDisclaimer"]=_Mobilize_References[10];
refs["Line1"]=_Mobilize_References[11];
return refs;
}
protected override void _Mobilize_CleanChanges()
{if(!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew||((Mobilize.WebMap.Common.Core.IObservable)this).RefCount>0)
{this._Mobilize_DirtyFlag_0=0;
this._Mobilize_LoadedFlag_0=0;
this._Mobilize_ControlFlag=0;
}
base._Mobilize_CleanChanges();}
protected override System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
{foreach ( var baseRef in base._Mobilize_GetReferences()) {yield return baseRef;
}var ref_visualControls=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.visualControls);if(ref_visualControls!=null)yield return ref_visualControls;
var ref_components=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.components);if(ref_components!=null)yield return ref_components;
var ref_ToolTipMain=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.ToolTipMain);if(ref_ToolTipMain!=null)yield return ref_ToolTipMain;
var ref_picIcon=(Mobilize.WebMap.Common.Core.IObservable)this.picIcon;if(ref_picIcon!=null)yield return ref_picIcon;
var ref_cmdOK=(Mobilize.WebMap.Common.Core.IObservable)this.cmdOK;if(ref_cmdOK!=null)yield return ref_cmdOK;
var ref__Line1_1=(Mobilize.WebMap.Common.Core.IObservable)this._Line1_1;if(ref__Line1_1!=null)yield return ref__Line1_1;
var ref_lblDescription=(Mobilize.WebMap.Common.Core.IObservable)this.lblDescription;if(ref_lblDescription!=null)yield return ref_lblDescription;
var ref_lblTitle=(Mobilize.WebMap.Common.Core.IObservable)this.lblTitle;if(ref_lblTitle!=null)yield return ref_lblTitle;
var ref__Line1_0=(Mobilize.WebMap.Common.Core.IObservable)this._Line1_0;if(ref__Line1_0!=null)yield return ref__Line1_0;
var ref_lblVersion=(Mobilize.WebMap.Common.Core.IObservable)this.lblVersion;if(ref_lblVersion!=null)yield return ref_lblVersion;
var ref_lblDisclaimer=(Mobilize.WebMap.Common.Core.IObservable)this.lblDisclaimer;if(ref_lblDisclaimer!=null)yield return ref_lblDisclaimer;
var ref_Line1=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.Line1);if(ref_Line1!=null)yield return ref_Line1;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_LoadedFlag_0;
const uint _Mobilize_Dirty_visualControls=(uint)1<<0;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<1;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty_picIcon=(uint)1<<3;
const uint _Mobilize_Loaded_picIcon=(uint)1<<3;
const uint _Mobilize_Dirty_cmdOK=(uint)1<<4;
const uint _Mobilize_Loaded_cmdOK=(uint)1<<4;
const uint _Mobilize_Dirty__Line1_1=(uint)1<<5;
const uint _Mobilize_Loaded__Line1_1=(uint)1<<5;
const uint _Mobilize_Dirty_lblDescription=(uint)1<<6;
const uint _Mobilize_Loaded_lblDescription=(uint)1<<6;
const uint _Mobilize_Dirty_lblTitle=(uint)1<<7;
const uint _Mobilize_Loaded_lblTitle=(uint)1<<7;
const uint _Mobilize_Dirty__Line1_0=(uint)1<<8;
const uint _Mobilize_Loaded__Line1_0=(uint)1<<8;
const uint _Mobilize_Dirty_lblVersion=(uint)1<<9;
const uint _Mobilize_Loaded_lblVersion=(uint)1<<9;
const uint _Mobilize_Dirty_lblDisclaimer=(uint)1<<10;
const uint _Mobilize_Loaded_lblDisclaimer=(uint)1<<10;
const uint _Mobilize_Dirty_Line1=(uint)1<<11;
const uint _Mobilize_Loaded_Line1=(uint)1<<11;
private void Mobilize_Initialize_Properties()
{
#line 48
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "picIcon", "cmdOK", "_Line1_1", "lblDescription", "lblTitle", "_Line1_0", "lblVersion", "lblDisclaimer", "Line1"};
#line hidden
 
#line 83
                                                      this.Line1=new Mobilize.Web.Label[2];
#line hidden
 }
#line 11
    


   	// Reg Key Security Options...
   	const int READ_CONTROL = 0x20000;
   	const int KEY_QUERY_VALUE = 0x1;
   	const int KEY_SET_VALUE = 0x2;
   	const int KEY_CREATE_SUB_KEY = 0x4;
   	const int KEY_ENUMERATE_SUB_KEYS = 0x8;
   	const int KEY_NOTIFY = 0x10;
   	const int KEY_CREATE_LINK = 0x20;
   	const int KEY_ALL_ACCESS = KEY_QUERY_VALUE + KEY_SET_VALUE + KEY_CREATE_SUB_KEY + KEY_ENUMERATE_SUB_KEYS + KEY_NOTIFY + KEY_CREATE_LINK + READ_CONTROL;

   	// Reg Key ROOT Types...
   	const int HKEY_LOCAL_MACHINE = unchecked((int) 0x80000002);
   	const int ERROR_SUCCESS = 0;
   	const int REG_SZ = 1; // Unicode nul terminated string
   	const int REG_DWORD = 4; // 32-bit number
   	public frmAbout()
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




      private void cmdOk_Click(Object eventSender, EventArgs eventArgs)
      {
         this.Close();
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      private void Form_Load()
      {
         this.Text = "About " + AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly());
         //lblVersion.Caption = "Version " & App.Major & "." & App.Minor & "." & App.Revision
         lblTitle.Text = AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly());
      }
      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
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
private SKS.frmAbout m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmAbout>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmAbout>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmAbout)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmAbout)value;}}
#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool m_InitializingDefInstance_k__BackingField;
internal bool m_InitializingDefInstance {get
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.m_InitializingDefInstance_k__BackingField;}set
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_InitializingDefInstance;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_InitializingDefInstance_k__BackingField=(bool)value;}}}
   }
}
#pragma warning restore
