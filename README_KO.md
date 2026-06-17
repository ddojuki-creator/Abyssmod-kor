# AbyssMod Korean Setup

이 작업본은 번역 언어 기본값을 `ko_KR`로 둡니다.

## 설정

`BepInEx/config/AbyssMod.cfg`:

```ini
[Translation]
Enabled = true
CDN = https://raw.githubusercontent.com/ddojuki-creator/dot-abyss-korean/refs/heads/main/translations
Language = ko_KR
```

로컬 CDN으로 테스트하려면 번역 저장소에서 서버를 실행한 뒤 `CDN = http://localhost:12315`로 바꾸면 됩니다.

```powershell
cd C:\Users\tl3001\Downloads\AbyssMod-main\dotabyss-translation-main
npm run start
```

배포 기본 CDN:

```text
https://raw.githubusercontent.com/ddojuki-creator/dot-abyss-korean/refs/heads/main/translations
```

## 번역 파일 규칙

JSON key는 게임 원문이므로 절대 바꾸지 않습니다.

```json
{
    "あー、本当にいいのか？": "아, 정말 괜찮겠어?"
}
```

`<br>`, `<user>`, `%user%`, HTML 태그, 특수기호는 보존해야 합니다.
