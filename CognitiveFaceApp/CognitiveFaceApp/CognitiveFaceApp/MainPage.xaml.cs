﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.ProjectOxford.Face;
using Plugin.Media;
using Plugin.Media.Abstractions;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Files;

namespace CognitiveFaceApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RunButton_OnClicked(object sender, EventArgs e)
        {
            // 画像の選択
            var photo = "";
            var imageChoiceResult = await DisplayAlert("どちらの画像を使いますか", "", "カメラ", "ローカルフォルダー");

            try
            {
                if (imageChoiceResult)
                {
                    photo = await TakePhotoAsync();
                }
                else
                {
                    photo = await PickPhotoAsync();
                }
            }
            catch (Exception exception)
            {
                await DisplayAlert("エラーが発生しました", exception.Message, "OK");
            }

            // 画像の判定
            ImagePreview.Source = photo;
            var faceResult = new FaceDetectResult();

            try
            {
                faceResult = await DetectFaceAsync(photo);
            }
            catch (Exception exception)
            {
                await DisplayAlert("Face API の呼び出しに失敗しました", exception.Message, "OK");
                return;
            }

            // 判定結果を配置
            Age.Text = "年齢 : " + faceResult.Age;
            Gender.Text = "性別 : " + faceResult.Gender;

            Emotion.Text = "表情 : ";
            Emotion.Text = "笑顔 : " + (faceResult.Smile * 100).ToString("##0") + "点";


        }

        private async void ResetButton_OnClicked(object sender, EventArgs e)
        {
            ImagePreview.Source = null;

            Age.Text = "年齢";
            Gender.Text = "性別";
            Emotion.Text = "表情";
        }


        public class FaceDetectResult
        {
            public double Age { get; set; }
            public string Gender { get; set; }            
            public double Smile { get; set; }
        }

        public static async Task<FaceDetectResult> DetectFaceAsync(string photo)
        {
            // Face API 呼び出し準備
            var apiKey = "c432ceb56c32447c8abac13509da5d93";
            var apiLocation = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0";
            var client = new FaceServiceClient(apiKey, apiLocation);

            // Face API で判定
            var file = new FileFromPath(photo);
            var imageStream = file.Open(FileAccess.Read);

            var attributes = new FaceAttributeType[] {
                FaceAttributeType.Age,FaceAttributeType.Gender,FaceAttributeType.Smile,
            };
            var result = await client.DetectAsync(imageStream, false, false, attributes);

            // 判定結果を代入
            var detectResult = new FaceDetectResult();

            detectResult.Age = result[0].FaceAttributes.Age;
            detectResult.Gender = result[0].FaceAttributes.Gender;
            detectResult.Smile = result[0].FaceAttributes.Smile;

            return detectResult;
        }

        public static async Task<string> TakePhotoAsync()
        {
            // カメラを初期化
            await CrossMedia.Current.Initialize();

            // カメラを使えるかどうか判定
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                throw new NotSupportedException("カメラをアプリから利用できるように設定してください");
            }

            // 撮影し、保存したファイルを取得
            var photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions());

            // 保存したファイルのパスを取得
            return photo.Path;
        }

        public static async Task<string> PickPhotoAsync()
        {
            // ローカルフォルダーから写真を選択させる
            var photo = await CrossMedia.Current.PickPhotoAsync();

            // 保存したファイルのパスを取得
            return photo.Path;

        }

    }
}