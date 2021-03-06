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

public unsafe class ENCAPSULATED_KEYLISTENTRY : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ENCAPSULATED_KEYLISTENTRY(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public ENCAPSULATED_KEYLISTENTRY(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ENCAPSULATED_KEYLISTENTRY obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ENCAPSULATED_KEYLISTENTRY() {
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
          NWNXLibPINVOKE.delete_ENCAPSULATED_KEYLISTENTRY(swigCPtr);
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

  public static unsafe implicit operator void*(ENCAPSULATED_KEYLISTENTRY self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(ENCAPSULATED_KEYLISTENTRY self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(ENCAPSULATED_KEYLISTENTRY other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is ENCAPSULATED_KEYLISTENTRY other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(ENCAPSULATED_KEYLISTENTRY left, ENCAPSULATED_KEYLISTENTRY right) {
    return Equals(left, right);
  }

  public static bool operator !=(ENCAPSULATED_KEYLISTENTRY left, ENCAPSULATED_KEYLISTENTRY right) {
    return !Equals(left, right);
  }

  public byte[] resRef {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_resRef_set(swigCPtr, value);
    }  
    get {
      byte* arrayPtr = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_resRef_get(swigCPtr);
      byte[] retVal = new byte[16];

      for(int i = 0; i < 16; i++) {
        retVal[i] = arrayPtr[i];
      }

      return retVal;
    }

  }

  public uint nID {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nID_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nID_get(swigCPtr);
      return ret;
    } 
  }

  public ushort nType {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nType_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_nType_get(swigCPtr);
      return ret;
    } 
  }

  public ushort unused {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_unused_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_unused_get(swigCPtr);
      return ret;
    } 
  }

  public ENCAPSULATED_KEYLISTENTRY() : this(NWNXLibPINVOKE.new_ENCAPSULATED_KEYLISTENTRY(), true) {
  }

}

}
