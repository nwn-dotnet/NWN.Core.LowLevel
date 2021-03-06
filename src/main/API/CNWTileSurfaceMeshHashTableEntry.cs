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

public unsafe class CNWTileSurfaceMeshHashTableEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWTileSurfaceMeshHashTableEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWTileSurfaceMeshHashTableEntry(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileSurfaceMeshHashTableEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileSurfaceMeshHashTableEntry() {
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
          NWNXLibPINVOKE.delete_CNWTileSurfaceMeshHashTableEntry(swigCPtr);
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

  public static unsafe implicit operator void*(CNWTileSurfaceMeshHashTableEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWTileSurfaceMeshHashTableEntry self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWTileSurfaceMeshHashTableEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTileSurfaceMeshHashTableEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTileSurfaceMeshHashTableEntry left, CNWTileSurfaceMeshHashTableEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTileSurfaceMeshHashTableEntry left, CNWTileSurfaceMeshHashTableEntry right) {
    return !Equals(left, right);
  }

  public int m_nBestTriangle {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshHashTableEntry_m_nBestTriangle_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSurfaceMeshHashTableEntry_m_nBestTriangle_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nRecentTriangle {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshHashTableEntry_m_nRecentTriangle_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSurfaceMeshHashTableEntry_m_nRecentTriangle_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fBestAttemptedDepth {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshHashTableEntry_m_fBestAttemptedDepth_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWTileSurfaceMeshHashTableEntry_m_fBestAttemptedDepth_get(swigCPtr);
      return ret;
    } 
  }

  public float m_fRecentAttemptedDepth {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshHashTableEntry_m_fRecentAttemptedDepth_set(swigCPtr, value);
    } 
    get {
      float ret = NWNXLibPINVOKE.CNWTileSurfaceMeshHashTableEntry_m_fRecentAttemptedDepth_get(swigCPtr);
      return ret;
    } 
  }

  public CNWTileSurfaceMeshHashTableEntry() : this(NWNXLibPINVOKE.new_CNWTileSurfaceMeshHashTableEntry(), true) {
  }

  public float Fetch(int nTriangle) {
    float ret = NWNXLibPINVOKE.CNWTileSurfaceMeshHashTableEntry_Fetch(swigCPtr, nTriangle);
    return ret;
  }

  public void Store(int nTriangle, float fDepth) {
    NWNXLibPINVOKE.CNWTileSurfaceMeshHashTableEntry_Store(swigCPtr, nTriangle, fDepth);
  }

}

}
