﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace SocialMediaApp.Controls
    {
    public class Spacer : ContentView
        {
        public BoxView Box { get; set; }

        public Spacer()
            {
            Box = new BoxView
                {
                BackgroundColor = Colors.Transparent,
                HeightRequest = 20
                };

            Content = Box;
            SetValue(SpaceProperty, 20); // optional but good
            }

        public static readonly BindableProperty SpaceProperty =
            BindableProperty.Create(
                nameof(Space),
                typeof(int),
                typeof(Spacer),
                defaultValue: 20,
                propertyChanged: OnSpacePropertyChanged);

        public int Space
            {
            get => (int)GetValue(SpaceProperty);
            set => SetValue(SpaceProperty, value);
            }

        private static void OnSpacePropertyChanged(BindableObject bindable, object oldValue, object newValue)
            {
            if (bindable is Spacer spacer)
                {
                spacer.Box.HeightRequest = spacer.Space;
                }
            }
        }
    }
