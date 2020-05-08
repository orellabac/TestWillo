#pragma warning disable
#line 1 "frmUsersManage.cs"
#pragma warning disable
#line 1 "frmUsersManage.cs"
using System;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmUsersManage
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[29];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_CurrentEditedUser)>0)
{yield return "CurrentEditedUser";
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lstAccounts_ColumnHeader_1_)>0)
{yield return "lstAccounts_ColumnHeader_1_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lstAccounts_ColumnHeader_2_)>0)
{yield return "lstAccounts_ColumnHeader_2_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lstAccounts_ColumnHeader_3_)>0)
{yield return "lstAccounts_ColumnHeader_3_";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lstAccounts)>0)
{yield return "lstAccounts";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClear)>0)
{yield return "cmdClear";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdSave)>0)
{yield return "cmdSave";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ctrlLiner1)>0)
{yield return "ctrlLiner1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtFullname)>0)
{yield return "txtFullname";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtPassword)>0)
{yield return "txtPassword";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtUsername)>0)
{yield return "txtUsername";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cboLevel)>0)
{yield return "cboLevel";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Label1_2)>0)
{yield return "_Label1_2";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Label1_0)>0)
{yield return "_Label1_0";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Label1_1)>0)
{yield return "_Label1_1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Label1_3)>0)
{yield return "_Label1_3";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblId)>0)
{yield return "lblId";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Frame1)>0)
{yield return "Frame1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0)
{yield return "cmdClose";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdEdit)>0)
{yield return "cmdEdit";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdDelete)>0)
{yield return "cmdDelete";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Label1_4)>0)
{yield return "_Label1_4";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label19)>0)
{yield return "Label19";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0)
{yield return "Label4";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Image1)>0)
{yield return "Image1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label1)>0)
{yield return "Label1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_listViewHelper1)>0)
{yield return "listViewHelper1";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "CurrentEditedUser":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_CurrentEditedUser)>0;
case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "lstAccounts_ColumnHeader_1_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lstAccounts_ColumnHeader_1_)>0;
case "lstAccounts_ColumnHeader_2_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lstAccounts_ColumnHeader_2_)>0;
case "lstAccounts_ColumnHeader_3_":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lstAccounts_ColumnHeader_3_)>0;
case "lstAccounts":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lstAccounts)>0;
case "cmdClear":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClear)>0;
case "cmdSave":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdSave)>0;
case "ctrlLiner1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ctrlLiner1)>0;
case "txtFullname":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtFullname)>0;
case "txtPassword":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtPassword)>0;
case "txtUsername":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtUsername)>0;
case "cboLevel":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cboLevel)>0;
case "_Label1_2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Label1_2)>0;
case "_Label1_0":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Label1_0)>0;
case "_Label1_1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Label1_1)>0;
case "_Label1_3":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Label1_3)>0;
case "lblId":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblId)>0;
case "Frame1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Frame1)>0;
case "cmdClose":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0;
case "cmdEdit":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdEdit)>0;
case "cmdDelete":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdDelete)>0;
case "_Label1_4":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__Label1_4)>0;
case "Label19":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label19)>0;
case "Label4":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label4)>0;
case "Image1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Image1)>0;
case "Label1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label1)>0;
case "listViewHelper1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_listViewHelper1)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["lstAccounts_ColumnHeader_1_"]=_Mobilize_References[3];
refs["lstAccounts_ColumnHeader_2_"]=_Mobilize_References[4];
refs["lstAccounts_ColumnHeader_3_"]=_Mobilize_References[5];
refs["lstAccounts"]=_Mobilize_References[6];
refs["cmdClear"]=_Mobilize_References[7];
refs["cmdSave"]=_Mobilize_References[8];
refs["ctrlLiner1"]=_Mobilize_References[9];
refs["txtFullname"]=_Mobilize_References[10];
refs["txtPassword"]=_Mobilize_References[11];
refs["txtUsername"]=_Mobilize_References[12];
refs["cboLevel"]=_Mobilize_References[13];
refs["_Label1_2"]=_Mobilize_References[14];
refs["_Label1_0"]=_Mobilize_References[15];
refs["_Label1_1"]=_Mobilize_References[16];
refs["_Label1_3"]=_Mobilize_References[17];
refs["lblId"]=_Mobilize_References[18];
refs["Frame1"]=_Mobilize_References[19];
refs["cmdClose"]=_Mobilize_References[20];
refs["cmdEdit"]=_Mobilize_References[21];
refs["cmdDelete"]=_Mobilize_References[22];
refs["_Label1_4"]=_Mobilize_References[23];
refs["Label19"]=_Mobilize_References[24];
refs["Label4"]=_Mobilize_References[25];
refs["Image1"]=_Mobilize_References[26];
refs["Label1"]=_Mobilize_References[27];
refs["listViewHelper1"]=_Mobilize_References[28];
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
var ref_lstAccounts_ColumnHeader_1_=(Mobilize.WebMap.Common.Core.IObservable)this.lstAccounts_ColumnHeader_1_;if(ref_lstAccounts_ColumnHeader_1_!=null)yield return ref_lstAccounts_ColumnHeader_1_;
var ref_lstAccounts_ColumnHeader_2_=(Mobilize.WebMap.Common.Core.IObservable)this.lstAccounts_ColumnHeader_2_;if(ref_lstAccounts_ColumnHeader_2_!=null)yield return ref_lstAccounts_ColumnHeader_2_;
var ref_lstAccounts_ColumnHeader_3_=(Mobilize.WebMap.Common.Core.IObservable)this.lstAccounts_ColumnHeader_3_;if(ref_lstAccounts_ColumnHeader_3_!=null)yield return ref_lstAccounts_ColumnHeader_3_;
var ref_lstAccounts=(Mobilize.WebMap.Common.Core.IObservable)this.lstAccounts;if(ref_lstAccounts!=null)yield return ref_lstAccounts;
var ref_cmdClear=(Mobilize.WebMap.Common.Core.IObservable)this.cmdClear;if(ref_cmdClear!=null)yield return ref_cmdClear;
var ref_cmdSave=(Mobilize.WebMap.Common.Core.IObservable)this.cmdSave;if(ref_cmdSave!=null)yield return ref_cmdSave;
var ref_ctrlLiner1=(Mobilize.WebMap.Common.Core.IObservable)this.ctrlLiner1;if(ref_ctrlLiner1!=null)yield return ref_ctrlLiner1;
var ref_txtFullname=(Mobilize.WebMap.Common.Core.IObservable)this.txtFullname;if(ref_txtFullname!=null)yield return ref_txtFullname;
var ref_txtPassword=(Mobilize.WebMap.Common.Core.IObservable)this.txtPassword;if(ref_txtPassword!=null)yield return ref_txtPassword;
var ref_txtUsername=(Mobilize.WebMap.Common.Core.IObservable)this.txtUsername;if(ref_txtUsername!=null)yield return ref_txtUsername;
var ref_cboLevel=(Mobilize.WebMap.Common.Core.IObservable)this.cboLevel;if(ref_cboLevel!=null)yield return ref_cboLevel;
var ref__Label1_2=(Mobilize.WebMap.Common.Core.IObservable)this._Label1_2;if(ref__Label1_2!=null)yield return ref__Label1_2;
var ref__Label1_0=(Mobilize.WebMap.Common.Core.IObservable)this._Label1_0;if(ref__Label1_0!=null)yield return ref__Label1_0;
var ref__Label1_1=(Mobilize.WebMap.Common.Core.IObservable)this._Label1_1;if(ref__Label1_1!=null)yield return ref__Label1_1;
var ref__Label1_3=(Mobilize.WebMap.Common.Core.IObservable)this._Label1_3;if(ref__Label1_3!=null)yield return ref__Label1_3;
var ref_lblId=(Mobilize.WebMap.Common.Core.IObservable)this.lblId;if(ref_lblId!=null)yield return ref_lblId;
var ref_Frame1=(Mobilize.WebMap.Common.Core.IObservable)this.Frame1;if(ref_Frame1!=null)yield return ref_Frame1;
var ref_cmdClose=(Mobilize.WebMap.Common.Core.IObservable)this.cmdClose;if(ref_cmdClose!=null)yield return ref_cmdClose;
var ref_cmdEdit=(Mobilize.WebMap.Common.Core.IObservable)this.cmdEdit;if(ref_cmdEdit!=null)yield return ref_cmdEdit;
var ref_cmdDelete=(Mobilize.WebMap.Common.Core.IObservable)this.cmdDelete;if(ref_cmdDelete!=null)yield return ref_cmdDelete;
var ref__Label1_4=(Mobilize.WebMap.Common.Core.IObservable)this._Label1_4;if(ref__Label1_4!=null)yield return ref__Label1_4;
var ref_Label19=(Mobilize.WebMap.Common.Core.IObservable)this.Label19;if(ref_Label19!=null)yield return ref_Label19;
var ref_Label4=(Mobilize.WebMap.Common.Core.IObservable)this.Label4;if(ref_Label4!=null)yield return ref_Label4;
var ref_Image1=(Mobilize.WebMap.Common.Core.IObservable)this.Image1;if(ref_Image1!=null)yield return ref_Image1;
var ref_Label1=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.Label1);if(ref_Label1!=null)yield return ref_Label1;
var ref_listViewHelper1=(Mobilize.WebMap.Common.Core.IObservable)this.listViewHelper1;if(ref_listViewHelper1!=null)yield return ref_listViewHelper1;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_LoadedFlag_0;
const uint _Mobilize_Dirty_CurrentEditedUser=(uint)1<<0;
const uint _Mobilize_Dirty_visualControls=(uint)1<<1;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<2;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<3;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty_lstAccounts_ColumnHeader_1_=(uint)1<<4;
const uint _Mobilize_Loaded_lstAccounts_ColumnHeader_1_=(uint)1<<3;
const uint _Mobilize_Dirty_lstAccounts_ColumnHeader_2_=(uint)1<<5;
const uint _Mobilize_Loaded_lstAccounts_ColumnHeader_2_=(uint)1<<4;
const uint _Mobilize_Dirty_lstAccounts_ColumnHeader_3_=(uint)1<<6;
const uint _Mobilize_Loaded_lstAccounts_ColumnHeader_3_=(uint)1<<5;
const uint _Mobilize_Dirty_lstAccounts=(uint)1<<7;
const uint _Mobilize_Loaded_lstAccounts=(uint)1<<6;
const uint _Mobilize_Dirty_cmdClear=(uint)1<<8;
const uint _Mobilize_Loaded_cmdClear=(uint)1<<7;
const uint _Mobilize_Dirty_cmdSave=(uint)1<<9;
const uint _Mobilize_Loaded_cmdSave=(uint)1<<8;
const uint _Mobilize_Dirty_ctrlLiner1=(uint)1<<10;
const uint _Mobilize_Loaded_ctrlLiner1=(uint)1<<9;
const uint _Mobilize_Dirty_txtFullname=(uint)1<<11;
const uint _Mobilize_Loaded_txtFullname=(uint)1<<10;
const uint _Mobilize_Dirty_txtPassword=(uint)1<<12;
const uint _Mobilize_Loaded_txtPassword=(uint)1<<11;
const uint _Mobilize_Dirty_txtUsername=(uint)1<<13;
const uint _Mobilize_Loaded_txtUsername=(uint)1<<12;
const uint _Mobilize_Dirty_cboLevel=(uint)1<<14;
const uint _Mobilize_Loaded_cboLevel=(uint)1<<13;
const uint _Mobilize_Dirty__Label1_2=(uint)1<<15;
const uint _Mobilize_Loaded__Label1_2=(uint)1<<14;
const uint _Mobilize_Dirty__Label1_0=(uint)1<<16;
const uint _Mobilize_Loaded__Label1_0=(uint)1<<15;
const uint _Mobilize_Dirty__Label1_1=(uint)1<<17;
const uint _Mobilize_Loaded__Label1_1=(uint)1<<16;
const uint _Mobilize_Dirty__Label1_3=(uint)1<<18;
const uint _Mobilize_Loaded__Label1_3=(uint)1<<17;
const uint _Mobilize_Dirty_lblId=(uint)1<<19;
const uint _Mobilize_Loaded_lblId=(uint)1<<18;
const uint _Mobilize_Dirty_Frame1=(uint)1<<20;
const uint _Mobilize_Loaded_Frame1=(uint)1<<19;
const uint _Mobilize_Dirty_cmdClose=(uint)1<<21;
const uint _Mobilize_Loaded_cmdClose=(uint)1<<20;
const uint _Mobilize_Dirty_cmdEdit=(uint)1<<22;
const uint _Mobilize_Loaded_cmdEdit=(uint)1<<21;
const uint _Mobilize_Dirty_cmdDelete=(uint)1<<23;
const uint _Mobilize_Loaded_cmdDelete=(uint)1<<22;
const uint _Mobilize_Dirty__Label1_4=(uint)1<<24;
const uint _Mobilize_Loaded__Label1_4=(uint)1<<23;
const uint _Mobilize_Dirty_Label19=(uint)1<<25;
const uint _Mobilize_Loaded_Label19=(uint)1<<24;
const uint _Mobilize_Dirty_Label4=(uint)1<<26;
const uint _Mobilize_Loaded_Label4=(uint)1<<25;
const uint _Mobilize_Dirty_Image1=(uint)1<<27;
const uint _Mobilize_Loaded_Image1=(uint)1<<26;
const uint _Mobilize_Dirty_Label1=(uint)1<<28;
const uint _Mobilize_Loaded_Label1=(uint)1<<27;
const uint _Mobilize_Dirty_listViewHelper1=(uint)1<<29;
const uint _Mobilize_Loaded_listViewHelper1=(uint)1<<28;
private void Mobilize_Initialize_Properties()
{
#line 16
                                             this.CurrentEditedUser="";
#line hidden
 
#line 48
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "lstAccounts_ColumnHeader_1_", "lstAccounts_ColumnHeader_2_", "lstAccounts_ColumnHeader_3_", "lstAccounts", "cmdClear", "cmdSave", "ctrlLiner1", "txtFullname", "txtPassword", "txtUsername", "cboLevel", "_Label1_2", "_Label1_0", "_Label1_1", "_Label1_3", "lblId", "Frame1", "cmdClose", "cmdEdit", "cmdDelete", "_Label1_4", "Label19", "Label4", "Image1", "Label1", "listViewHelper1"};
#line hidden
 
#line 131
                                                       this.Label1=new Mobilize.Web.Label[5];
#line hidden
 }
#line 12
    

#line hidden
                                             
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string CurrentEditedUser_k__BackingField;
#line 16
                                             

      [Intercepted]

      string CurrentEditedUser 
#line 16
                               { 
#line 16
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.CurrentEditedUser_k__BackingField;} 
#line 16

#line 16
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CurrentEditedUser;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CurrentEditedUser_k__BackingField=(string)value;} 
#line 16
                                           } 
#line 17


      public frmUsersManage()
      	: base()
      {

#line hidden
this.Mobilize_Initialize_Properties();
#line 21
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



      private void cmdClear_Click(Object eventSender, EventArgs eventArgs)
      {
      	txtUsername.Text = "";
      	txtUsername.Focus();
      	ClearFields();
      }

      private void cmdDelete_Click(Object eventSender, EventArgs eventArgs)
      {
      	if (modFunctions.NoRecords(lstAccounts, "Please add/select a user"))
      	{
      		return;
      	}
      	if ( Mobilize.Web.MessageBox.Show("Are you sure you want to delete the user '" + lstAccounts.FocusedItem.Text + "'?", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Exclamation) == Mobilize.Web.DialogResult.Yes)
         {
         	modConnection.ExecuteSql("Select * from Users");
         	if (modConnection.rs.RecordCount == 1)
            {
               Mobilize.Web.MessageBox.Show("You cannot delete the last user", "Delete error", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Error);
               return;
            }
            modConnection.ExecuteSql("Delete From Users Where Username = '" + lstAccounts.FocusedItem.Text + "'");
            LoadUsers();
         }
      }

      private void cmdEdit_Click(Object eventSender, EventArgs eventArgs)
      {
      	if (modFunctions.NoRecords(lstAccounts, "Please add/select a user"))
      	{
      		return;
      	}
      	modConnection.ExecuteSql("Select * from Users where Username = '" + lstAccounts.FocusedItem.Text + "'");
      	txtUsername.Text = Convert.ToString(modConnection.rs["UserName"]);
      	if (modConnection.rs.EOF)
      	{
            Mobilize.Web.MessageBox.Show("This user does not exist", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Information);
            txtUsername.Focus();
         }
         else
         {
            txtUsername.Text = Convert.ToString(modConnection.rs["UserName"]);
            CurrentEditedUser = txtUsername.Text;
            txtPassword.Text = Convert.ToString(modConnection.rs["Password"]);
            txtFullname.Text = Convert.ToString(modConnection.rs["Fullname"]);
            cboLevel.Text = Convert.ToString(modConnection.rs["Level"]);
            cmdSave.Text = "&Update";
         }
      }

      private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
      {
      	string SecId = "";
      	if (modFunctions.TextBoxEmpty(txtUsername))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtPassword))
      	{
      		return;
      	}
      	if (modFunctions.TextBoxEmpty(txtFullname))
      	{
      		return;
      	}
      	if (modFunctions.ComboEmpty(cboLevel))
      	{
      		return;
      	}

      	modConnection.ExecuteSql("Select * from Users where Username = '" + txtUsername.Text + "'");
      	if (cmdSave.Text != "&Update")
         {
         	if (!modConnection.rs.EOF)
         	{
               Mobilize.Web.MessageBox.Show("Add failed: Username already exists", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Error);
               return;
            }

            if (cboLevel.Text != "Administrator")
            {
            	modConnection.ExecuteSql2("Select * from Users where level = 'Administrator'");
            	if (modConnection.rs2.EOF)
            	{
                  Mobilize.Web.MessageBox.Show("Update failed: No any Administrator found on accounts.  You are not allowed to change the level of this account", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Error);
                  return;
               }
            }
            if (!modMain.CurrentUserAdmin && cboLevel.Text == "Administrator")
            {
               Mobilize.Web.MessageBox.Show("You cannot add another level without being 'Administrator'", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Information);
               cboLevel.Focus();
               return;
            }
            modConnection.rs.AddNew();
            modMain.msg = "Added new user " + txtUsername.Text;
         }
         else if (CurrentEditedUser != txtUsername.Text)
         {
         	modConnection.ExecuteSql2("Select * from Users where username = '" + txtUsername.Text + "'");
         	if (!modConnection.rs2.EOF)
         	{
               Mobilize.Web.MessageBox.Show("Username '" + txtUsername.Text + "' already exists.", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Information);
               txtUsername.Focus();
               modFunctions.SelectAll(txtUsername);
               return;
            }
            modMain.msg = "Record for the user " + txtUsername.Text + " has been successfully updated";
         }
         else
         {
            modMain.msg = "Record for the user " + txtUsername.Text + " has been successfully updated";
         }
         modConnection.rs["UserName"] = txtUsername.Text;
         modConnection.rs["Password"] = txtPassword.Text;
         modConnection.rs["Level"] = cboLevel.Text;
         modConnection.rs["Fullname"] = txtFullname.Text;
         modConnection.rs.Update();
         modMain.LogStatus(modMain.msg);
         ClearFields();
         LoadUsers();

         if (modMain.CurrentUserAdmin)
         {
            this.Close();
         }
      }

      public void LoadUsers()
      {
      	modConnection.ExecuteSql("Select * from Users");
      	lstAccounts.Items.Clear();
         Mobilize.Web.ListViewItem x = null;
         while (!modConnection.rs.EOF)
         {
         	x = lstAccounts.Items.Add(Convert.ToString(modConnection.rs["UserName"]));
            Mobilize.Web.ListView.GetListViewSubItem(x, 1).Text = Convert.ToString(modConnection.rs["Fullname"]);
            Mobilize.Web.ListView.GetListViewSubItem(x, 2).Text = Convert.ToString(modConnection.rs["Level"]);
            modConnection.rs.MoveNext();
         }
      }

      public void LoadUsersAvoidingWith()
      {
      	modConnection.ExecuteSql("Select * from Users");
      	lstAccounts.Items.Clear();
         Mobilize.Web.ListViewItem x = null;
         while (!modConnection.rs.EOF)
         {
         	x = lstAccounts.Items.Add(Convert.ToString(modConnection.rs["UserName"]));
            Mobilize.Web.ListView.GetListViewSubItem(x, 1).Text = Convert.ToString(modConnection.rs["Fullname"]);
            Mobilize.Web.ListView.GetListViewSubItem(x, 2).Text = Convert.ToString(modConnection.rs["Level"]);
            modConnection.rs.MoveNext();
         }
      }


      public void ClearFields()
      {
      	txtUsername.Text = "";
      	txtPassword.Text = "";
      	txtFullname.Text = "";
      	cboLevel.SelectedIndex = -1;
      	cmdSave.Text = "&Save";
      }

      private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
      {
      	this.Close();
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080

      private void Form_Load()
      {
      	modConnection.ExecuteSql("Select * from Levels");
      	while (!modConnection.rs.EOF)
      	{
      		cboLevel.AddItem(Convert.ToString(modConnection.rs["Level"]));
      		modConnection.rs.MoveNext();
      	}
      	if (modMain.CurrentUserAdmin)
      	{
      		cboLevel.Text = "Administrator";
      	}
      	else
      	{
      		cboLevel.SelectedIndex = -1;
      	}
      	LoadUsers();
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      	if (modMain.CurrentUserAdmin)
      	{
      		modConnection.ExecuteSql("Select * from Users");
      		if (modConnection.rs.EOF)
      		{
               Mobilize.Web.MessageBox.Show("System has failed to initialized. Please contact your administrator" + Environment.NewLine + Environment.NewLine + "Status: analysing accounts configuration" + Environment.NewLine +
                     "Error: No users found", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Error);
               Environment.Exit(0);
            }
         	//frmxSplash.tmrLoad.Enabled = True
         }
         modMain.LogStatus("");
      }

      private void lstAccounts_DoubleClick(Object eventSender, EventArgs eventArgs)
      {
      	cmdEdit_Click(cmdEdit, new EventArgs());
      }

      private void txtFullname_Enter(Object eventSender, EventArgs eventArgs)
      {
      	modFunctions.SelectAll(txtFullname);
      }

      private void txtPassword_Enter(Object eventSender, EventArgs eventArgs)
      {
      	modFunctions.SelectAll(txtPassword);
      }

      private void txtUsername_Enter(Object eventSender, EventArgs eventArgs)
      {
      	modFunctions.SelectAll(txtUsername);
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
private SKS.frmUsersManage m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmUsersManage>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmUsersManage>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmUsersManage)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmUsersManage)value;}}
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
