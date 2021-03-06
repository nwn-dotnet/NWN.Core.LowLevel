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

public unsafe class CNWSCreatureStats_ClassInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSCreatureStats_ClassInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSCreatureStats_ClassInfo(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSCreatureStats_ClassInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSCreatureStats_ClassInfo() {
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
          NWNXLibPINVOKE.delete_CNWSCreatureStats_ClassInfo(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSCreatureStats_ClassInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWSCreatureStats_ClassInfo self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWSCreatureStats_ClassInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSCreatureStats_ClassInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSCreatureStats_ClassInfo left, CNWSCreatureStats_ClassInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSCreatureStats_ClassInfo left, CNWSCreatureStats_ClassInfo right) {
    return !Equals(left, right);
  }

  public CExoArrayListUInt32Array m_pKnownSpellList {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_pKnownSpellList_set(swigCPtr, CExoArrayListUInt32Array.getCPtr(value));
    }  
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_pKnownSpellList_get(swigCPtr);;
        CExoArrayListUInt32Array ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListUInt32Array(cPtr, false);
        return ret;
    }

  }

  public CExoArrayListCNWSStatsSpellPtrArray m_pMemorizedSpellList {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_pMemorizedSpellList_set(swigCPtr, CExoArrayListCNWSStatsSpellPtrArray.getCPtr(value));
    }  
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_pMemorizedSpellList_get(swigCPtr);;
        CExoArrayListCNWSStatsSpellPtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCNWSStatsSpellPtrArray(cPtr, false);
        return ret;
    }

  }

  public uint[] m_nBonusSpellsList {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nBonusSpellsList_set(swigCPtr, value);
    }  
    get {
      uint* arrayPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nBonusSpellsList_get(swigCPtr);
      uint[] retVal = new uint[10];

      for(int i = 0; i < 10; i++) {
        retVal[i] = arrayPtr[i];
      }

      return retVal;
    }

  }

  public byte[] m_nSpellsPerDayLeft {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nSpellsPerDayLeft_set(swigCPtr, value);
    }  
    get {
      byte* arrayPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nSpellsPerDayLeft_get(swigCPtr);
      byte[] retVal = new byte[10];

      for(int i = 0; i < 10; i++) {
        retVal[i] = arrayPtr[i];
      }

      return retVal;
    }

  }

  public byte[] m_nMaxSpellsPerDayLeft {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nMaxSpellsPerDayLeft_set(swigCPtr, value);
    }  
    get {
      byte* arrayPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nMaxSpellsPerDayLeft_get(swigCPtr);
      byte[] retVal = new byte[10];

      for(int i = 0; i < 10; i++) {
        retVal[i] = arrayPtr[i];
      }

      return retVal;
    }

  }

  public byte m_nClass {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nClass_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nClass_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nLevel {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nNegativeLevels {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nNegativeLevels_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nNegativeLevels_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSchool {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nSchool_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nSchool_get(swigCPtr);
      return ret;
    } 
  }

  public byte[] m_nDomain {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nDomain_set(swigCPtr, value);
    }  
    get {
      byte* arrayPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_nDomain_get(swigCPtr);
      byte[] retVal = new byte[2];

      for(int i = 0; i < 2; i++) {
        retVal[i] = arrayPtr[i];
      }

      return retVal;
    }

  }

  public int m_bHasLostClassAbilities {
    set {
      NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_bHasLostClassAbilities_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_m_bHasLostClassAbilities_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSCreatureStats_ClassInfo() : this(NWNXLibPINVOKE.new_CNWSCreatureStats_ClassInfo(), true) {
  }

  public void SetMemorizedSpellSlot(byte nSpellLevel, byte nSpellSlot, uint nSpellId, int bDomainSpell, byte nMetaType) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetMemorizedSpellSlot(swigCPtr, nSpellLevel, nSpellSlot, nSpellId, bDomainSpell, nMetaType);
  }

  public void ClearMemorizedSpellSlot(byte nSpellLevel, byte nSpellSlot) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_ClearMemorizedSpellSlot(swigCPtr, nSpellLevel, nSpellSlot);
  }

  public void ClearMemorizedKnownSpells(uint nSpellId) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_ClearMemorizedKnownSpells(swigCPtr, nSpellId);
  }

  public void AddKnownSpell(byte nSpellLevel, uint nSpellId) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_AddKnownSpell(swigCPtr, nSpellLevel, nSpellId);
  }

  public void RemoveKnownSpell(byte nSpellLevel, uint nSpellId) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_RemoveKnownSpell(swigCPtr, nSpellLevel, nSpellId);
  }

  public uint GetKnownSpell(byte nSpellLevel, byte nSpellListIndex) {
    uint ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetKnownSpell(swigCPtr, nSpellLevel, nSpellListIndex);
    return ret;
  }

  public uint GetMemorizedSpellInSlot(byte nSpellLevel, byte nSpellSlot) {
    uint ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellInSlot(swigCPtr, nSpellLevel, nSpellSlot);
    return ret;
  }

  public int GetIsDomainSpell(byte nSpellLevel, byte nSpellSlot) {
    int ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetIsDomainSpell(swigCPtr, nSpellLevel, nSpellSlot);
    return ret;
  }

  public int ConfirmDomainSpell(byte nSpellLevel, uint nSpellID) {
    int ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_ConfirmDomainSpell(swigCPtr, nSpellLevel, nSpellID);
    return ret;
  }

  public CNWSStats_Spell GetMemorizedSpellInSlotDetails(byte nSpellLevel, byte nSpellSlot) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellInSlotDetails(swigCPtr, nSpellLevel, nSpellSlot);
    CNWSStats_Spell ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSStats_Spell(cPtr, false);
    return ret;
  }

  public ushort GetNumberKnownSpells(byte nSpellLevel) {
    ushort ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetNumberKnownSpells(swigCPtr, nSpellLevel);
    return ret;
  }

  public byte GetNumberMemorizedSpellSlots(byte nSpellLevel) {
    byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetNumberMemorizedSpellSlots(swigCPtr, nSpellLevel);
    return ret;
  }

  public void SetNumberMemorizedSpellSlots(byte nSpellLevel, byte nNumSlots, int bClear) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetNumberMemorizedSpellSlots__SWIG_0(swigCPtr, nSpellLevel, nNumSlots, bClear);
  }

  public void SetNumberMemorizedSpellSlots(byte nSpellLevel, byte nNumSlots) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetNumberMemorizedSpellSlots__SWIG_1(swigCPtr, nSpellLevel, nNumSlots);
  }

  public byte GetNumberBonusSpells(byte nSpellLevel) {
    byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetNumberBonusSpells(swigCPtr, nSpellLevel);
    return ret;
  }

  public void ModifyNumberBonusSpells(byte nSpellLevel, int nDelta) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_ModifyNumberBonusSpells(swigCPtr, nSpellLevel, nDelta);
  }

  public int GetMemorizedSpellInSlotReady(byte nSpellLevel, byte nSpellSlot) {
    int ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellInSlotReady(swigCPtr, nSpellLevel, nSpellSlot);
    return ret;
  }

  public void SetMemorizedSpellInSlotReady(byte nSpellLevel, byte nSpellSlot, int bReady) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetMemorizedSpellInSlotReady(swigCPtr, nSpellLevel, nSpellSlot, bReady);
  }

  public byte GetMemorizedSpellReadyCount(uint nSpellID, byte* nMinSpellLevel, byte* nMinSpellSlot, byte nRequestedMetaType) {
    byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellReadyCount__SWIG_0(swigCPtr, nSpellID, (global::System.IntPtr)nMinSpellLevel, (global::System.IntPtr)nMinSpellSlot, nRequestedMetaType);
    return ret;
  }

  public byte GetMemorizedSpellReadyCount(uint nSpellID, byte* nMinSpellLevel, byte* nMinSpellSlot) {
    byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellReadyCount__SWIG_1(swigCPtr, nSpellID, (global::System.IntPtr)nMinSpellLevel, (global::System.IntPtr)nMinSpellSlot);
    return ret;
  }

  public byte GetMemorizedSpellReadyCount(uint nSpellID, byte nSpellLevel) {
    byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellReadyCount__SWIG_2(swigCPtr, nSpellID, nSpellLevel);
    return ret;
  }

  public byte GetMemorizedSpellInSlotMetaType(byte nSpellLevel, byte nSpellSlot) {
    byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMemorizedSpellInSlotMetaType(swigCPtr, nSpellLevel, nSpellSlot);
    return ret;
  }

  public byte GetSpellsPerDayLeft(byte nSpellLevel) {
    byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetSpellsPerDayLeft(swigCPtr, nSpellLevel);
    return ret;
  }

  public void SetSpellsPerDayLeft(byte nSpellLevel, byte nNumSpells) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetSpellsPerDayLeft(swigCPtr, nSpellLevel, nNumSpells);
  }

  public byte GetMaxSpellsPerDayLeft(byte nSpellLevel) {
    byte ret = NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_GetMaxSpellsPerDayLeft(swigCPtr, nSpellLevel);
    return ret;
  }

  public void SetMaxSpellsPerDayLeft(byte nSpellLevel, byte nNumSpells) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_SetMaxSpellsPerDayLeft(swigCPtr, nSpellLevel, nNumSpells);
  }

  public void DecrementSpellsPerDayLeft(byte nSpellLevel) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_DecrementSpellsPerDayLeft(swigCPtr, nSpellLevel);
  }

  public void IncrementSpellsPerDayLeft(byte nSpellLevel) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_IncrementSpellsPerDayLeft(swigCPtr, nSpellLevel);
  }

  public void ResetSpellsPerDayLeft(byte nSpellLevel, byte nSpellGain) {
    NWNXLibPINVOKE.CNWSCreatureStats_ClassInfo_ResetSpellsPerDayLeft(swigCPtr, nSpellLevel, nSpellGain);
  }

}

}
