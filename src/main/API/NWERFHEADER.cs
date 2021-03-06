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

public unsafe class NWERFHEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public NWERFHEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public NWERFHEADER(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NWERFHEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NWERFHEADER() {
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
          NWNXLibPINVOKE.delete_NWERFHEADER(swigCPtr);
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

  public static unsafe implicit operator void*(NWERFHEADER self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(NWERFHEADER self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(NWERFHEADER other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is NWERFHEADER other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(NWERFHEADER left, NWERFHEADER right) {
    return Equals(left, right);
  }

  public static bool operator !=(NWERFHEADER left, NWERFHEADER right) {
    return !Equals(left, right);
  }

  public string sVersion {
    set {
      NWNXLibPINVOKE.NWERFHEADER_sVersion_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.NWERFHEADER_sVersion_get(swigCPtr);
      return ret;
    } 
  }

  public uint nStringCount {
    set {
      NWNXLibPINVOKE.NWERFHEADER_nStringCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.NWERFHEADER_nStringCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint nTotalStringSize {
    set {
      NWNXLibPINVOKE.NWERFHEADER_nTotalStringSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.NWERFHEADER_nTotalStringSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint nEntryCount {
    set {
      NWNXLibPINVOKE.NWERFHEADER_nEntryCount_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.NWERFHEADER_nEntryCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint nOffsetToStringList {
    set {
      NWNXLibPINVOKE.NWERFHEADER_nOffsetToStringList_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.NWERFHEADER_nOffsetToStringList_get(swigCPtr);
      return ret;
    } 
  }

  public uint nOffsetToKeyList {
    set {
      NWNXLibPINVOKE.NWERFHEADER_nOffsetToKeyList_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.NWERFHEADER_nOffsetToKeyList_get(swigCPtr);
      return ret;
    } 
  }

  public uint nOffsetToResourceList {
    set {
      NWNXLibPINVOKE.NWERFHEADER_nOffsetToResourceList_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.NWERFHEADER_nOffsetToResourceList_get(swigCPtr);
      return ret;
    } 
  }

  public uint nBuildYear {
    set {
      NWNXLibPINVOKE.NWERFHEADER_nBuildYear_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.NWERFHEADER_nBuildYear_get(swigCPtr);
      return ret;
    } 
  }

  public uint nBuildDay {
    set {
      NWNXLibPINVOKE.NWERFHEADER_nBuildDay_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.NWERFHEADER_nBuildDay_get(swigCPtr);
      return ret;
    } 
  }

  public uint nDescriptionStrRef {
    set {
      NWNXLibPINVOKE.NWERFHEADER_nDescriptionStrRef_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.NWERFHEADER_nDescriptionStrRef_get(swigCPtr);
      return ret;
    } 
  }

  public byte[] nUnused {
    set {
      NWNXLibPINVOKE.NWERFHEADER_nUnused_set(swigCPtr, value);
    }  
    get {
      byte* arrayPtr = NWNXLibPINVOKE.NWERFHEADER_nUnused_get(swigCPtr);
      byte[] retVal = new byte[116];

      for(int i = 0; i < 116; i++) {
        retVal[i] = arrayPtr[i];
      }

      return retVal;
    }

  }

  public NWERFHEADER() : this(NWNXLibPINVOKE.new_NWERFHEADER(), true) {
  }

}

}
