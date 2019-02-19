﻿using System;
using System.Collections.Generic;
using System.Text;

using HidLibrary;
using NZXTSharp;

namespace NZXTSharp.COM
{
    /// <summary>
    /// Copied from https://github.com/DarkMio/Octopode with modifications.
    /// </summary>
    class DeviceEnumerator
    {
        public static IEnumerable<HidDevice> EnumAllDevices()
        {
            return HidDevices.Enumerate();
        }

        public static IEnumerable<HidDevice> EnumNZXTDevices()
        {
            return HidDevices.Enumerate(0x1E71);
        }

        public static IEnumerable<HidDevice> EnumKrakenMDevices()
        {
            foreach (var device in EnumNZXTDevices())
            {
                if (device.Attributes.ProductId == (int)HIDDeviceID.KrakenM)
                {
                    yield return device;
                }
            }
        }

        public static IEnumerable<HidDevice> EnumKrakenXDevices()
        {
            foreach (var device in EnumNZXTDevices())
            {
                if (device.Attributes.ProductId == (int)HIDDeviceID.KrakenX)
                {
                    yield return device;
                }
            }
        }
    }
}
