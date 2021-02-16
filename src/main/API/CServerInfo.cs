//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public unsafe class CServerInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CServerInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CServerInfo(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CServerInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CServerInfo() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CServerInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CServerInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CServerInfo self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CServerInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CServerInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CServerInfo left, CServerInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CServerInfo left, CServerInfo right) {
    return !Equals(left, right);
  }

  public int m_nDataChangedFlags {
    set {
      NWNXLibPINVOKE.CServerInfo_m_nDataChangedFlags_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerInfo_m_nDataChangedFlags_get(swigCPtr);
      return ret;
    } 
  }

  public short m_nServerMode {
    set {
      NWNXLibPINVOKE.CServerInfo_m_nServerMode_set(swigCPtr, value);
    } 
    get {
      short ret = NWNXLibPINVOKE.CServerInfo_m_nServerMode_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString m_sModuleName {
    set {
      NWNXLibPINVOKE.CServerInfo_m_sModuleName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_sModuleName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sServerSettings {
    set {
      NWNXLibPINVOKE.CServerInfo_m_sServerSettings_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_sServerSettings_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sModulesList {
    set {
      NWNXLibPINVOKE.CServerInfo_m_sModulesList_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_sModulesList_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sPlayerList {
    set {
      NWNXLibPINVOKE.CServerInfo_m_sPlayerList_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_sPlayerList_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sBannedList {
    set {
      NWNXLibPINVOKE.CServerInfo_m_sBannedList_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_sBannedList_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sPortalList {
    set {
      NWNXLibPINVOKE.CServerInfo_m_sPortalList_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_sPortalList_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sSavegameList {
    set {
      NWNXLibPINVOKE.CServerInfo_m_sSavegameList_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_sSavegameList_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sCharactervaultList {
    set {
      NWNXLibPINVOKE.CServerInfo_m_sCharactervaultList_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_sCharactervaultList_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CJoiningRestrictions m_JoiningRestrictions {
    set {
      NWNXLibPINVOKE.CServerInfo_m_JoiningRestrictions_set(swigCPtr, CJoiningRestrictions.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_JoiningRestrictions_get(swigCPtr);
      CJoiningRestrictions ret = (cPtr == global::System.IntPtr.Zero) ? null : new CJoiningRestrictions(cPtr, false);
      return ret;
    } 
  }

  public CPlayOptions m_PlayOptions {
    set {
      NWNXLibPINVOKE.CServerInfo_m_PlayOptions_set(swigCPtr, CPlayOptions.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_PlayOptions_get(swigCPtr);
      CPlayOptions ret = (cPtr == global::System.IntPtr.Zero) ? null : new CPlayOptions(cPtr, false);
      return ret;
    } 
  }

  public CResetOption m_ResetOption {
    set {
      NWNXLibPINVOKE.CServerInfo_m_ResetOption_set(swigCPtr, CResetOption.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_ResetOption_get(swigCPtr);
      CResetOption ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResetOption(cPtr, false);
      return ret;
    } 
  }

  public CAutoSave m_AutoSave {
    set {
      NWNXLibPINVOKE.CServerInfo_m_AutoSave_set(swigCPtr, CAutoSave.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_AutoSave_get(swigCPtr);
      CAutoSave ret = (cPtr == global::System.IntPtr.Zero) ? null : new CAutoSave(cPtr, false);
      return ret;
    } 
  }

  public CPersistantWorldOptions m_PersistantWorldOptions {
    set {
      NWNXLibPINVOKE.CServerInfo_m_PersistantWorldOptions_set(swigCPtr, CPersistantWorldOptions.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_PersistantWorldOptions_get(swigCPtr);
      CPersistantWorldOptions ret = (cPtr == global::System.IntPtr.Zero) ? null : new CPersistantWorldOptions(cPtr, false);
      return ret;
    } 
  }

  public CServerNetOptions m_NetOptions {
    set {
      NWNXLibPINVOKE.CServerInfo_m_NetOptions_set(swigCPtr, CServerNetOptions.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_NetOptions_get(swigCPtr);
      CServerNetOptions ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerNetOptions(cPtr, false);
      return ret;
    } 
  }

  public NWSyncAdvertisement m_nwsyncData {
    set {
      NWNXLibPINVOKE.CServerInfo_m_nwsyncData_set(swigCPtr, NWSyncAdvertisement.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_nwsyncData_get(swigCPtr);
      NWSyncAdvertisement ret = (cPtr == global::System.IntPtr.Zero) ? null : new NWSyncAdvertisement(cPtr, false);
      return ret;
    } 
  }

  public int m_bNWSyncPublishHaks {
    set {
      NWNXLibPINVOKE.CServerInfo_m_bNWSyncPublishHaks_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerInfo_m_bNWSyncPublishHaks_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bConversationMultiPlayer {
    set {
      NWNXLibPINVOKE.CServerInfo_m_bConversationMultiPlayer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerInfo_m_bConversationMultiPlayer_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bConversationMultiPlayerViewOnly {
    set {
      NWNXLibPINVOKE.CServerInfo_m_bConversationMultiPlayerViewOnly_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerInfo_m_bConversationMultiPlayerViewOnly_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nDifficulty {
    set {
      NWNXLibPINVOKE.CServerInfo_m_nDifficulty_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CServerInfo_m_nDifficulty_get(swigCPtr);
      return ret;
    } 
  }

  public CServerOptionLookupArray m_pOptionsTable {
    set {
      NWNXLibPINVOKE.CServerInfo_m_pOptionsTable_set(swigCPtr, CServerOptionLookupArray.getCPtr(value));
    }  
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CServerInfo_m_pOptionsTable_get(swigCPtr);;
        CServerOptionLookupArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CServerOptionLookupArray(cPtr, false);
        return ret;
    }

  }

  public CServerInfo() : this(NWNXLibPINVOKE.new_CServerInfo(), true) {
  }

  public void SetDifficultyLevel(int nDifficulty, int bChangePVP) {
    NWNXLibPINVOKE.CServerInfo_SetDifficultyLevel__SWIG_0(swigCPtr, nDifficulty, bChangePVP);
  }

  public void SetDifficultyLevel(int nDifficulty) {
    NWNXLibPINVOKE.CServerInfo_SetDifficultyLevel__SWIG_1(swigCPtr, nDifficulty);
  }

  public int FindOptionIndex(CExoString sOptionCategory, CExoString sOptionName) {
    int ret = NWNXLibPINVOKE.CServerInfo_FindOptionIndex(swigCPtr, CExoString.getCPtr(sOptionCategory), CExoString.getCPtr(sOptionName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
