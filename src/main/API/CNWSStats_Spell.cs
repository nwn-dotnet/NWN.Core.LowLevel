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

public unsafe class CNWSStats_Spell : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSStats_Spell(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSStats_Spell(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSStats_Spell obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSStats_Spell() {
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
          NWNXLibPINVOKE.delete_CNWSStats_Spell(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSStats_Spell self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWSStats_Spell self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWSStats_Spell other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSStats_Spell other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSStats_Spell left, CNWSStats_Spell right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSStats_Spell left, CNWSStats_Spell right) {
    return !Equals(left, right);
  }

  public uint m_nSpellId {
    set {
      NWNXLibPINVOKE.CNWSStats_Spell_m_nSpellId_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSStats_Spell_m_nSpellId_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bReadied {
    set {
      NWNXLibPINVOKE.CNWSStats_Spell_m_bReadied_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSStats_Spell_m_bReadied_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMetaType {
    set {
      NWNXLibPINVOKE.CNWSStats_Spell_m_nMetaType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSStats_Spell_m_nMetaType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bDomainSpell {
    set {
      NWNXLibPINVOKE.CNWSStats_Spell_m_bDomainSpell_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSStats_Spell_m_bDomainSpell_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSStats_Spell() : this(NWNXLibPINVOKE.new_CNWSStats_Spell(), true) {
  }

}

}
