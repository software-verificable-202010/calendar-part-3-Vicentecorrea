﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarApp.Models;

namespace CalendarApp.Views
{
    public partial class EventInformationForm : Form
    {
        public EventInformationForm(Event @event)
        {
            InitializeComponent();
        }
    }
}