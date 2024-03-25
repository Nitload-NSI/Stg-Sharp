﻿//-----------------------------------------------------------------------
//-----------------------------------------------------------------------
//     file="framework.cs"
//     Project: StgSharp
//     AuthorGroup: Nitload Space
//     Copyright (c) Nitload Space. All rights reserved.
//     
//     Permission is hereby granted, free of charge, to any person 
//     obtaining a copy of this software and associated documentation 
//     files (the “Software”), to deal in the Software without restriction, 
//     including without limitation the rights to use, copy, modify, merge,
//     publish, distribute, sublicense, and/or sell copies of the Software, 
//     and to permit persons to whom the Software is furnished to do so, 
//     subject to the following conditions:
//     
//     The above copyright notice and 
//     this permission notice shall be included in all copies 
//     or substantial portions of the Software.
//     
//     THE SOFTWARE IS PROVIDED “AS IS”, 
//     WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
//     ARISING FROM, OUT OF OR IN CONNECTION WITH 
//     THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//     
//-----------------------------------------------------------------------
//-----------------------------------------------------------------------
using StgSharp.Graphics;

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

#if Windows
// using Windows.Win32;
#endif

namespace StgSharp
{
    internal partial class InternalIO
    {
        #region api call

        [DllImport(SSC_libname, EntryPoint = "glfwInit")] internal static extern unsafe int glfwInit();

        [DllImport(SSC_libname, EntryPoint = "glfwTerminate")] internal static extern unsafe void glfwTerminate();

        [DllImport(SSC_libname, EntryPoint = "glfwInitHint")] internal static extern unsafe void glfwInitHint(int hint, int value);

        [DllImport(SSC_libname, EntryPoint = "glfwGetVersion")] internal static extern unsafe void glfwGetVersion(int* major, int* minor, int* rev);

        [DllImport(SSC_libname, EntryPoint = "glfwGetVersionString")] internal static extern unsafe byte* glfwGetVersionString();

        [DllImport(SSC_libname, EntryPoint = "glfwGetError")] internal static extern unsafe int glfwGetError(byte** description);

        [DllImport(SSC_libname, EntryPoint = "glfwSetErrorCallback")] internal static extern unsafe GLFWerrorfun glfwSetErrorCallback(GLFWerrorfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwGetMonitors")] internal static extern unsafe IntPtr* glfwGetMonitors(int* count);

        [DllImport(SSC_libname, EntryPoint = "glfwGetPrimaryMonitor")] internal static extern unsafe IntPtr glfwGetPrimaryMonitor();

        [DllImport(SSC_libname, EntryPoint = "glfwGetMonitorPos")] internal static extern unsafe void glfwGetMonitorPos(IntPtr monitor, int* xpos, int* ypos);

        [DllImport(SSC_libname, EntryPoint = "glfwGetMonitorWorkarea")] internal static extern unsafe void glfwGetMonitorWorkarea(IntPtr monitor, int* xpos, int* ypos, int* width, int* height);

        [DllImport(SSC_libname, EntryPoint = "glfwGetMonitorPhysicalSize")] internal static extern unsafe void glfwGetMonitorPhysicalSize(IntPtr monitor, int* widthMM, int* heightMM);

        [DllImport(SSC_libname, EntryPoint = "glfwGetMonitorContentScale")] internal static extern unsafe void glfwGetMonitorContentScale(IntPtr monitor, float* xscale, float* yscale);

        [DllImport(SSC_libname, EntryPoint = "glfwGetMonitorName")] internal static extern unsafe byte* glfwGetMonitorName(IntPtr monitor);

        [DllImport(SSC_libname, EntryPoint = "glfwSetMonitorUserPointer")] internal static extern unsafe void glfwSetMonitorUserPointer(IntPtr monitor, void* pointer);

        [DllImport(SSC_libname, EntryPoint = "glfwGetMonitorUserPointer")] internal static extern unsafe void* glfwGetMonitorUserPointer(IntPtr monitor);

        [DllImport(SSC_libname, EntryPoint = "glfwSetMonitorCallback")] internal static extern unsafe GLFWmonitorfun glfwSetMonitorCallback(GLFWmonitorfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwGetVideoModes")] internal static extern unsafe GLFWvidmode* glfwGetVideoModes(IntPtr monitor, int* count);

        [DllImport(SSC_libname, EntryPoint = "glfwGetVideoMode")] internal static extern unsafe GLFWvidmode* glfwGetVideoMode(IntPtr monitor);

        [DllImport(SSC_libname, EntryPoint = "glfwSetGamma")] internal static extern unsafe void glfwSetGamma(IntPtr monitor, float gamma);

        [DllImport(SSC_libname, EntryPoint = "glfwGetGammaRamp")] internal static extern unsafe GLFWgammaramp* glfwGetGammaRamp(IntPtr monitor);

        [DllImport(SSC_libname, EntryPoint = "glfwSetGammaRamp")] internal static extern unsafe void glfwSetGammaRamp(IntPtr monitor, GLFWgammaramp* ramp);

        [DllImport(SSC_libname, EntryPoint = "glfwDefaultWindowHints")] internal static extern unsafe void glfwDefaultWindowHints();

        [DllImport(SSC_libname, EntryPoint = "glfwWindowHint")] internal static extern unsafe void glfwWindowHint(int hint, int value);

        [DllImport(SSC_libname, EntryPoint = "glfwWindowHintString")] internal static extern unsafe void glfwWindowHintString(int hint, byte* value);

        [DllImport(SSC_libname, EntryPoint = "glfwCreateWindow")] internal static extern unsafe IntPtr glfwCreateWindow(int width, int height, byte[] title, IntPtr monitor, IntPtr share);

        [DllImport(SSC_libname, EntryPoint = "glfwDestroyWindow")] internal static extern unsafe void glfwDestroyWindow(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwWindowShouldClose")] internal static extern unsafe int glfwWindowShouldClose(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowShouldClose")] internal static extern unsafe void glfwSetWindowShouldClose(IntPtr window, int value);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowTitle")] internal static extern unsafe void glfwSetWindowTitle(IntPtr window, byte* title);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowIcon")] internal static extern unsafe void glfwSetWindowIcon(IntPtr window, int count, GLFWimage* images);

        [DllImport(SSC_libname, EntryPoint = "glfwGetWindowPos")] internal static extern unsafe void glfwGetWindowPos(IntPtr window, int* xpos, int* ypos);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowPos")] internal static extern unsafe void glfwSetWindowPos(IntPtr window, int xpos, int ypos);

        [DllImport(SSC_libname, EntryPoint = "glfwGetWindowSize")] internal static extern unsafe void glfwGetWindowSize(IntPtr window, int* width, int* height);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowSizeLimits")] internal static extern unsafe void glfwSetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowAspectRatio")] internal static extern unsafe void glfwSetWindowAspectRatio(IntPtr window, int numer, int denom);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowSize")] internal static extern unsafe void glfwSetWindowSize(IntPtr window, int width, int height);

        [DllImport(SSC_libname, EntryPoint = "glfwGetFramebufferSize")] internal static extern unsafe void glfwGetFramebufferSize(IntPtr window, int* width, int* height);

        [DllImport(SSC_libname, EntryPoint = "glfwGetWindowFrameSize")] internal static extern unsafe void glfwGetWindowFrameSize(IntPtr window, int* left, int* top, int* right, int* bottom);

        [DllImport(SSC_libname, EntryPoint = "glfwGetWindowContentScale")] internal static extern unsafe void glfwGetWindowContentScale(IntPtr window, float* xscale, float* yscale);

        [DllImport(SSC_libname, EntryPoint = "glfwGetWindowOpacity")] internal static extern unsafe float glfwGetWindowOpacity(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowOpacity")] internal static extern unsafe void glfwSetWindowOpacity(IntPtr window, float opacity);

        [DllImport(SSC_libname, EntryPoint = "glfwIconifyWindow")] internal static extern unsafe void glfwIconifyWindow(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwRestoreWindow")] internal static extern unsafe void glfwRestoreWindow(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwMaximizeWindow")] internal static extern unsafe void glfwMaximizeWindow(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwShowWindow")] internal static extern unsafe void glfwShowWindow(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwHideWindow")] internal static extern unsafe void glfwHideWindow(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwFocusWindow")] internal static extern unsafe void glfwFocusWindow(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwRequestWindowAttention")] internal static extern unsafe void glfwRequestWindowAttention(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwGetWindowMonitor")] internal static extern unsafe IntPtr glfwGetWindowMonitor(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowMonitor")] internal static extern unsafe void glfwSetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);

        [DllImport(SSC_libname, EntryPoint = "glfwGetWindowAttrib")] internal static extern unsafe int glfwGetWindowAttrib(IntPtr window, int attrib);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowAttrib")] internal static extern unsafe void glfwSetWindowAttrib(IntPtr window, int attrib, int value);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowUserPointer")] internal static extern unsafe void glfwSetWindowUserPointer(IntPtr window, void* pointer);

        [DllImport(SSC_libname, EntryPoint = "glfwGetWindowUserPointer")] internal static extern unsafe void* glfwGetWindowUserPointer(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowPosCallback")] internal static extern unsafe GLFWwindowposfun glfwSetWindowPosCallback(IntPtr window, GLFWwindowposfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowSizeCallback")] internal static extern unsafe GLFWwindowsizefun glfwSetWindowSizeCallback(IntPtr window, GLFWwindowsizefun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowCloseCallback")] internal static extern unsafe GLFWwindowclosefun glfwSetWindowCloseCallback(IntPtr window, GLFWwindowclosefun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowRefreshCallback")] internal static extern unsafe GLFWwindowrefreshfun glfwSetWindowRefreshCallback(IntPtr window, GLFWwindowrefreshfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowFocusCallback")] internal static extern unsafe GLFWwindowfocusfun glfwSetWindowFocusCallback(IntPtr window, GLFWwindowfocusfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowIconifyCallback")] internal static extern unsafe GLFWwindowiconifyfun glfwSetWindowIconifyCallback(IntPtr window, GLFWwindowiconifyfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowMaximizeCallback")] internal static extern unsafe GLFWwindowmaximizefun glfwSetWindowMaximizeCallback(IntPtr window, GLFWwindowmaximizefun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetFramebufferSizeCallback")] internal static extern unsafe FramebuffersizeHandler glfwSetFramebufferSizeCallback(IntPtr window, IntPtr callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetWindowContentScaleCallback")] internal static extern unsafe GLFWwindowcontentscalefun glfwSetWindowContentScaleCallback(IntPtr window, GLFWwindowcontentscalefun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwPollEvents")] internal static extern unsafe void glfwPollEvents();

        [DllImport(SSC_libname, EntryPoint = "glfwWaitEvents")] internal static extern unsafe void glfwWaitEvents();

        [DllImport(SSC_libname, EntryPoint = "glfwWaitEventsTimeout")] internal static extern unsafe void glfwWaitEventsTimeout(double timeout);

        [DllImport(SSC_libname, EntryPoint = "glfwPostEmptyEvent")] internal static extern unsafe void glfwPostEmptyEvent();

        [DllImport(SSC_libname, EntryPoint = "glfwGetInputMode")] internal static extern unsafe int glfwGetInputMode(IntPtr window, int mode);

        [DllImport(SSC_libname, EntryPoint = "glfwSetInputMode")] internal static extern unsafe void glfwSetInputMode(IntPtr window, int mode, int value);

        [DllImport(SSC_libname, EntryPoint = "glfwRawMouseMotionSupported")] internal static extern unsafe int glfwRawMouseMotionSupported();

        [DllImport(SSC_libname, EntryPoint = "glfwGetKeyName")] internal static extern unsafe byte* glfwGetKeyName(int key, int scancode);

        [DllImport(SSC_libname, EntryPoint = "glfwGetKeyScancode")] internal static extern unsafe int glfwGetKeyScancode(int key);

        [DllImport(SSC_libname, EntryPoint = "glfwGetKey")] internal static extern unsafe KeyStatus glfwGetKey(IntPtr window, int key);

        [DllImport(SSC_libname, EntryPoint = "glfwGetMouseButton")] internal static extern unsafe int glfwGetMouseButton(IntPtr window, int button);

        [DllImport(SSC_libname, EntryPoint = "glfwGetCursorPos")] internal static extern unsafe void glfwGetCursorPos(IntPtr window, double* xpos, double* ypos);

        [DllImport(SSC_libname, EntryPoint = "glfwSetCursorPos")] internal static extern unsafe void glfwSetCursorPos(IntPtr window, double xpos, double ypos);

        [DllImport(SSC_libname, EntryPoint = "glfwCreateCursor")] internal static extern unsafe GLFWcursor* glfwCreateCursor(GLFWimage* image, int xhot, int yhot);

        [DllImport(SSC_libname, EntryPoint = "glfwCreateStandardCursor")] internal static extern unsafe GLFWcursor* glfwCreateStandardCursor(int shape);

        [DllImport(SSC_libname, EntryPoint = "glfwDestroyCursor")] internal static extern unsafe void glfwDestroyCursor(GLFWcursor* cursor);

        [DllImport(SSC_libname, EntryPoint = "glfwSetCursor")] internal static extern unsafe void glfwSetCursor(IntPtr window, GLFWcursor* cursor);

        [DllImport(SSC_libname, EntryPoint = "glfwSetKeyCallback")] internal static extern unsafe GLFWkeyfun glfwSetKeyCallback(IntPtr window, GLFWkeyfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetCharCallback")] internal static extern unsafe GLFWcharfun glfwSetCharCallback(IntPtr window, GLFWcharfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetCharModsCallback")] internal static extern unsafe GLFWcharmodsfun glfwSetCharModsCallback(IntPtr window, GLFWcharmodsfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetMouseButtonCallback")] internal static extern unsafe GLFWmousebuttonfun glfwSetMouseButtonCallback(IntPtr window, GLFWmousebuttonfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetCursorPosCallback")] internal static extern unsafe GLFWcursorposfun glfwSetCursorPosCallback(IntPtr window, GLFWcursorposfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetCursorEnterCallback")] internal static extern unsafe GLFWcursorenterfun glfwSetCursorEnterCallback(IntPtr window, GLFWcursorenterfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetScrollCallback")] internal static extern unsafe GLFWscrollfun glfwSetScrollCallback(IntPtr window, GLFWscrollfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwSetDropCallback")] internal static extern unsafe GLFWdropfun glfwSetDropCallback(IntPtr window, GLFWdropfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwJoystickPresent")] internal static extern unsafe int glfwJoystickPresent(int jid);

        [DllImport(SSC_libname, EntryPoint = "glfwGetJoystickAxes")] internal static extern unsafe float* glfwGetJoystickAxes(int jid, int* count);

        [DllImport(SSC_libname, EntryPoint = "glfwGetJoystickButtons")] internal static extern unsafe byte* glfwGetJoystickButtons(int jid, int* count);

        [DllImport(SSC_libname, EntryPoint = "glfwGetJoystickHats")] internal static extern unsafe byte* glfwGetJoystickHats(int jid, int* count);

        [DllImport(SSC_libname, EntryPoint = "glfwGetJoystickName")] internal static extern unsafe byte* glfwGetJoystickName(int jid);

        [DllImport(SSC_libname, EntryPoint = "glfwGetJoystickGUID")] internal static extern unsafe byte* glfwGetJoystickGUID(int jid);

        [DllImport(SSC_libname, EntryPoint = "glfwSetJoystickUserPointer")] internal static extern unsafe void glfwSetJoystickUserPointer(int jid, void* pointer);

        [DllImport(SSC_libname, EntryPoint = "glfwGetJoystickUserPointer")] internal static extern unsafe void* glfwGetJoystickUserPointer(int jid);

        [DllImport(SSC_libname, EntryPoint = "glfwJoystickIsGamepad")] internal static extern unsafe int glfwJoystickIsGamepad(int jid);

        [DllImport(SSC_libname, EntryPoint = "glfwSetJoystickCallback")] internal static extern unsafe GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun callback);

        [DllImport(SSC_libname, EntryPoint = "glfwUpdateGamepadMappings")] internal static extern unsafe int glfwUpdateGamepadMappings(byte* str);

        [DllImport(SSC_libname, EntryPoint = "glfwGetGamepadName")] internal static extern unsafe byte* glfwGetGamepadName(int jid);

        [DllImport(SSC_libname, EntryPoint = "glfwGetGamepadState")] internal static extern unsafe int glfwGetGamepadState(int jid, GLFWgamepadstate* state);

        [DllImport(SSC_libname, EntryPoint = "glfwSetClipboardString")] internal static extern unsafe void glfwSetClipboardString(IntPtr window, byte* str);

        [DllImport(SSC_libname, EntryPoint = "glfwGetClipboardString")] internal static extern unsafe byte* glfwGetClipboardString(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwGetTime")] internal static extern unsafe double glfwGetTime();

        [DllImport(SSC_libname, EntryPoint = "glfwSetTime")] internal static extern unsafe void glfwSetTime(double time);

        [DllImport(SSC_libname, EntryPoint = "glfwGetTimerValue")] internal static extern unsafe ulong* glfwGetTimerValue();

        [DllImport(SSC_libname, EntryPoint = "glfwGetTimerFrequency")] internal static extern unsafe ulong* glfwGetTimerFrequency();

        [DllImport(SSC_libname, EntryPoint = "glfwMakeContextCurrent")] internal static extern unsafe void glfwMakeContextCurrent(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwGetCurrentContext")] internal static extern unsafe IntPtr glfwGetCurrentContext();

        [DllImport(SSC_libname, EntryPoint = "glfwSwapBuffers")] internal static extern unsafe void glfwSwapBuffers(IntPtr window);

        [DllImport(SSC_libname, EntryPoint = "glfwSwapInterval")] internal static extern unsafe void glfwSwapInterval(int interval);

        [DllImport(SSC_libname, EntryPoint = "glfwExtensionSupported")] internal static extern unsafe int glfwExtensionSupported(byte* extension);

        [DllImport(SSC_libname, EntryPoint = "glfwGetProcAddress", CharSet = CharSet.Ansi)] internal static extern unsafe IntPtr glfwGetProcAddress(string procname);

        [DllImport(SSC_libname, EntryPoint = "glfwVulkanSupported")] internal static extern unsafe int glfwVulkanSupported();

        [DllImport(SSC_libname, EntryPoint = "glfwGetRequiredInstanceExtensions")] internal static extern unsafe byte** glfwGetRequiredInstanceExtensions(uint* count);

        //[DllImport(InternalIO.SSC_libname, EntryPoint = "glfwGetInstanceProcAddress")] internal extern unsafe static GLFWvkproc glfwGetInstanceProcAddress(VkInstance instance, byte* procname);
        //[DllImport(InternalIO.SSC_libname, EntryPoint = "glfwGetPhysicalDevicePresentationSupport")] internal extern unsafe static int glfwGetPhysicalDevicePresentationSupport(VkInstance instance, VkPhysicalDevice device, uint* queuefamily);
        //[DllImport(InternalIO.SSC_libname, EntryPoint = "glfwCreateWindowSurface")] internal extern unsafe static VkResult glfwCreateWindowSurface(VkInstance instance, GLFWwindow* window, VkAllocationCallbacks* allocator, VkSurfaceKHR* surface);

        #endregion api call
    }
}