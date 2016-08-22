﻿// <copyright file="Sender.cs" company="Hottinger Baldwin Messtechnik GmbH">
//
// SharpScan, a library for scanning and configuring HBM devices.
//
// The MIT License (MIT)
//
// Copyright (C) Hottinger Baldwin Messtechnik GmbH
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS
// BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN
// ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hbm.Devices.Scan.Configure;

public class Sender : ConfigurationCallback
{
    private ConfigurationService service;

    private Sender()
    {
        this.service = new ConfigurationService();
    }

    public static void Main(string[] args)
    {
        Sender sender = new Sender();
        ConfigurationDevice device = new ConfigurationDevice("0009e5001231");
        ConfigurationNetSettings settings = new ConfigurationNetSettings(new ConfigurationInterface("eth0", ConfigurationInterface.Method.Dhcp));
        ConfigurationParams parameters = new ConfigurationParams(device, settings);
        sender.service.SendConfiguration(parameters, sender, 1000);
    }

    public void OnError(JsonRpcResponse response)
    {
        throw new NotImplementedException();
    }

    public void OnSuccess(JsonRpcResponse response)
    {
        throw new NotImplementedException();
    }

    public void OnTimeout(double timeoutMs)
    {
        throw new NotImplementedException();
    }
}