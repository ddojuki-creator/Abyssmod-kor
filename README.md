# AbyssMod-kor

> 도트어비스 한국어 번역 MOD

본 저장소는 Windows 플랫폼의 DMM Game Player 버전에 적용되는 AbyssMod 한국어판입니다.

현재 한국어 번역은 제작 중이며, 번역되지 않은 구간은 일본어 원문으로 표시될 수 있습니다. 중국어 번역 데이터는 포함하지 않습니다.

## 기능

- 스토리 번역
- 게임 내 동적 모자이크 비활성화
- 게임 시작 시 볼륨 알림 건너뛰기
- 스토리 캐릭터 음성 끊김 방지
- 게임 시작 시 타이틀 애니메이션 비활성화

## 설치

1. DMM Game Player 버전의 게임을 설치합니다.
2. Releases 페이지에서 최신 `AbyssMod.7z`를 다운로드합니다.
3. 압축 파일을 게임 실행 파일과 같은 폴더에 풉니다.
4. 평소처럼 게임을 실행합니다.

압축 해제 후 구조는 대략 다음과 같습니다.

```text
게임 루트 폴더/
├── 게임.exe
├── winhttp.dll
└── BepInEx/
    ├── core/
    ├── plugins/
    │   └── AbyssMod/
    └── config/
```

처음 실행하면 `BepInEx\config\AbyssMod.cfg` 설정 파일이 생성됩니다.

## 기본 설정

한국어판 기본 번역 설정은 다음과 같습니다.

```ini
[Translation]
Enabled = true
CDN = https://raw.githubusercontent.com/ddojuki-creator/dot-abyss-korean/refs/heads/main/translations
Language = ko_KR
```

번역 데이터는 별도 저장소에서 관리합니다.

- https://github.com/ddojuki-creator/dot-abyss-korean

## 설정 항목

### General

| 항목 | 기본값 | 설명 |
| --- | --- | --- |
| `DynamicMosaic` | `false` | 게임 내 동적 모자이크를 활성화할지 여부 |
| `SoundCaution` | `false` | 게임 시작 시 볼륨 알림 팝업을 표시할지 여부 |
| `VoiceInterruption` | `false` | 스토리에서 다음 무음 텍스트가 재생될 때 현재 캐릭터 음성을 중단할지 여부 |
| `TitleMovie` | `true` | 게임 시작 시 타이틀 애니메이션을 재생할지 여부 |

### Translation

| 항목 | 기본값 | 설명 |
| --- | --- | --- |
| `Enabled` | `true` | 게임 내 스토리 번역을 활성화할지 여부 |
| `CDN` | `https://raw.githubusercontent.com/ddojuki-creator/dot-abyss-korean/refs/heads/main/translations` | 번역 데이터를 불러올 CDN 주소 |
| `Language` | `ko_KR` | 번역 언어 |

### Translation.Font

| 항목 | 기본값 | 설명 |
| --- | --- | --- |
| `AssetBundlePath` | `AbyssMod/fonts/ttcuyuanj` | TMP 폰트 AssetBundle 경로 |

## 단축키

| 단축키 | 기능 |
| --- | --- |
| `F8` | 스토리 번역 켜기/끄기 |
| `F9` | 음성 끊김 켜기/끄기 |
| `F10` | 설정 파일 핫 리로드 |

## 중국어가 표시될 때

한국어판을 처음 설치했는데 중국어가 표시되면 아래를 먼저 확인하세요.

1. `BepInEx\config\AbyssMod.cfg`에서 `CDN`이 한국어 번역 저장소를 가리키는지 확인합니다.
2. `Language = ko_KR`인지 확인합니다.
3. 기존 중국어판 DLL이나 이전 `AbyssMod` 폴더가 남아 있지 않은지 확인합니다.
4. `BepInEx\plugins\AbyssMod\cache` 폴더가 있다면 삭제 후 다시 실행합니다.

번역되지 않은 구간이 일본어로 보이는 것은 정상입니다. 아직 한국어 번역이 완료되지 않은 파일입니다.
