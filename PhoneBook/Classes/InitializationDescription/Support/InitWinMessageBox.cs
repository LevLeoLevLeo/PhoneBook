﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.InitializationDescription.Support
{
    /// <summary>
    /// Класс, отвечающий за инициализацию кастомного MessageBox'а.
    /// </summary>
    class InitWinMessageBox : IInit
    {
        private Window Window { get; set; }
        private string TextMessage { get; set; }
        private string TextTitle { get; set; }
        private TextBlock TextBlock { get; set; }
        private TypeMessage TypeMessage { get; set; }
        private ButtonEn ButtonEn { get; set; }
        private Button ButtonOk { get; set; }
        private Button ButtonNo { get; set; }
        private Button ButtonYes { get; set; }
        private Button ButtonCancel { get; set; }
       
        public InitWinMessageBox(ref Window window, ref string textMessage, ref string textTitle,
            ref TextBlock textBlock, ref TypeMessage typeMessage, ref ButtonEn buttonEn,
            ref Button buttonOk, ref Button buttonNo,
            ref Button buttonYes, ref Button buttonCancel)
        {
            Window = window;
            TextMessage = textMessage;
            TextTitle = textTitle;
            TextBlock = textBlock;
            TypeMessage = typeMessage;
            ButtonEn = buttonEn;
            ButtonOk = buttonOk;
            ButtonNo = buttonNo;
            ButtonYes = buttonYes;
            ButtonCancel = buttonCancel;
        }

        public void Initialization()
        {
            TextBlock.Text = TextMessage;
            Window.Title = TextTitle;
            switch (TypeMessage)
            {
                case TypeMessage.Error:
                    SystemSounds.Exclamation.Play();
                    break;
                case TypeMessage.Information:
                    SystemSounds.Hand.Play();
                    break;
                case TypeMessage.Warning:
                    SystemSounds.Beep.Play();
                    break;
            }

            switch (ButtonEn)
            {
                case ButtonEn.YesNo:
                    ButtonYes.Visibility = Visibility.Visible;
                    ButtonNo.Visibility = Visibility.Visible;
                    break;
                case ButtonEn.YesNoCancel:
                    ButtonYes.Visibility = Visibility.Visible;
                    ButtonNo.Visibility = Visibility.Visible;
                    ButtonCancel.Visibility = Visibility.Visible;
                    break;
                case ButtonEn.Ok:
                    ButtonOk.Visibility = Visibility.Visible;
                    break;
                case ButtonEn.OkCancel:
                    ButtonYes.Visibility = Visibility.Visible;
                    ButtonCancel.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}