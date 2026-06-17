using BepInEx.Configuration;
using Utility.Toast;

namespace AbyssMod
{
    /// <summary>
    /// Global configuration manager.
    /// Initializes all config entries and binds change listeners.
    /// </summary>
    public static class Config
    {
#if DEBUG
        #region Debug
        public static ConfigEntry<bool> Offline;
        public static ConfigEntry<string> OfflineAPI;
        public static bool OfflineStartup;
        #endregion
#endif

        #region General
        public static ConfigEntry<bool> DynamicMosaic;
        public static ConfigEntry<bool> SoundCaution;
        public static ConfigEntry<bool> VoiceInterruption;
        public static ConfigEntry<bool> TitleMovie;
        #endregion

        #region Translation
        public static ConfigEntry<bool> Translation;
        public static ConfigEntry<string> TranslationCDN;
        public static ConfigEntry<string> TranslationLanguage;
        public static ConfigEntry<string> TranslationCryptoTag;
        public static ConfigEntry<string> TranslationCryptoKey;
        #endregion

        #region Font
        public static ConfigEntry<string> FontBundlePath;
        #endregion

        /// <summary>
        /// Initializes the config system.
        /// </summary>
        public static void Initialize()
        {
            BindAllEntries();
            BindSettingChangedLog();
        }

        private static void BindAllEntries()
        {
#if DEBUG
            #region Debug
            Offline = Plugin.ConfigFile.Bind(
                "Debug.Offline",
                "Enabled",
                false,
                "API localization for debug"
            );
            OfflineAPI = Plugin.ConfigFile.Bind(
                "Debug.Offline",
                "CDN",
                "http://localhost:33333/abyss/",
                "CDN for debug"
            );
            #endregion
#endif

            #region General
            DynamicMosaic = Plugin.ConfigFile.Bind(
                "General",
                "DynamicMosaic",
                false,
                "게임 내 동적 모자이크를 활성화할지 여부"
            );
            SoundCaution = Plugin.ConfigFile.Bind(
                "General",
                "SoundCaution",
                false,
                "게임 시작 시 볼륨 알림 팝업을 표시할지 여부"
            );
            VoiceInterruption = Plugin.ConfigFile.Bind(
                "General",
                "VoiceInterruption",
                false,
                "스토리에서 다음 무음 텍스트가 재생될 때 현재 캐릭터 음성을 중단할지 여부"
            );
            TitleMovie = Plugin.ConfigFile.Bind(
                "General",
                "TitleMovie",
                true,
                "게임 시작 시 타이틀 애니메이션을 재생할지 여부"
            );
            #endregion

            #region Translation
            Translation = Plugin.ConfigFile.Bind(
                "Translation",
                "Enabled",
                true,
                "게임 내 스토리 번역을 활성화할지 여부"
            );
            TranslationCDN = Plugin.ConfigFile.Bind(
                "Translation",
                "CDN",
                "https://raw.githubusercontent.com/ddojuki-creator/dot-abyss-korean/refs/heads/main/translations",
                "번역 데이터를 불러올 CDN 주소"
            );
            TranslationLanguage = Plugin.ConfigFile.Bind(
                "Translation",
                "Language",
                "ko_KR",
                "번역 언어. 한국어는 ko_KR"
            );
            TranslationCryptoTag = Plugin.ConfigFile.Bind(
                "Translation.Crypto",
                "Tag",
                "ENC:",
                "번역 텍스트 암호화 태그(선택)"
            );
            TranslationCryptoKey = Plugin.ConfigFile.Bind(
                "Translation.Crypto",
                "Key",
                "woshitonghuadawang",
                "번역 텍스트 복호화 키(선택)"
            );
            #endregion

            #region Font
            FontBundlePath = Plugin.ConfigFile.Bind(
                "Translation.Font",
                "AssetBundlePath",
                $"{MyPluginInfo.PLUGIN_GUID}/fonts/ttcuyuanj",
                "TMP 폰트 AssetBundle 경로. 플러그인 폴더 기준 상대 경로나 절대 경로를 사용할 수 있습니다."
            );
            #endregion
        }

        /// <summary>
        /// Binds config change logging.
        /// </summary>
        private static void BindSettingChangedLog()
        {
            Plugin.ConfigFile.SettingChanged += (_, e) =>
            {
                var c = e.ChangedSetting;
                Plugin.Log.LogInfo(
                    $"[{c.Definition.Section}] {c.Definition.Key} => {c.BoxedValue}"
                );
                Toast.Info($"[{c.Definition.Section}]", $"{c.Definition.Key} => {c.BoxedValue}");
            };
        }
    }
}
