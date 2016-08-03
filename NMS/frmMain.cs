//Ver 1.00(2011년 03월 02일 ~
//
//Ver 1.01(2011년 06월 14일 ~
//  1. 해상도 변경(1920 * 1080)
//
//Ver 1.02(2011년 06월 20일 ~
//  1. 화면 변경
//
//--2011년 06월 23일--
//  2. MU/RU 이름 설정
//
//Ver 1.03(2011년 06월 25일 ~
//  1. CCE Test Panel로 부터 수신된 Data 표시
//
//Ver 1.04(2011년 06월 28일 ~
//  1. NMS의 현재 상태를 CCE Test Panel(Ver 1.02)로 송신
//     - CCE Test Panel에서도 NMS의 현재 상황을 알수있도록 함.
//
//  2. 회선 시험 기능/패킷 추가
//  3. 시간 동기화 기능/패킷 추가
//  4. 각 MU의 채널및 PTT 상태정보 송신 기능/패킷 추가
//
//Ver 1.05(2011년 07월 06일 ~
//  1. MU 화면 변경
//  2. 회선시험 관련 기능 수정
//     - 시험 시작/중지 로그 남김
//     - 프로그램 시작시 회선시험 역사 기본으로 동익산 선택되도록 수정..
//     - 시험 안할경우 레벨 없앰
//
//  3. 회선시험중인 기지국 번호 송신 기능/패킷 추가
//     - 각 MU의 채널 및 PTT 상태정보 송신하는 Data에 회선시험중인 기지국 번호 1byte 추가
//
//Ver 1.06(2011년 07월 11일 ~
//  1. DB 기능 추가
//
//Ver 1.07(2011년 08월 08일 ~
//
//--2011년 09월 07일--
//  1. 초기화면 추가
//     - 전라선 노선도(MU 통화권 - MU와 RU를 동시에 표시)로 초기화면 꾸밀수 있도록 수정
//     - RC 통화권 으로 초기화면 꾸밀수 있도록 수정
//
//--2011년 09월 15일--
//  2. MU/RU 송신출력값을 W로 표현하기위해 Table 적용
//
//--2011년 09월 16일--
//  3. RC 통화권의 현재 상태 표시하도록 수정
//  4. 송신 출력시험시 상태표시 메세지 수정.
//
//Ver 1.08(2011년 09월 19일 ~
//  1. 전라선 배포로 인한 버젼업
//  2. 현재 MU의 Data 수신시 Error 발생여부를 확인후 표시하는데..
//     UPS의 Data 수신시에도 UPS Error 발생여부를 확인하고 표시하도록 수정함.
//
//  3. 장애이력 검색에 RU 장애에 대한 내용 검색 기능 추가.
//
//Ver 1.09(2011년 10월 24일 ~
//  1. 중앙선에서 사용할수 있도록 수정
//
//  2. RU상세 화면의 변화
//     - BDA1~3의 상태를 표시하도록 수정함.
//     - BDA는 현재까지 중앙선에만 있으므로 전라선과 중앙선의 화면에 맞게 위치 조정함.
//
///  3. MU상세 화면의 STBY TRANSCEIVER의 상태를 표시안한다.
//     - MU의 Error검출시에도 STBY TRANSCEIVER의 상태를 Check안한다.
//     - 이는 중앙선에만 적용하므로 전라선과 중앙선의 경우를 구분하여 현장에 맞게 동작하도록 수정함.
//
//  4. MU상세 화면의 송/수신부 감시상태의 MU 예비장치 표시 안함.
//     - 이는 중앙선에만 적용하므로 전라선과 중앙선의 경우를 구분하여 현장에 맞게 동작하도록 수정함.
//
//  5. UPS 표시 안함
//     - 이는 중앙선에만 적용하므로 전라선과 중앙선의 경우를 구분하여 현장에 맞게 동작하도록 수정함.
//
//Ver 1.10(2011년 11월 14일 ~
//  1. 경춘선에서 사용할수 있도록 수정
//
//  2. 각 해상도에 맞게 화면이 변경하도록 수정함.
//     - 1920 * 1080 : 전라선, 중앙선
//     - 1280 * 1024 : 경춘선
//
//--2011년 11월 17일--
//  3. BDA 관련 프로토콜 추가
//
//Ver 1.11(2011년 11월 21일 ~
//  1. 통신이 되지 않으면 비활성화 시키던것을 버튼 색으로 표시. 통신이 되면 정상(녹색)/이상(적색)으로 표시됨.
//  2. 통신이 되지 않더라고 세부항목으로 들어갈수 있도록 수정. 통신이 안될경우 세부항목을 비활성화 시킴.
//  3. MU/RC 통화권에 BDA 추가하여 표시
//  
//--2011년 11월 22일--
//  4. 화면 수정
//     - MU화면의 "AF Gain 정보 및 제어"를 설정창으로 이동.
//     - RU의 "BDA 초기화 설정"을 설정창으로 이동
//     - MU/RU 화면 변경
//     - 전체 MU화면 사용안함(버튼 숨김)
//     - RC통화권 감시화면 사용안함(버튼 숨김)
//     - 회선시험 기능 사용안함(버튼 숨김)
//     - 주화면에 주장치(구로, 대전, NMS) 상태 표시 안함.(사용자 정의 컨트롤 숨김) - 하단의 메뉴버튼으로 대체함.
//
//  5. BDA 이름 설정 기능 추가
//
//--2011년 11월 24일--
//  6. 위로 올라갈때의 버그 수정. 설정화면,이력화면,회선시험 화면등에서 위로 버튼 Click시 버그 발생. 이를 수정함.
//
//  7. BDA 관련 패킷추가
//     - b : BDA 통신상태(GUI <- RU)
//     - v : BDA Setup 상태 요청/응답(GUI <-> RU)
//     - w : BDA Setup 설정 요청(GUI -> RU)
//     - f : BDA 주파수 설정(GUI -> RU)
//
//--2011년 11월 28일--
//  8. BDA 관련 Database 작업.
//     - BDA Table 추가
//
//  9. FM 관련 Database 작업.
//     - MU/RU Table에 FM_Power/FM_RF 필드 추가
//
//  10. BDA/FM관련 장애이력 저장 및 조회 기능 추가
//
//Ver 1.12(2011년 11월 28일 ~
//  1. MU/RU 상세화면을 제외한 기타화면 디자인 변경.
//
//--2011년 11월 29일--
//  10. FM 관련해서 장애를 표시할수 있도록 수정
//
//  11. BDA의 통신 체크 주기를 5분(300초)으로 늘임.
//
//  12. 설정화면으로 이동시 비밀번호 Check하여 이동함.
//
//Ver 1.13(2011년 11월 29일 ~
//  1. 화면의 컨트롤들을 사용자 정의 컨트롤로 변경
//     - MU 상세 화면
//     - MU 상세 화면의 FM
//     - MU 상세 화면의 UPS
//
//--2011년 11월 30일--
//     - RU 상세 화면
//     - RU 상세 화면의 FM
//     - RU 상세 화면의 BDA
//
//Ver 1.14(2011년 11월 30일 ~
//  1. 전라선/중앙선에도 사용할수 있도록 화면 적용
//     - MU 상세화면 변경
//
//--2011년 12월 01일--
//     - RU 상세화면 변경
//
//--2011년 12월 12일--
//  * 장흥봉부장/이수봉차장의 요청으로 변경
//  1. MU의 무전기 형식 변경할수 없도록 수정. 추후 설정화면에서 변경가능하도록 함. MU화면에서는 무전기 형식을 확인만 할수있음.
//  2. UPS의 상태를 입력전원/밧데리/Bypass/UPS Fail만 표시
//
//--2011년 12월 13일--
//  3. 서빙고역의 경춘선 NMS 배포
//
//Ver 1.15(2011년 12월 14일 ~
//  * 계속되는 현장에서의 수정으로 버젼 업..
//  1. MU/RU FM 사용 여부 변수 추가.
//     - RU FM은 초기화시 True로 초기화함.
//     - MU는 코딩으로 초기화함.
//     - 추후 MU/RU FM 사용여부를 설정화면에서 설정할수 있도록 수정해야함.
//     - 지금은 현장에서 수정함으로 코딩으로 초기화 시킴.
//
//  2. MU 송신출력값이 0이 아니면 송신에 점등시킴.
//  3. RU PTT OFF이면 송신출력값을 0.0으로 표시함.
//  4. MU/RU 자동인데 예비이면 Error 표시.
//  5. MU/RU 자동일경우 주/예비 절체 안되도록 수정.
//
//Ver 1.16(2011년 12월 16일 ~
//  * 마석 NMS 배포로 인한 버젼업..
//
//  1. CCE Test Panel로 채널정보 송신시 채널 - 1의 Data로 송신(1~4채널) - CCP Ver 1.04와 같이 처리
//
//--2011년 12월 23일--
//  2. 경춘선일경우 채널복귀시간 비활성화 시킴.
//  3. 채널정보표시 변경(없는 채널일경우 무조건 1채널로 표시)
//  4. BDA의 FM/VHF값 표시방법 변경( 값이 20보다 작으면 20으로 33보다 크면 33으로 표시 )
//  5. 설정화면의 BDA 관련 설정 숨김
//
//Ver 1.17(2012년 01월 04일 ~
//  * 마석/서빙고 NMS 배포로 인한 버젼업..
//
//  * 마석현장에서 수정
//  1. BDA의 UPS상태중 Bypass상태를 항상 정상으로 표시하도록 수정함.
//
//--2012년 01월 05일--
//  2. MU의 UPS상태중 Bypass상태를 항상 정상으로 표시하도록 수정함.
//     - Error 처리 안함.
//
//Ver 1.18(2012년 01월 06일 ~
//  * 마석/서빙고 NMS 배포로 인한 버젼업..
//
//  * 마석현장에서 수정
//  1. BDA의 UPS관련 Error 처리하지 않았던것을 다시 Error처리하도록 수정함.
//
//  2. BDA의 FM/VHF값 표시방법 변경
//     - 1 ~ 23 => 24, 24 ~ 29 => 24 ~ 29, 30 ~ 98 => 29, 99 => 30
//
//Ver 1.19(2012년 01월 19일 ~
//  * 전라선 순천 현장에서 수정
//
//  1. 전체 MU 감시화면을 경보 설정화면으로 변경(개조).
//     - 사용자 정의 컨트롤 stationSt를 변경하여 경보설정/해제 기능으로 사용함.
//     - 설정 버튼 반으로 줄이고 전체 MU 감시화면 버튼을 경보설정 버튼으로 변경하여 설정 버튼 위에 위치시킴.
//
//  2. 통신 감시시간을 1분에서 5분으로 늘임.
//
//  3. MU의 주/예비 있는지 없는지를 체크하여(clsCommon.flagSpare[]:True-예비있음, False-예비없음)
//     예비가 없을경우 MU 상태표시와 Error 검출시 예비에 관련된 항목은 제외 시킴.
//
//  4. MU/RU의 데이터 통신 Error/복구시 운용이력에 저장시킴.
//
//--2012년 01월 05일--
//  5. 통신 감시시간을 5분에서 10분으로 늘임.
//
//  6. 각 MU의 AF Gain값 요청하지 않도록 수정함.(NMS 주장치에 접속시, 날자변경시 AF Gain값을 요청했었는데 이를 요청하지 않도록 수정함.)
//
//Ver 1.20(2012년 01월 27일 ~
//  1. 전라선의 RC 통화개통도 변경으로 인한 버젼업
//
//  2. NMS주장치로부터 일정시간 Data를 수신하지 못하면 재접속 하도록 수정함.
//
//Ver 1.21(2012년 04월 12일 ~
//  1. 경춘선의 무전기를 신형으로 바꾸면서 막았던 기능을 풀어준다.
//     - PTT 제어 표시
//     - 채널정보 표시
//     - 주/예비/감청 통신 Error 상태 표시
//       (주 통신 상태 표시시 RF 출력값이 18이상 또는 7이하면 주통신 Error 처리함.)
//     - PLL Lock 상태 표시
//
//  2. RU의 BDA 화면 변경(크기를 키우고 RU화면에 3개만 표시함.)
//     - BDA에 VHF RX가 추가되고 이는 RU의 RSSI값을 표시함.(모든 BDA의 VHF RX에 RSSI값을 표시함)
//
//  3. Database 파일을 날자별로 저장하도록 수정.
//     - 검색시도 날자별로 검색하도록 수정함.
//
//--2012년 04월 16일--
//  4. MU/RU의 송신 출력값을 -20해서 표시하던것을 정상으로 회복시킴.
//
//--2012년 04월 19일--
//  5. PTT가 잡히지 않으면 출력값을 0으로 표시 및 저장한다.
//
//--2012년 04월 20일--
//  6. MU의 무선수신기 용어 변경(MONITOR RECEIVER => 수신기 통신 장애)
//
//  7. MU/RU의 출력설정할값 단위를 Set로 변경
//
//Ver 1.22(2012년 04월 23일 ~
//  1. BDA 관련 장애발생시 30분이상 장애 지속시에만 장애를 표시한다.
//     - 김영훈 과장의 요청으로 수정함.
//
//Ver 1.23(2012년 04월 23일 ~
//  1. BDA Gain값 저장 및 검색하도록 수정함.(경춘선만 적용)
//     - 이전 버젼에는 DB에 BDA 고장 정보만 저장할수 있었음. Gain값을 저장할수 있도록 DB정보를 추가함.
//
//  2. 사용하지 않는 장애목록 표시 안함.(경춘선만 적용)
//     - 예비에 관한 목록 표시하지 않음.
//
//Ver 1.24(2012년 08월 29일 ~
//  1. 중앙선 현장(양평역)에서 작업
//
//Ver 1.25(2012년 09월 10일 ~
//  * 전라선 현장(순천역)에서 작업
//
//  1. 변경된 RC 통화권 적용
//  2. 구로/대전/NMS주장치 상태를 메뉴부분으로 내리고 MU통화권 화면을 늘임
//
//Ver 1.26(2012년 09월 12일 ~
//  * 전라선 현장(순천역)에서 작업
//
//  1. Network 접속이 원할하지 않는 경우가 자주발생
//     - 신뢰성 있은 대구 2호선에서 사용했던 Client Socket을 재사용하도록 수정함.
//
//Ver 1.27(2012년 11월 02일 ~
//  1. 중앙선 화면 조정
//     - Ver 1.25에서 좌측에 있던 주장치 상태 매뉴를 내리고 MU 통화권 화면을 늘임으로 인한 변경
//     - MU 통화권 화면 조정
//     - RC 통화권 화면 조정
//
//  2. 중앙선에 소스텔의 FM 영역 추가
//     - 화면에 FM 관련 항목 입력(Ver 1.24에서 작업함)
//     - FM 관련 통신부분 작업
//     - FM 관련 DB 작업(Data 저장/삭제/검색 기능)
//
//--2012년 11월 12일--
//  * 전라선 현장(익산역)에에 작업
//  3. 중앙선의 FM을 표시하지 못해 발생하는 Error 해결..
//
//Ver 1.28(2012년 11월 19일 ~
//  1. 중앙선에 소스텔의 FM 수정
//     - 모장치, 자장치 구분하여 표시
//
//  2. 소스텔의 BDA 영역 추가
//     - 화면에 BDA 관련 항목 입력
//     - BDA 관련 통신부분 작업
//     - BDA 관련 DB 작업
//
//--2012년 11월 27일--
//  3. 주/예비/감청 통신 Error Check방법 변경
//     - 주/예비/감청 통신 Error가 올라올경우 바로 처리하지 않고 일정시간동안 Error 상태가 유지될 경우만 Error 처리하도록 수정함.
//
//--2012년 11월 28일--
//  4. MU/RU 동일한 데이터 5번 수신시 1번 DB에 저장하도록 수정함.
//     - 수신되는 Data의 양이 많아 DB 관리의 어려움이 있음.
//       rf출력값이나 수신레벨, AC/DC 전원값의 변화는 Check하지 않고
//       중요한 Error만 Check해서 변화된것이 있으면 저장하고 없으면 5번에 1번씩 저장하도록 수정함.
//
//Ver 1.29(2012년 11월 29일 ~
//  * 양평역 현장에서 수정
//  5. FM 유무를 설정할수 있도록 수정..
//     - 설정에서 FM 유무를 설정후 FM 유무에 따라 통신 이상/복구 메세지
//
//--2012년 12월 04일--
//  6. 소스텔의 BDA 정보 추가
//     - VHF/UHF의 AMP Error(Bypass Mode) 정보추가
//     - VHF/UHF의 PTT1 ON/OFF(sence1값을 읽어 300이하면 PTT OFF, 300이상이면 PTT ON 처리) 정보추가
//     - VHF/UHF의 PTT2 ON/OFF(sence2값을 읽어 300이하면 PTT OFF, 300이상이면 PTT ON 처리) 정보추가
//     - 이에 따른 DB 작업, DBMS작업, 장애내역 수정작업, NMS 화면 수정 작업
//
//--2012년 12월 14일--
//  * 양평역 현장에서 수정
//  7. MU/RU 화면의 왼쪽의 RU 상태
//     - 주/예비 표시, Error 표시 - 실시간으로 표시 되도록 수정함.
//
//  8. 장애이력검색시 필요없는 장애내역 검색 제외시킴.
//
//  9. 장애이력 엑셀 파일로 저장기능 추가
//
//Ver 1.30(2012년 12월 18일 ~
//  * 경춘선 마석역 현장에서 수정
//  1. 패킷순서 변경
//     - 기타상태의 위치를 14번째(optMonSt)에서 15번째(optOtherSt)의 Bit 5,6,7로 이동(TRX CPU, OPT CPU, UPS 연결)
//
//  2. 경춘선의 BDA 통신Error Check 하지 않도록 수정.
//     - 경춘선은  통신에러를 Check항목이 있으므로 NMS프로그램에서 별도로 통신 Check 하지 않는다.
//
//  3. BDA 초기화 기능추가(자동/수동)
//     - BDA 초기화시 BDA 주파수 변경 패킷을 송신한다.
//     - 설정에 BDA 초기화 주기 시간을 설정할수 있도록 추가.
//     - 설정시간이 되면 모든 BDA를 초기화 시킴.
//
//  4. OPT CPU Error는 RU가 있는곳만 처리하고 RU가 없는곳은 정상처리한다.
//     - RU가 없는곳은 OPT를 읽을수 없으므로 Error 처리되어 올라온다. 이를 정상으로 처리하도록 수정함.
//
//  5. FM 유무를 설정할수 있도록 수정..
//     - 중앙선에서 적용한것을 경춘선에도 적용
//
//--2012년 12월 23일--
//  6. 경춘선의 경우 프로그램 시작시 모든 BDA의 상태를 조회하도록 수정.
//
//  7. 경춘선의 경우 BDA 초기화시 화면뿐 아니라 통신 Error Check flag도 초기화 시킴.
//
//  8. BDA의 출력값을 가공하지 않고 현시시킴..
//     - 11시15분 박영만 부장의 지시..
//
//--2012년 12월 24일--
//  9. Ver 1.22에서 김영훈과장의 요청으로 BDA 관련 장애발생시 30분이상 장애 지속시에만 장애표시하도록 한것을 실시간으로 표시하도록 수정함.
//
//Ver 1.31(2013년 01월 05일 ~
//  1. 분당/중앙선 작업하면서 나온 버그들 수정
//
//--2013년 06월 26일--
//  2. 2011년 12월 23일 작업내용 : 경춘선일경우 채널복귀시간 비활성화 시킴.
//     => 채널복귀시간 활성화 시킴.
//
//Ver 1.32(2013년 08월 05일 ~
//  1. 검색시 특정 오류 하나만 선택하여 검색하도록 수정함.
//
//ver 1.33 (2016년 08월 03일 
//  1. 중앙선에 서원주에 RU가 2대 추가된다고 해서 프로그램을 수정함.
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Collections;

namespace NMS
{
    public partial class frmMain : Form
    {
        #region 폼 관련 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private frmDebug frmDG = null;

        private frmPassword frmPW = null;
        private int pwApplyIndex = 0;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion 폼 관련 변수

        #region 컨트롤 배열 정의
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<Label> lblConnected = new List<Label>();
        private List<Label> lblRX = new List<Label>();
        private List<Label> lblTX = new List<Label>();

        private List<Label> lblCCEErrSt = new List<Label>();

        private List<GroupBox> gbFaultInfo = new List<GroupBox>();
        private List<Button> btMenu = new List<Button>();

        #region 전체감시화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<Button> btMainApparatus = new List<Button>();

        private List<stationSt> MainMachineSt = new List<stationSt>();

        private List<stationSt> StationSt = new List<stationSt>();

        //MU 통화권 감시화면 관련
        private List<Button> btMuStation = new List<Button>();
        private Button[,] btRuStation = new Button[24, 4];
        private List<Button> btMuBda = new List<Button>();

        //RC 통화권 감시화면 관련
        private List<Button> btRcStation = new List<Button>();
        private List<Button> btRc = new List<Button>();

        private List<Bitmap> rcBitMap = new List<Bitmap>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 주장치 감시화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<GroupBox> gbView = new List<GroupBox>();
        private List<Panel> panelView = new List<Panel>();

        #region Main 화면의 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<Button> btMPU = new List<Button>();
        private List<PictureBox> pbMPU = new List<PictureBox>();
        private List<Button> btPower = new List<Button>();

        private List<Button> btCCP = new List<Button>();
        private List<Button> btConsole = new List<Button>();
        private List<Button> btBase = new List<Button>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Console I/F 화면의 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<Button> btConsoleSub = new List<Button>();

        private List<PictureBox> pbConsoleOtherSt = new List<PictureBox>();

        private List<Label> lblConsoleGain = new List<Label>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Broad I/F 화면의 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<PictureBox> pbBroadEnable = new List<PictureBox>();
        private List<PictureBox> pbBroadPtt = new List<PictureBox>();

        private List<Label> lblBroadGain = new List<Label>();

        private List<Label> lblBroadSelSt1 = new List<Label>();
        private List<Label> lblBroadSelSt2 = new List<Label>();
        private List<Label> lblBroadSelSt3 = new List<Label>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Base I/F 화면의 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<Button> btBaseSub = new List<Button>();

        private List<PictureBox> pbBaseOtherSt = new List<PictureBox>();

        private List<Label> lblBaseGain = new List<Label>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region MU감시화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<RuSt> ruSt1 = new List<RuSt>();

        //AF Gain 관련
        private List<GroupBox> gbAfGainRc = new List<GroupBox>();

        private List<Label> lblCCEAfGain = new List<Label>();
        private List<Label> lblRC1AfGain = new List<Label>();
        private List<Label> lblRC2AfGain = new List<Label>();
        private List<Label> lblRC3AfGain = new List<Label>();

        private List<TextBox> tbCCEAfGain = new List<TextBox>();
        private List<TextBox> tbRC1AfGain = new List<TextBox>();
        private List<TextBox> tbRC2AfGain = new List<TextBox>();
        private List<TextBox> tbRC3AfGain = new List<TextBox>();

        private List<Button> btAfGainSet = new List<Button>();                
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region RU감시화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<RuSt> ruSt2 = new List<RuSt>();
        private List<ucBDA> bdaSt = new List<ucBDA>();

        private List<CheckBox> chkBDAEnable = new List<CheckBox>();     //BDA Enable CheckBox
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 설정화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<RadioButton> rbBDAFreq = new List<RadioButton>();

        private List<TextBox> tbRuName = new List<TextBox>();
        private List<TextBox> tbRcName = new List<TextBox>();
        private List<TextBox> tbBdaName = new List<TextBox>();

        private List<CheckBox> chkRuFm = new List<CheckBox>();

        private List<TextBox> tbCCEIP = new List<TextBox>();
        private List<TextBox> tbCCEPort = new List<TextBox>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion        

        #region 회선 시험화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<Button> btLineTestMode = new List<Button>();
        private List<Button> btLineTest = new List<Button>();

        private List<PictureBox> pbLineTestTone = new List<PictureBox>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private string thisVer = null;

        private const int faultInfoAll = 0;
        private const int faultInfoMain = 1;
        private const int faultInfoMU = 2;
        private const int faultInfoRU = 3;
        private const int faultInfoSearch = 4;
        private const int faultInfoSetup = 5;
        private const int faultInfoLineTest = 6;
        
        private List<string> stationList = new List<string>();
        private string nowStation = string.Empty;

        private int depth = 0;
        
        #region 설정정보 관련 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private string nmsIP = string.Empty;
        private short nmsPort = 0;

        private int bdaInitCycle = 0;   //BDA 초기화 주기 시간 

        private string bellFile = string.Empty;
        private int bellPlayCycle = 0;

        private bool flagSound = false;

        //CCE Test Panel과 연결될 Network 정보
        private string[] cceIP = new string[2];
        private int[] ccePort = new int[2];
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region NMS 주장치와의 Network 통신에 관한 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private clsNMSMainMachine nmsMainMachine = null;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region MU/RU 상태 저장 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private MURUData[] muruNowData = null;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private CommErrCheck[] commErrCheck = null; //주/예비/감청 통신 Error를 Check하기 위한 변수

        //MU/RU Data 변경된것을 감지하기 위한 변수
        //전라선의 경우 DB에 쌓이는 Data가 너무 커서 똑같은 Data를 몇회 이상 수신시 DB에 저장하도록 하기 위함..
        private MURUDataChange[] mrurDataChange = null;

        private muChPttSt[] muChPtt = new muChPttSt[32];    //각 MU의 채널/PTT 정보를 CCE Test Panel로 송신한다.

        #region CCE Test Panel 관련 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private int cceID = new int();

        private clsCCETestPanel[] cceTestPanel = new clsCCETestPanel[2];    //Network 통신에 관한 변수

        //화면 Index
        private const int gbViewMain = 0;
        private const int gbViewConsole = 1;
        private const int gbViewBroad = 2;
        private const int gbViewBase = 3;

        private int cceDepth = 0;
        
        #region 각 I/F별 상태 저장 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private UseSt[] useSt = new UseSt[2];  //각 I/F 사용 유무

        private CpuSt[] cpuSt = new CpuSt[2];          //CPU 상태 저장 변수
        private CcpSt[,] ccpSt = new CcpSt[2,9];       //CCP 상태 저장 변수
        private ConsoleSt[,] consoleSt = new ConsoleSt[2,9];   //Console I/F 상태 저장 변수
        private BroadSt[] broadSt = new BroadSt[2];    //Broad I/F 상태 저장 변수
        private BaseSt[,] baseSt = new BaseSt[2,30];   //Base I/F 상태 저장 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private int selectedIndex = 0;  //Console I/F, Base I/F를 선택한 Index
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 회선시험 관련 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private byte lineTestCceID = 0;
        private byte lineTestMuID = 0;
        private byte lineTestReserveMode = 0;
        private byte lineTestMode = 0;

        private byte lineTestingUnit = 0;   //회선시험중인 기지국 번호
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Database 관련 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private int day = 0;  //DB 파일을 하루에 하나씩 만든다.
        private nmsDBMS fbDBMS_NMS = null;

        private nmsDBMS searchDBMS = null;  //검색용으로 사용

        private clsStatusListDBMS fbDBMS_StatusListInfo = new clsStatusListDBMS();  //현재 상황 저장

        //검색 관련 변수
        //통신 이력 관련 변수
        public class MuTxRxErxStSearchResult
        {
            public List<byte> codeTxRxErx = new List<byte>();
            public List<String> contentTxRxErx = new List<string>();
            public List<String> chTxRxErx = new List<string>();
            public List<DateTime> startTime = new List<DateTime>();
            public List<DateTime> stopTime = new List<DateTime>();
        }
        private MuTxRxErxStSearchResult[] muTxRxErxResult = null;

        public class MuTxRxErxStSearch
        {
            public short[] cntMuTxRxErx = new short[5];     //각 Tx/Rx/Erx의 갯수
            public bool[] flagMuTxRxErx = new bool[5];
        }

        private MuTxRxErxStSearch[] muTxRxErx = null;

        //장애 이력 관련 변수
        public class MuErrorStSearchResult
        {
            public List<byte> errCode = new List<byte>();
            public List<DateTime> errDateTime = new List<DateTime>();
            public List<String> errContent = new List<string>();
        }
        private MuErrorStSearchResult[] muErrResult = null;

        public class MuErrorStSearch
        {
            public short[] cntErr = new short[28];      //각 Error의 갯수
            public bool[] flagErr = new bool[28];
        }
        private MuErrorStSearch[] muErr = null;

        private MuErrorStSearchResult[,] ruErrResult = null;
        private MuErrorStSearch[,] ruErr = null;

        private MuErrorStSearchResult[,,] bdaErrResult = null;
        private MuErrorStSearch[, ,] bdaErr = null;

        private MuErrorStSearchResult[] muFmErrResult = null;
        private MuErrorStSearch[] muFmErr = null;

        private MuErrorStSearchResult[,] ruFmErrResult = null;
        private MuErrorStSearch[,] ruFmErr = null;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 기타 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //RC 버튼의 정보
        private rcButtonInfo[] rcInfo = new rcButtonInfo[14];
        private int cntRC = new int();  //RC 세부화면의 최대 버튼 갯수

        private Color colorSelect = new Color();    //선택 색
        private Color colorError = new Color();    //선택 색
        private Color colorBase = new Color();      //기본 색
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        
        public frmMain()
        {
            StreamReader fr = null;
            int i = 0;

            #region 파일로 부터 설정 정보 읽어오기

            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ReadSettingInformationFromFile();
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region 각 선에 맞는 화면 설정

            InitGUI();

            #endregion

            //컨트롤 배열 초기화
            InitControlArray();

            //장치별 에러 목록 입력
            InputErrorListForDevice();


            thisVer = "Ver 1.32";

            colorSelect = Color.Lime;
            colorError = Color.Red;
            colorBase = Color.Transparent;
            
            this.Text = clsCommon.nmsGUIUser + " NMS  - " + thisVer;

            //ScreenInit();       //해상도에 따른 화면 관리
            
            //NMS 관련 초기화
            NMS_Init();
            
            //주장치 관련 초기화
            CCE_Init();

            btLineTestMode_Click(0);    //회선시험 송신 선택

            SetInput();

            #region Database 관련 초기화 작업
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            day = DateTime.Now.Day;
            NMSDB_Connect();

            //운용정보 저장/검색 관련 DB 초기화
            ImageList dummyImageSearch = new ImageList();
            dummyImageSearch.ImageSize = new System.Drawing.Size(1, 25);

            lvOperationReport.SmallImageList = dummyImageSearch;    //운용정보 ListView의 높이설정

            //통신내역/장애내역 관련 이력 검색
            lvTxRxErxStAllDiaplay.SmallImageList = dummyImageSearch;
            lvMUErrorStAllDiaplay.SmallImageList = dummyImageSearch;
            lvRUErrorStAllDiaplay.SmallImageList = dummyImageSearch;
            lvBDAErrorStAllDiaplay.SmallImageList = dummyImageSearch;

            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    lvOtherSearchBDAResult.SmallImageList = dummyImageSearch;
                    break;

                case "중앙선":
                    lvsourcetelBDAErrorStAllDiaplay.SmallImageList = dummyImageSearch;
                    lvsourcetelFMErrorStAllDiaplay.SmallImageList = dummyImageSearch;
                    lvsourcetelFMChildErrorStAllDiaplay.SmallImageList = dummyImageSearch;
                    break;
            }

            fbDBMS_StatusListInfo.DBConnect(clsCommon.DataBasePath + "statusList.FDB");

            if (clsCommon.nmsGUIUser == "중앙선")
            {
                //장애이력화면에서 필요없는것 안보이게 처리
                lvMUErrorStAllDiaplay.Columns[6].Width = 0;
                lvMUErrorStAllDiaplay.Columns[10].Width = 0;
                lvMUErrorStAllDiaplay.Columns[22].Width = 0;
                lvMUErrorStAllDiaplay.Columns[24].Width = 0;
                lvMUErrorStAllDiaplay.Columns[25].Width = 0;
                lvMUErrorStAllDiaplay.Columns[26].Width = 0;
                lvMUErrorStAllDiaplay.Columns[27].Width = 0;
                lvMUErrorStAllDiaplay.Columns[28].Width = 0;
                lvMUErrorStAllDiaplay.Columns[29].Width = 0;

                lvRUErrorStAllDiaplay.Columns[11].Width = 0;
                lvRUErrorStAllDiaplay.Columns[12].Width = 0;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            depth = faultInfoAll;
            btMenu_Click(faultInfoAll);     //전체감시 화면

            SetVisible(tcCCESearch, false);
            SetVisible(tcNMSSearch, false);

            AddStatus("프로그램을 시작하였습니다.");

            tmrMain.Start();
        }


        #region 파일로 부터 설정 정보 읽어오기
        /// <summary>
        /// 파일로 부터 설정 정보 읽어오기
        /// </summary>
        private void ReadSettingInformationFromFile()
        {
            StreamReader fr = null;
            int i = 0;

            try
            {
                fr = File.OpenText(clsCommon.DefaultPath + "setup.txt");

                clsCommon.tmpVer = fr.ReadLine();      //Version Read

                int tmpVer = clsCommon.VerCheck(clsCommon.tmpVer);

                switch (tmpVer)
                {
                    case 0:     //Ver 1.00
                    case 1:     //Ver 1.01
                    case 2:     //Ver 1.02
                    case 3:     //Ver 1.03
                    case 4:     //Ver 1.04
                    case 5:     //Ver 1.05
                    case 6:     //Ver 1.06
                    case 7:     //Ver 1.07
                    case 8:     //Ver 1.08
                    case 9:     //Ver 1.09
                    case 10:    //Ver 1.10
                    case 11:    //Ver 1.11
                    case 12:    //Ver 1.12
                    case 13:    //Ver 1.13
                    case 14:    //Ver 1.14
                    case 15:    //Ver 1.15
                    case 16:    //Ver 1.16
                    case 17:    //Ver 1.17
                    case 18:    //Ver 1.18
                    case 19:    //Ver 1.19
                    case 20:    //Ver 1.20
                    case 21:    //Ver 1.21
                    case 22:    //Ver 1.22
                    case 23:    //Ver 1.23 ~ 1.28
                    case 24:    //Ver 1.29 ~
                    case 25:    //Ver 1.30 ~
                        clsCommon.nmsGUIUser = fr.ReadLine();     //사용처

                        //NMS 주장치 정보
                        nmsIP = fr.ReadLine();
                        nmsPort = Convert.ToInt16(fr.ReadLine());

                        //경보 관련 정보
                        if (fr.ReadLine() == "True") flagSound = true;  //경보 재생 유무
                        else flagSound = false;
                        bellPlayCycle = Convert.ToInt32(fr.ReadLine());  //경보음 재생 주기
                        bellFile = fr.ReadLine();     //경보음 파일

                        if (tmpVer >= 3)
                        {
                            //CCE Test Panel 정보
                            for (i = 0; i < 2; i++)
                            {
                                cceIP[i] = fr.ReadLine();
                                ccePort[i] = Convert.ToInt16(fr.ReadLine());
                            }
                        }

                        if (tmpVer >= 25)
                        {
                            //BDA 초기화 주기 시간 정보
                            bdaInitCycle = Convert.ToInt16(fr.ReadLine());
                        }
                        break;

                    default:
                        //if (clsCommon.flagLanguage) MessageBox.Show("프로그램 버젼이 맞지 않습니다. 확인후 다시 시도하시기 바랍니다.");
                        //else MessageBox.Show("Program version does not match. Try again after verification.");

                        this.Close();
                        break;
                }
            }
            catch
            {
            }

            fr.Close();
        }
        #endregion

        #region 각 선에 맞는 화면 설정
        /// <summary>
        /// 각 선에 맞는 화면 설정
        /// </summary>
        private void InitGUI()
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "전라선":
                case "중앙선":
                    InitializeComponent();

                    SetVisible(MuFm, false);

                    if (clsCommon.nmsGUIUser == "중앙선")
                    {
                        SetVisible(lvBDAErrorStAllDiaplay, false);
                        SetVisible(lvsourcetelBDAErrorStAllDiaplay, true);
                        SetVisible(MuUps, false);
                    }
                    else
                    {
                        SetVisible(lvBDAErrorStAllDiaplay, false);
                        SetVisible(lvsourcetelBDAErrorStAllDiaplay, false);
                        SetVisible(lvsourcetelFMErrorStAllDiaplay, false);

                        SetText(btMenu2, "경보설정");
                    }
                    break;

                case "경춘선":
                default:
                    InitializeComponent_();

                    SetVisible(lvBDAErrorStAllDiaplay, true);

                    panel_MuName.BackgroundImage = new Bitmap(clsCommon.ImagePath + "RuNameGround.png");
                    panel_RuName.BackgroundImage = new Bitmap(clsCommon.ImagePath + "RuNameGround.png");
                    panelMuRuSt.BackgroundImage = new Bitmap(clsCommon.ImagePath + "Ground_127_718.png");
                    panelRuRuSt.BackgroundImage = new Bitmap(clsCommon.ImagePath + "Ground_127_718.png");
                    break;
            }

            this.DoubleClick += new EventHandler(frmMain_DoubleClick);
        }
        #endregion

        #region 컨트롤 배열 초기화
        private void InitControlArray()
        {

            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<Label> lblConnected = new List<Label>();
            lblConnected.Add(lbl_Connected1); lblConnected.Add(lbl_Connected2); lblConnected.Add(lbl_Connected3);
            //private List<Label> lblRX = new List<Label>();
            lblRX.Add(lbl_RX1); lblRX.Add(lbl_RX2); lblRX.Add(lbl_RX3);
            //private List<Label> lblTX = new List<Label>();
            lblTX.Add(lbl_TX1); lblTX.Add(lbl_TX2); lblTX.Add(lbl_TX3);

            //private List<Label> lblCCEErrSt = new List<Label>();
            lblCCEErrSt.Add(lblCCEErrSt1); lblCCEErrSt.Add(lblCCEErrSt2); lblCCEErrSt.Add(lblCCEErrSt3);

            //private ArrayList gbFaultInfo = new ArrayList();
            gbFaultInfo.Add(gbFaultInfoAll);
            gbFaultInfo.Add(gbFaultInfoMain);
            gbFaultInfo.Add(gbFaultInfoMU);
            gbFaultInfo.Add(gbFaultInfoRU);
            gbFaultInfo.Add(gbFaultInfoSearch);
            gbFaultInfo.Add(gbFaultInfoSetup);
            gbFaultInfo.Add(gbfaultInfoLineTest);

            //private ArrayList btMenu = new ArrayList();
            btMenu.Add(btMenu1); btMenu.Add(btMenu2); btMenu.Add(btMenu3); btMenu.Add(btMenu4); btMenu.Add(btMenu5);
            btMenu.Add(btMenu6); btMenu.Add(btMenu7); btMenu.Add(btMenu8);

            #region 전체감시화면 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //전체감시화면 컨트롤 배열
            //private List<Button> btMainApparatus = new List<Button>();
            btMainApparatus.Add(btMainApparatus1); btMainApparatus.Add(btMainApparatus2); btMainApparatus.Add(btMainApparatus3);

            //private ArrayList MainMachineSt = new ArrayList();
            MainMachineSt.Add(MainMachineSt1); MainMachineSt.Add(MainMachineSt2); MainMachineSt.Add(MainMachineSt3);

            //MU 통화권 감시화면 관련
            //private List<Button> btMuStation = new List<Button>();
            btMuStation.Add(btMuStation1); btMuStation.Add(btMuStation2); btMuStation.Add(btMuStation3); btMuStation.Add(btMuStation4); btMuStation.Add(btMuStation5); btMuStation.Add(btMuStation6);
            btMuStation.Add(btMuStation7); btMuStation.Add(btMuStation8); btMuStation.Add(btMuStation9); btMuStation.Add(btMuStation10); btMuStation.Add(btMuStation11); btMuStation.Add(btMuStation12);
            btMuStation.Add(btMuStation13); btMuStation.Add(btMuStation14); btMuStation.Add(btMuStation15); btMuStation.Add(btMuStation16); btMuStation.Add(btMuStation17); btMuStation.Add(btMuStation18);
            btMuStation.Add(btMuStation19); btMuStation.Add(btMuStation20); btMuStation.Add(btMuStation21); btMuStation.Add(btMuStation22); btMuStation.Add(btMuStation23); btMuStation.Add(btMuStation24);

            //private Button[,] btRuStation = new Button[24, 4];
            btRuStation[0, 0] = btMuStation1_Ru1; btRuStation[0, 1] = btMuStation1_Ru2; btRuStation[0, 2] = btMuStation1_Ru3; btRuStation[0, 3] = btMuStation1_Ru4;
            btRuStation[1, 0] = btMuStation2_Ru1; btRuStation[1, 1] = btMuStation2_Ru2; btRuStation[1, 2] = btMuStation2_Ru3; btRuStation[1, 3] = btMuStation2_Ru4;
            btRuStation[2, 0] = btMuStation3_Ru1; btRuStation[2, 1] = btMuStation3_Ru2; btRuStation[2, 2] = btMuStation3_Ru3; btRuStation[2, 3] = btMuStation3_Ru4;
            btRuStation[3, 0] = btMuStation4_Ru1; btRuStation[3, 1] = btMuStation4_Ru2; btRuStation[3, 2] = btMuStation4_Ru3; btRuStation[3, 3] = btMuStation4_Ru4;
            btRuStation[4, 0] = btMuStation5_Ru1; btRuStation[4, 1] = btMuStation5_Ru2; btRuStation[4, 2] = btMuStation5_Ru3; btRuStation[4, 3] = btMuStation5_Ru4;
            btRuStation[5, 0] = btMuStation6_Ru1; btRuStation[5, 1] = btMuStation6_Ru2; btRuStation[5, 2] = btMuStation6_Ru3; btRuStation[5, 3] = btMuStation6_Ru4;
            btRuStation[6, 0] = btMuStation7_Ru1; btRuStation[6, 1] = btMuStation7_Ru2; btRuStation[6, 2] = btMuStation7_Ru3; btRuStation[6, 3] = btMuStation7_Ru4;
            btRuStation[7, 0] = btMuStation8_Ru1; btRuStation[7, 1] = btMuStation8_Ru2; btRuStation[7, 2] = btMuStation8_Ru3; btRuStation[7, 3] = btMuStation8_Ru4;
            btRuStation[8, 0] = btMuStation9_Ru1; btRuStation[8, 1] = btMuStation9_Ru2; btRuStation[8, 2] = btMuStation9_Ru3; btRuStation[8, 3] = btMuStation9_Ru4;
            btRuStation[9, 0] = btMuStation10_Ru1; btRuStation[9, 1] = btMuStation10_Ru2; btRuStation[9, 2] = btMuStation10_Ru3; btRuStation[9, 3] = btMuStation10_Ru4;
            btRuStation[10, 0] = btMuStation11_Ru1; btRuStation[10, 1] = btMuStation11_Ru2; btRuStation[10, 2] = btMuStation11_Ru3; btRuStation[10, 3] = btMuStation11_Ru4;
            btRuStation[11, 0] = btMuStation12_Ru1; btRuStation[11, 1] = btMuStation12_Ru2; btRuStation[11, 2] = btMuStation12_Ru3; btRuStation[11, 3] = btMuStation12_Ru4;
            btRuStation[12, 0] = btMuStation13_Ru1; btRuStation[12, 1] = btMuStation13_Ru2; btRuStation[12, 2] = btMuStation13_Ru3; btRuStation[12, 3] = btMuStation13_Ru4;
            btRuStation[13, 0] = btMuStation14_Ru1; btRuStation[13, 1] = btMuStation14_Ru2; btRuStation[13, 2] = btMuStation14_Ru3; btRuStation[13, 3] = btMuStation14_Ru4;
            btRuStation[14, 0] = btMuStation15_Ru1; btRuStation[14, 1] = btMuStation15_Ru2; btRuStation[14, 2] = btMuStation15_Ru3; btRuStation[14, 3] = btMuStation15_Ru4;
            btRuStation[15, 0] = btMuStation16_Ru1; btRuStation[15, 1] = btMuStation16_Ru2; btRuStation[15, 2] = btMuStation16_Ru3; btRuStation[15, 3] = btMuStation16_Ru4;
            btRuStation[16, 0] = btMuStation17_Ru1; btRuStation[16, 1] = btMuStation17_Ru2; btRuStation[16, 2] = btMuStation17_Ru3; btRuStation[16, 3] = btMuStation17_Ru4;
            btRuStation[17, 0] = btMuStation18_Ru1; btRuStation[17, 1] = btMuStation18_Ru2; btRuStation[17, 2] = btMuStation18_Ru3; btRuStation[17, 3] = btMuStation18_Ru4;
            btRuStation[18, 0] = btMuStation19_Ru1; btRuStation[18, 1] = btMuStation19_Ru2; btRuStation[18, 2] = btMuStation19_Ru3; btRuStation[18, 3] = btMuStation19_Ru4;
            btRuStation[19, 0] = btMuStation20_Ru1; btRuStation[19, 1] = btMuStation20_Ru2; btRuStation[19, 2] = btMuStation20_Ru3; btRuStation[19, 3] = btMuStation20_Ru4;
            btRuStation[20, 0] = btMuStation21_Ru1; btRuStation[20, 1] = btMuStation21_Ru2; btRuStation[20, 2] = btMuStation21_Ru3; btRuStation[20, 3] = btMuStation21_Ru4;
            btRuStation[21, 0] = btMuStation22_Ru1; btRuStation[21, 1] = btMuStation22_Ru2; btRuStation[21, 2] = btMuStation22_Ru3; btRuStation[21, 3] = btMuStation22_Ru4;
            btRuStation[22, 0] = btMuStation23_Ru1; btRuStation[22, 1] = btMuStation23_Ru2; btRuStation[22, 2] = btMuStation23_Ru3; btRuStation[22, 3] = btMuStation23_Ru4;
            btRuStation[23, 0] = btMuStation24_Ru1; btRuStation[23, 1] = btMuStation24_Ru2; btRuStation[23, 2] = btMuStation24_Ru3; btRuStation[23, 3] = btMuStation24_Ru4;

            //private List<Button> btMuBda = new List<Button>();
            btMuBda.Add(btMuBda1); btMuBda.Add(btMuBda2); btMuBda.Add(btMuBda3); btMuBda.Add(btMuBda4); btMuBda.Add(btMuBda5);
            btMuBda.Add(btMuBda6); btMuBda.Add(btMuBda7); btMuBda.Add(btMuBda8); btMuBda.Add(btMuBda9); btMuBda.Add(btMuBda10);
            btMuBda.Add(btMuBda11); btMuBda.Add(btMuBda12); btMuBda.Add(btMuBda13); btMuBda.Add(btMuBda14); btMuBda.Add(btMuBda15);
            btMuBda.Add(btMuBda16); btMuBda.Add(btMuBda17); btMuBda.Add(btMuBda18); btMuBda.Add(btMuBda19); btMuBda.Add(btMuBda20);

            //RC 통화권 감시화면 관련
            //private List<Button> btRcStation = new List<Button>();
            btRcStation.Add(btRcStation1); btRcStation.Add(btRcStation2); btRcStation.Add(btRcStation3); btRcStation.Add(btRcStation4); btRcStation.Add(btRcStation5);
            btRcStation.Add(btRcStation6); btRcStation.Add(btRcStation7); btRcStation.Add(btRcStation8); btRcStation.Add(btRcStation9); btRcStation.Add(btRcStation10);
            btRcStation.Add(btRcStation11); btRcStation.Add(btRcStation12); btRcStation.Add(btRcStation13); btRcStation.Add(btRcStation14); btRcStation.Add(btRcStation15);

            //private List<Button> btRc = new List<Button>();
            btRc.Add(btRC1); btRc.Add(btRC2); btRc.Add(btRC3); btRc.Add(btRC4); btRc.Add(btRC5);
            btRc.Add(btRC6); btRc.Add(btRC7); btRc.Add(btRC8); btRc.Add(btRC9); btRc.Add(btRC10);
            btRc.Add(btRC11); btRc.Add(btRC12); btRc.Add(btRC13); btRc.Add(btRC14); btRc.Add(btRC15);
            btRc.Add(btRC16); btRc.Add(btRC17); btRc.Add(btRC18); btRc.Add(btRC19); btRc.Add(btRC20);
            btRc.Add(btRC21); btRc.Add(btRC22); btRc.Add(btRC23); btRc.Add(btRC24);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region 주장치 감시화면 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<GroupBox> gbView = new List<GroupBox>();
            gbView.Add(gbMain); gbView.Add(gbConsole); gbView.Add(gbBroad); gbView.Add(gbBase);

            //private List<Panel> panelView = new List<Panel>();
            panelView.Add(panel_Main); panelView.Add(panel_Console); panelView.Add(panel_Broad); panelView.Add(panel_Base);

            #region Main 화면의 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<Button> btMPU = new List<Button>();
            btMPU.Add(btMPU1); btMPU.Add(btMPU2);
            //private List<PictureBox> pbMPU = new List<PictureBox>();
            pbMPU.Add(pbMPU1); pbMPU.Add(pbMPU2);
            //private List<Button> btPower = new List<Button>();
            btPower.Add(btPW1); btPower.Add(btPW2);

            //private List<Button> btCCP = new List<Button>();
            btCCP.Add(btCCP1); btCCP.Add(btCCP2); btCCP.Add(btCCP3); btCCP.Add(btCCP4); btCCP.Add(btCCP5);
            btCCP.Add(btCCP6); btCCP.Add(btCCP7); btCCP.Add(btCCP8); btCCP.Add(btCCP9);
            //private List<Button> btConsole = new List<Button>();
            btConsole.Add(btConsole1); btConsole.Add(btConsole2); btConsole.Add(btConsole3); btConsole.Add(btConsole4); btConsole.Add(btConsole5);
            btConsole.Add(btConsole6); btConsole.Add(btConsole7); btConsole.Add(btConsole8); btConsole.Add(btConsole9);
            //private List<Button> btBase = new List<Button>();
            btBase.Add(btBase1); btBase.Add(btBase2); btBase.Add(btBase3); btBase.Add(btBase4); btBase.Add(btBase5);
            btBase.Add(btBase6); btBase.Add(btBase7); btBase.Add(btBase8); btBase.Add(btBase9); btBase.Add(btBase10);
            btBase.Add(btBase11); btBase.Add(btBase12); btBase.Add(btBase13); btBase.Add(btBase14); btBase.Add(btBase15);
            btBase.Add(btBase16); btBase.Add(btBase17); btBase.Add(btBase18); btBase.Add(btBase19); btBase.Add(btBase20);
            btBase.Add(btBase21); btBase.Add(btBase22); btBase.Add(btBase23); btBase.Add(btBase24); btBase.Add(btBase25);
            btBase.Add(btBase26); btBase.Add(btBase27); btBase.Add(btBase28); btBase.Add(btBase29); btBase.Add(btBase30);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region Console I/F 화면의 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<Button> btConsoleSub = new List<Button>();
            btConsoleSub.Add(btConsoleSub1); btConsoleSub.Add(btConsoleSub2); btConsoleSub.Add(btConsoleSub3); btConsoleSub.Add(btConsoleSub4); btConsoleSub.Add(btConsoleSub5);
            btConsoleSub.Add(btConsoleSub6); btConsoleSub.Add(btConsoleSub7); btConsoleSub.Add(btConsoleSub8); btConsoleSub.Add(btConsoleSub9);

            //private List<PictureBox> pbConsoleOtherSt = new List<PictureBox>();
            pbConsoleOtherSt.Add(pbConsoleOtherSt1); pbConsoleOtherSt.Add(pbConsoleOtherSt2); pbConsoleOtherSt.Add(pbConsoleOtherSt3);

            //private List<Label> lblConsoleGain = new List<Label>();
            lblConsoleGain.Add(lblConsoleGain1); lblConsoleGain.Add(lblConsoleGain2); lblConsoleGain.Add(lblConsoleGain3); lblConsoleGain.Add(lblConsoleGain4);
            lblConsoleGain.Add(lblConsoleGain5); lblConsoleGain.Add(lblConsoleGain6); lblConsoleGain.Add(lblConsoleGain7); lblConsoleGain.Add(lblConsoleGain8);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region Broad I/F 화면의 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<PictureBox> pbBroadEnable = new List<PictureBox>();
            pbBroadEnable.Add(pbBroadEnable1); pbBroadEnable.Add(pbBroadEnable2); pbBroadEnable.Add(pbBroadEnable3);
            //private List<PictureBox> pbBroadPtt = new List<PictureBox>();
            pbBroadPtt.Add(pbBroadPtt1); pbBroadPtt.Add(pbBroadPtt2); pbBroadPtt.Add(pbBroadPtt3);

            //private List<Label> lblBroadGain = new List<Label>();
            lblBroadGain.Add(lblBroadGain1); lblBroadGain.Add(lblBroadGain2); lblBroadGain.Add(lblBroadGain3); lblBroadGain.Add(lblBroadGain4);

            //private List<Label> lblBroadSelSt1 = new List<Label>();
            lblBroadSelSt1.Add(lblBroadSelSt1_1); lblBroadSelSt1.Add(lblBroadSelSt1_2); lblBroadSelSt1.Add(lblBroadSelSt1_3); lblBroadSelSt1.Add(lblBroadSelSt1_4); lblBroadSelSt1.Add(lblBroadSelSt1_5);
            lblBroadSelSt1.Add(lblBroadSelSt1_6); lblBroadSelSt1.Add(lblBroadSelSt1_7); lblBroadSelSt1.Add(lblBroadSelSt1_8); lblBroadSelSt1.Add(lblBroadSelSt1_9); lblBroadSelSt1.Add(lblBroadSelSt1_10);
            lblBroadSelSt1.Add(lblBroadSelSt1_11); lblBroadSelSt1.Add(lblBroadSelSt1_12); lblBroadSelSt1.Add(lblBroadSelSt1_13); lblBroadSelSt1.Add(lblBroadSelSt1_14); lblBroadSelSt1.Add(lblBroadSelSt1_15);
            lblBroadSelSt1.Add(lblBroadSelSt1_16); lblBroadSelSt1.Add(lblBroadSelSt1_17); lblBroadSelSt1.Add(lblBroadSelSt1_18); lblBroadSelSt1.Add(lblBroadSelSt1_19); lblBroadSelSt1.Add(lblBroadSelSt1_20);
            lblBroadSelSt1.Add(lblBroadSelSt1_21); lblBroadSelSt1.Add(lblBroadSelSt1_22); lblBroadSelSt1.Add(lblBroadSelSt1_23); lblBroadSelSt1.Add(lblBroadSelSt1_24); lblBroadSelSt1.Add(lblBroadSelSt1_25);
            lblBroadSelSt1.Add(lblBroadSelSt1_26); lblBroadSelSt1.Add(lblBroadSelSt1_27); lblBroadSelSt1.Add(lblBroadSelSt1_28); lblBroadSelSt1.Add(lblBroadSelSt1_29); lblBroadSelSt1.Add(lblBroadSelSt1_30);
            //private List<Label> lblBroadSelSt2 = new List<Label>();
            lblBroadSelSt2.Add(lblBroadSelSt2_1); lblBroadSelSt2.Add(lblBroadSelSt2_2); lblBroadSelSt2.Add(lblBroadSelSt2_3); lblBroadSelSt2.Add(lblBroadSelSt2_4); lblBroadSelSt2.Add(lblBroadSelSt2_5);
            lblBroadSelSt2.Add(lblBroadSelSt2_6); lblBroadSelSt2.Add(lblBroadSelSt2_7); lblBroadSelSt2.Add(lblBroadSelSt2_8); lblBroadSelSt2.Add(lblBroadSelSt2_9); lblBroadSelSt2.Add(lblBroadSelSt2_10);
            lblBroadSelSt2.Add(lblBroadSelSt2_11); lblBroadSelSt2.Add(lblBroadSelSt2_12); lblBroadSelSt2.Add(lblBroadSelSt2_13); lblBroadSelSt2.Add(lblBroadSelSt2_14); lblBroadSelSt2.Add(lblBroadSelSt2_15);
            lblBroadSelSt2.Add(lblBroadSelSt2_16); lblBroadSelSt2.Add(lblBroadSelSt2_17); lblBroadSelSt2.Add(lblBroadSelSt2_18); lblBroadSelSt2.Add(lblBroadSelSt2_19); lblBroadSelSt2.Add(lblBroadSelSt2_20);
            lblBroadSelSt2.Add(lblBroadSelSt2_22); lblBroadSelSt2.Add(lblBroadSelSt2_22); lblBroadSelSt2.Add(lblBroadSelSt2_23); lblBroadSelSt2.Add(lblBroadSelSt2_24); lblBroadSelSt2.Add(lblBroadSelSt2_25);
            lblBroadSelSt2.Add(lblBroadSelSt2_26); lblBroadSelSt2.Add(lblBroadSelSt2_27); lblBroadSelSt2.Add(lblBroadSelSt2_28); lblBroadSelSt2.Add(lblBroadSelSt2_29); lblBroadSelSt2.Add(lblBroadSelSt2_30);
            //private List<Label> lblBroadSelSt3 = new List<Label>();
            lblBroadSelSt3.Add(lblBroadSelSt3_1); lblBroadSelSt3.Add(lblBroadSelSt3_2); lblBroadSelSt3.Add(lblBroadSelSt3_3); lblBroadSelSt3.Add(lblBroadSelSt3_4); lblBroadSelSt3.Add(lblBroadSelSt3_5);
            lblBroadSelSt3.Add(lblBroadSelSt3_6); lblBroadSelSt3.Add(lblBroadSelSt3_7); lblBroadSelSt3.Add(lblBroadSelSt3_8); lblBroadSelSt3.Add(lblBroadSelSt3_9); lblBroadSelSt3.Add(lblBroadSelSt3_10);
            lblBroadSelSt3.Add(lblBroadSelSt3_11); lblBroadSelSt3.Add(lblBroadSelSt3_12); lblBroadSelSt3.Add(lblBroadSelSt3_13); lblBroadSelSt3.Add(lblBroadSelSt3_14); lblBroadSelSt3.Add(lblBroadSelSt3_15);
            lblBroadSelSt3.Add(lblBroadSelSt3_16); lblBroadSelSt3.Add(lblBroadSelSt3_17); lblBroadSelSt3.Add(lblBroadSelSt3_18); lblBroadSelSt3.Add(lblBroadSelSt3_19); lblBroadSelSt3.Add(lblBroadSelSt3_20);
            lblBroadSelSt3.Add(lblBroadSelSt3_21); lblBroadSelSt3.Add(lblBroadSelSt3_22); lblBroadSelSt3.Add(lblBroadSelSt3_23); lblBroadSelSt3.Add(lblBroadSelSt3_24); lblBroadSelSt3.Add(lblBroadSelSt3_25);
            lblBroadSelSt3.Add(lblBroadSelSt3_26); lblBroadSelSt3.Add(lblBroadSelSt3_27); lblBroadSelSt3.Add(lblBroadSelSt3_28); lblBroadSelSt3.Add(lblBroadSelSt3_29); lblBroadSelSt3.Add(lblBroadSelSt3_30);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region Base I/F 화면의 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<Button> btBaseSub = new List<Button>();
            btBaseSub.Add(btBaseSub1); btBaseSub.Add(btBaseSub2); btBaseSub.Add(btBaseSub3); btBaseSub.Add(btBaseSub4); btBaseSub.Add(btBaseSub5);
            btBaseSub.Add(btBaseSub6); btBaseSub.Add(btBaseSub7); btBaseSub.Add(btBaseSub8); btBaseSub.Add(btBaseSub9); btBaseSub.Add(btBaseSub10);
            btBaseSub.Add(btBaseSub11); btBaseSub.Add(btBaseSub12); btBaseSub.Add(btBaseSub13); btBaseSub.Add(btBaseSub14); btBaseSub.Add(btBaseSub15);
            btBaseSub.Add(btBaseSub16); btBaseSub.Add(btBaseSub17); btBaseSub.Add(btBaseSub18); btBaseSub.Add(btBaseSub19); btBaseSub.Add(btBaseSub20);
            btBaseSub.Add(btBaseSub21); btBaseSub.Add(btBaseSub22); btBaseSub.Add(btBaseSub23); btBaseSub.Add(btBaseSub24); btBaseSub.Add(btBaseSub25);
            btBaseSub.Add(btBaseSub26); btBaseSub.Add(btBaseSub27); btBaseSub.Add(btBaseSub28); btBaseSub.Add(btBaseSub29); btBaseSub.Add(btBaseSub30);

            //private List<PictureBox> pbBaseOtherSt = new List<PictureBox>();
            pbBaseOtherSt.Add(pbBaseOtherSt1); pbBaseOtherSt.Add(pbBaseOtherSt2); pbBaseOtherSt.Add(pbBaseOtherSt3); pbBaseOtherSt.Add(pbBaseOtherSt4);
            pbBaseOtherSt.Add(pbBaseOtherSt5); pbBaseOtherSt.Add(pbBaseOtherSt6); pbBaseOtherSt.Add(pbBaseOtherSt7);

            //private List<Label> lblBaseGain = new List<Label>();
            lblBaseGain.Add(lblBaseGain1); lblBaseGain.Add(lblBaseGain2); lblBaseGain.Add(lblBaseGain3); lblBaseGain.Add(lblBaseGain4);
            lblBaseGain.Add(lblBaseGain5); lblBaseGain.Add(lblBaseGain6); lblBaseGain.Add(lblBaseGain7); lblBaseGain.Add(lblBaseGain8);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region MU감시화면 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private ArrayList ruSt = new ArrayList();
            ruSt1.Add(ruSt1_1); ruSt1.Add(ruSt1_2); ruSt1.Add(ruSt1_3); ruSt1.Add(ruSt1_4);

            //AF Gain 관련
            //private List<GroupBox> gbAfGainRc = new List<GroupBox>();
            gbAfGainRc.Add(gbAfGainRC1); gbAfGainRc.Add(gbAfGainRC2); gbAfGainRc.Add(gbAfGainRC3); gbAfGainRc.Add(gbAfGainRC4);
            //private ArrayList lblCCEAfGain = new ArrayList();
            lblCCEAfGain.Add(lblCCEAfGain1); lblCCEAfGain.Add(lblCCEAfGain2); lblCCEAfGain.Add(lblCCEAfGain3);
            //private ArrayList lblRC1AfGain = new ArrayList();
            lblRC1AfGain.Add(lblRC1AfGain1); lblRC1AfGain.Add(lblRC1AfGain2); lblRC1AfGain.Add(lblRC1AfGain3);
            //private ArrayList lblRC2AfGain = new ArrayList();
            lblRC2AfGain.Add(lblRC2AfGain1); lblRC2AfGain.Add(lblRC2AfGain2); lblRC2AfGain.Add(lblRC2AfGain3);
            //private ArrayList lblRC2AfGain = new ArrayList();
            lblRC3AfGain.Add(lblRC3AfGain1); lblRC3AfGain.Add(lblRC3AfGain2); lblRC3AfGain.Add(lblRC3AfGain3);

            //private ArrayList tbCCEAfGain = new ArrayList();
            tbCCEAfGain.Add(tbCCEAfGain1); tbCCEAfGain.Add(tbCCEAfGain2); tbCCEAfGain.Add(tbCCEAfGain3);
            //private ArrayList tbRC1AfGain = new ArrayList();
            tbRC1AfGain.Add(tbRC1AfGain1); tbRC1AfGain.Add(tbRC1AfGain2); tbRC1AfGain.Add(tbRC1AfGain3);
            //private ArrayList tbRC2AfGain = new ArrayList();
            tbRC2AfGain.Add(tbRC2AfGain1); tbRC2AfGain.Add(tbRC2AfGain2); tbRC2AfGain.Add(tbRC2AfGain3);
            //private ArrayList tbRC2AfGain = new ArrayList();
            tbRC3AfGain.Add(tbRC3AfGain1); tbRC3AfGain.Add(tbRC3AfGain2); tbRC3AfGain.Add(tbRC3AfGain3);

            //private ArrayList btAfGainSet = new ArrayList();
            btAfGainSet.Add(btAfGainSet1); btAfGainSet.Add(btAfGainSet2); btAfGainSet.Add(btAfGainSet3); btAfGainSet.Add(btAfGainSet4);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region RU감시화면 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private ArrayList ruSt2 = new ArrayList();
            ruSt2.Add(ruSt2_1); ruSt2.Add(ruSt2_2); ruSt2.Add(ruSt2_3); ruSt2.Add(ruSt2_4);

            //private List<ucBDA> bdaSt = new List<ucBDA>();
            bdaSt.Add(ucBDA1); bdaSt.Add(ucBDA2); bdaSt.Add(ucBDA3); bdaSt.Add(ucBDA4);

            //private List<CheckBox> chkBDAEnable = new List<CheckBox>();     //BDA Enable CheckBox
            chkBDAEnable.Add(chkBDAEnable1); chkBDAEnable.Add(chkBDAEnable2); chkBDAEnable.Add(chkBDAEnable3); chkBDAEnable.Add(chkBDAEnable4);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region 설정화면 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<RadioButton> rbBDAFreq = new List<RadioButton>();
            rbBDAFreq.Add(rbBDAFreq1); rbBDAFreq.Add(rbBDAFreq2); rbBDAFreq.Add(rbBDAFreq3); rbBDAFreq.Add(rbBDAFreq4); rbBDAFreq.Add(rbBDAFreq5);

            //private List<TextBox> tbRuName = new List<TextBox>();
            tbRuName.Add(tbRuName1); tbRuName.Add(tbRuName2); tbRuName.Add(tbRuName3); tbRuName.Add(tbRuName4);

            //private List<TextBox> tbRcName = new List<TextBox>();
            tbRcName.Add(tbRcName1); tbRcName.Add(tbRcName2); tbRcName.Add(tbRcName3); tbRcName.Add(tbRcName4);

            //private List<TextBox> tbBdaName = new List<TextBox>();
            tbBdaName.Add(tbBDAName1); tbBdaName.Add(tbBDAName2); tbBdaName.Add(tbBDAName3); tbBdaName.Add(tbBDAName4);

            //private List<CheckBox> chkRuFm = new List<CheckBox>();
            chkRuFm.Add(chkRUFm1); chkRuFm.Add(chkRUFm2); chkRuFm.Add(chkRUFm3); chkRuFm.Add(chkRUFm4);

            //private List<TextBox> tbCCEIP = new List<TextBox>();
            tbCCEIP.Add(tbCCEIP1); tbCCEIP.Add(tbCCEIP2);
            //private List<TextBox> tbCCEPort = new List<TextBox>();
            tbCCEPort.Add(tbCCEPort1); tbCCEPort.Add(tbCCEPort2);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region 회선 시험화면 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<Button> btLineTestMode = new List<Button>();
            btLineTestMode.Add(btLineTestMode1); btLineTestMode.Add(btLineTestMode2); btLineTestMode.Add(btLineTestMode3);
            //private List<Button> btLineTest = new List<Button>();
            btLineTest.Add(btLineTest1); btLineTest.Add(btLineTest2);

            //private List<PictureBox> pbLineTestTone = new List<PictureBox>();
            pbLineTestTone.Add(pbLineTestTone1); pbLineTestTone.Add(pbLineTestTone2); pbLineTestTone.Add(pbLineTestTone3);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        }
        #endregion

        #region 장치별 Error 목록 입력
        private void InputErrorListForDevice()
        {
            int i = 0;


            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 6; i++)
                clsCommon.errContent[i] = new ErrorContent();

            //MU의 Error 목록 입력
            clsCommon.errContent[0].errName.Add("AC");
            clsCommon.errContent[0].errName.Add("DC");
            clsCommon.errContent[0].errName.Add("TrxUnit");
            clsCommon.errContent[0].errName.Add("mainComm");
            clsCommon.errContent[0].errName.Add("stbyComm");
            clsCommon.errContent[0].errName.Add("monComm");
            clsCommon.errContent[0].errName.Add("muTrxCpu");
            clsCommon.errContent[0].errName.Add("muOptCpu");
            clsCommon.errContent[0].errName.Add("muUps");
            clsCommon.errContent[0].errName.Add("optDc");
            clsCommon.errContent[0].errName.Add("optModOpen");
            clsCommon.errContent[0].errName.Add("opt1Ld");
            clsCommon.errContent[0].errName.Add("opt2Ld");
            clsCommon.errContent[0].errName.Add("opt3Ld");
            clsCommon.errContent[0].errName.Add("opt4Ld");
            clsCommon.errContent[0].errName.Add("opt1Pd");
            clsCommon.errContent[0].errName.Add("opt2Pd");
            clsCommon.errContent[0].errName.Add("opt3Pd");
            clsCommon.errContent[0].errName.Add("opt4Pd");
            clsCommon.errContent[0].errName.Add("mainPllLock");
            clsCommon.errContent[0].errName.Add("stbyPllLock");
            clsCommon.errContent[0].errName.Add("monPllLock");
            clsCommon.errContent[0].errName.Add("upsFailed");
            clsCommon.errContent[0].errName.Add("bypass");
            clsCommon.errContent[0].errName.Add("batteryLow");
            clsCommon.errContent[0].errName.Add("utilityFail");
            clsCommon.errContent[0].errName.Add("FM_POWER");
            clsCommon.errContent[0].errName.Add("FM_RF");

            clsCommon.errContent[0].errContent.Add("AC");
            clsCommon.errContent[0].errContent.Add("DC");
            clsCommon.errContent[0].errContent.Add("TRX Unit");
            clsCommon.errContent[0].errContent.Add("주 통신");
            clsCommon.errContent[0].errContent.Add("예비 통신");
            clsCommon.errContent[0].errContent.Add("감청 통신");
            clsCommon.errContent[0].errContent.Add("TRX CPU");
            clsCommon.errContent[0].errContent.Add("OPT CPU");
            clsCommon.errContent[0].errContent.Add("UPS 연결");
            clsCommon.errContent[0].errContent.Add("OPT DC");
            clsCommon.errContent[0].errContent.Add("OPT ModOpen");
            clsCommon.errContent[0].errContent.Add("OPT1 LD");
            clsCommon.errContent[0].errContent.Add("OPT2 LD");
            clsCommon.errContent[0].errContent.Add("OPT3 LD");
            clsCommon.errContent[0].errContent.Add("OPT4 LD");
            clsCommon.errContent[0].errContent.Add("OPT1 PD");
            clsCommon.errContent[0].errContent.Add("OPT2 PD");
            clsCommon.errContent[0].errContent.Add("OPT3 PD");
            clsCommon.errContent[0].errContent.Add("OPT4 PD");
            clsCommon.errContent[0].errContent.Add("주 PLL Lock");
            clsCommon.errContent[0].errContent.Add("예비 PLL Lock");
            clsCommon.errContent[0].errContent.Add("감청  PLL Lock");
            clsCommon.errContent[0].errContent.Add("UPS 입력전원");
            clsCommon.errContent[0].errContent.Add("UPS Bypass");
            clsCommon.errContent[0].errContent.Add("UPS Battery Low");
            clsCommon.errContent[0].errContent.Add("UPS Error");
            clsCommon.errContent[0].errContent.Add("FM Power");
            clsCommon.errContent[0].errContent.Add("FM RF");

            //RU의 Error 목록 입력
            clsCommon.errContent[1].errName.Add("AC");
            clsCommon.errContent[1].errName.Add("DC");
            clsCommon.errContent[1].errName.Add("modOpen");
            clsCommon.errContent[1].errName.Add("ruCpu");
            clsCommon.errContent[1].errName.Add("data");
            clsCommon.errContent[1].errName.Add("optLd");
            clsCommon.errContent[1].errName.Add("xmtrPllLock");
            clsCommon.errContent[1].errName.Add("rcvrpllLock");
            clsCommon.errContent[1].errName.Add("FM_POWER");
            clsCommon.errContent[1].errName.Add("FM_RF");

            clsCommon.errContent[1].errContent.Add("AC");
            clsCommon.errContent[1].errContent.Add("DC");
            clsCommon.errContent[1].errContent.Add("Mod Open");
            clsCommon.errContent[1].errContent.Add("RU CPU");
            clsCommon.errContent[1].errContent.Add("데이터 광접속");
            clsCommon.errContent[1].errContent.Add("OPT LD 알람");
            clsCommon.errContent[1].errContent.Add("Main PA Fault");
            clsCommon.errContent[1].errContent.Add("Stby PA Fault");
            clsCommon.errContent[1].errContent.Add("FM Power");
            clsCommon.errContent[1].errContent.Add("FM RF");

            //BDA의 Error 목록 입력
            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    clsCommon.errContent[2].errName.Add("FM");
                    clsCommon.errContent[2].errName.Add("VHF");
                    clsCommon.errContent[2].errName.Add("DMB");
                    clsCommon.errContent[2].errName.Add("PROTECTION");
                    clsCommon.errContent[2].errName.Add("TRS");
                    clsCommon.errContent[2].errName.Add("DC12V");
                    clsCommon.errContent[2].errName.Add("DC24V");
                    clsCommon.errContent[2].errName.Add("AC220V");
                    clsCommon.errContent[2].errName.Add("COMM");
                    clsCommon.errContent[2].errName.Add("BYPASS");
                    clsCommon.errContent[2].errName.Add("AC");
                    clsCommon.errContent[2].errName.Add("FAIL");
                    clsCommon.errContent[2].errName.Add("BATTERY");

                    clsCommon.errContent[2].errContent.Add("FM");
                    clsCommon.errContent[2].errContent.Add("VHF");
                    clsCommon.errContent[2].errContent.Add("DMB");
                    clsCommon.errContent[2].errContent.Add("방호");
                    clsCommon.errContent[2].errContent.Add("TRS");
                    clsCommon.errContent[2].errContent.Add("12V");
                    clsCommon.errContent[2].errContent.Add("24V");
                    clsCommon.errContent[2].errContent.Add("220V");
                    clsCommon.errContent[2].errContent.Add("통신상태");
                    clsCommon.errContent[2].errContent.Add("UPS Bypass");
                    clsCommon.errContent[2].errContent.Add("UPS AC");
                    clsCommon.errContent[2].errContent.Add("UPS Fail");
                    clsCommon.errContent[2].errContent.Add("UPS Battery");
                    break;

                default:
                    clsCommon.errContent[2].errName.Add("fmAlarm");
                    clsCommon.errContent[2].errName.Add("vhfAmp");
                    clsCommon.errContent[2].errName.Add("vhfAcAlarm");
                    clsCommon.errContent[2].errName.Add("vhfDcAlarm");
                    clsCommon.errContent[2].errName.Add("vhfBatteryAlarm");
                    clsCommon.errContent[2].errName.Add("uhfAmp");
                    clsCommon.errContent[2].errName.Add("uhfAcAlarm");
                    clsCommon.errContent[2].errName.Add("uhfDcAlarm");
                    clsCommon.errContent[2].errName.Add("uhfBatteryAlarm");

                    clsCommon.errContent[2].errContent.Add("FM 알람");
                    clsCommon.errContent[2].errContent.Add("VHF AMP");
                    clsCommon.errContent[2].errContent.Add("VHF AC");
                    clsCommon.errContent[2].errContent.Add("VHF DC");
                    clsCommon.errContent[2].errContent.Add("VHF Battery");
                    clsCommon.errContent[2].errContent.Add("UHF AMP");
                    clsCommon.errContent[2].errContent.Add("UHF AC");
                    clsCommon.errContent[2].errContent.Add("UHF DC");
                    clsCommon.errContent[2].errContent.Add("UHF Battery");
                    break;
            }

            //FM의 Error 목록 입력
            clsCommon.errContent[3].errName.Add("acInputFail");
            clsCommon.errContent[3].errName.Add("lnaFail");
            clsCommon.errContent[3].errName.Add("dcOutputFail");
            clsCommon.errContent[3].errName.Add("ldAlarm");
            clsCommon.errContent[3].errName.Add("pdAlarm");

            clsCommon.errContent[3].errContent.Add("AC Input Fail");
            clsCommon.errContent[3].errContent.Add("DC Output Fail");
            clsCommon.errContent[3].errContent.Add("LNA Fail");
            clsCommon.errContent[3].errContent.Add("LD Alarm");
            clsCommon.errContent[3].errContent.Add("PD Alarm");
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        }
        #endregion


        bool flagCCEStView = false;
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    flagCCEStView = !flagCCEStView;

                    SetVisible(lbl_Connected2, flagCCEStView);
                    SetVisible(lbl_RX2, flagCCEStView);
                    SetVisible(lbl_TX2, flagCCEStView);
                    SetVisible(lbl_Connected3, flagCCEStView);
                    SetVisible(lbl_RX3, flagCCEStView);
                    SetVisible(lbl_TX3, flagCCEStView);
                }
            }
        }

        #region 컨트롤 제어(문자출력, 활성화 변경, 색변경)
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //컨트롤의 위치/크기 지정
        private void SetLocationSize(Control control, int width, int height, int left, int top)
        {
            if (control.InvokeRequired)
            {
                SetControlLocationSizeCallback d = new SetControlLocationSizeCallback(SetLocationSize);
                this.Invoke(d, new object[] { control, width, height, left, top });
            }
            else
            {
                control.Width = width;
                control.Height = height;
                control.Left = left;
                control.Top = top;
            }
        }

        //컨트롤에 문자를 출력하기 위함
        private void SetText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }

        //컨트롤에 문자를 출력하기 위함
        private void SetTextAppend(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextAppend);
                this.Invoke(d, new object[] { control, text });
            }
            else
            {
                if (((TextBox)control).Text.Length > 2048)
                    ((TextBox)control).Text = ((TextBox)control).Text.Substring(1024);
                //if (((TextBox)control).Text.Length > 1024)
                //    ((TextBox)control).Text = ((TextBox)control).Text.Substring(512);

                ((TextBox)control).Text += text;

                ((TextBox)control).SelectionStart = ((TextBox)control).Text.Length;//맨 마지막 선택...
                ((TextBox)control).ScrollToCaret();
            }
        }

        //컨트롤의 활성화 여부를 결정하기 위함
        private void SetEnable(Control control, bool flag)
        {
            if (control.InvokeRequired)
            {
                SetEnableCallback d = new SetEnableCallback(SetEnable);
                this.Invoke(d, new object[] { control, flag });
            }
            else
            {
                control.Enabled = flag;
            }
        }

        //컨트롤에 색을 변경하기 위함
        private void SetColor(Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                SetColorCallback d = new SetColorCallback(SetColor);
                this.Invoke(d, new object[] { control, color });
            }
            else
            {
                control.BackColor = color;
            }
        }

        //컨트롤의 글자색을 변경하기 위함
        private void SetForeColor(Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                SetColorCallback d = new SetColorCallback(SetForeColor);
                this.Invoke(d, new object[] { control, color });
            }
            else
            {
                control.ForeColor = color;
            }
        }

        //컨트롤의 Visible값을 변경하기 위함
        private void SetVisible(Control control, bool flag)
        {
            if (control.InvokeRequired)
            {
                SetVisibleCallback d = new SetVisibleCallback(SetVisible);
                this.Invoke(d, new object[] { control, flag });
            }
            else
            {
                control.Visible = flag;
            }
        }

        //컨트롤에 체크하기 위함
        private void SetChecked(CheckBox control, bool flag)
        {
            if (control.InvokeRequired)
            {
                SetCheckedCallback d = new SetCheckedCallback(SetChecked);
                this.Invoke(d, new object[] { control, flag });
            }
            else
            {
                control.Checked = flag;
            }
        }

        //컨트롤에 체크하기 위함
        private void SetRdButChecked(RadioButton control, bool flag)
        {
            if (control.InvokeRequired)
            {
                SetRdButCheckedCallback d = new SetRdButCheckedCallback(SetRdButChecked);
                this.Invoke(d, new object[] { control, flag });
            }
            else
            {
                control.Checked = flag;
            }
        }

        //컨트롤의 Value값을 변경하기 위함
        private void SetValue(ProgressBar control, int maxValue, int value)
        {
            if (control.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetValue);
                this.Invoke(d, new object[] { control, maxValue, value });
            }
            else
            {
                control.Maximum = maxValue;
                control.Value = value;
            }
        }

        //TrackBar 컨트롤에 value값을 변경하기 위함
        private void SetValue(TrackBar control, int value)
        {
            if (control.InvokeRequired)
            {
                SetTBValueCallback d = new SetTBValueCallback(SetValue);
                this.Invoke(d, new object[] { control, value });
            }
            else
            {
                control.Value = value;
            }
        }

        //PictureBox에 그림을 변경하기 위함
        private void SetImage(PictureBox control, Bitmap bitmap)
        {
            if (control.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(SetImage);
                this.Invoke(d, new object[] { control, bitmap });
            }
            else
            {
                control.Image = bitmap;
            }
        }

        //ListView 컨트롤의 Item을 삭제하기 위함
        private void SetListViewItemClear(ListView lvControl)
        {
            if (lvControl.InvokeRequired)
            {
                SetListViewItemClearCallback d = new SetListViewItemClearCallback(SetListViewItemClear);
                this.Invoke(d, new object[] { lvControl });
            }
            else
            {
                lvControl.Items.Clear();
            }
        }

        //ListView 컨트롤의 Item을 추가하기 위함
        private void SetListViewItemInster(ListView lvControl, int index, ListViewItem lvItem)
        {
            if (lvControl.InvokeRequired)
            {
                SetListViewItemInsertCallback d = new SetListViewItemInsertCallback(SetListViewItemInster);
                this.Invoke(d, new object[] { lvControl, index, lvItem });
            }
            else
            {
                lvControl.Items.Insert(index, lvItem);
            }
        }

        //DataGridView의 모든 Row를 삭제하기 위함
        private void SetdataGridViewClear(DataGridView dgvControl)
        {
            if (dgvControl.InvokeRequired)
            {
                SetdataGridViewClearCallback d = new SetdataGridViewClearCallback(SetdataGridViewClear);
                this.Invoke(d, new object[] { dgvControl });
            }
            else
            {
                dgvControl.Rows.Clear();
            }
        }

        private void SetdataGridViewMuErrorStValue(DataGridView dgvControl, int index, string dateTime, string content)
        {
            if (dgvControl.InvokeRequired)
            {
                SetdataGridViewMuErrorStValueCallback d = new SetdataGridViewMuErrorStValueCallback(SetdataGridViewMuErrorStValue);
                this.Invoke(d, new object[] { dgvControl, index, dateTime, content });
            }
            else
            {
                dgvControl.Rows.Add();
                //dgvControl.Rows[index].Cells[0].Value = (index + 1).ToString();    //순번
                dgvControl.Rows[index].Cells[1].Value = dateTime;       //날자/시간
                dgvControl.Rows[index].Cells[2].Value = content;    //내용
            }
        }

        private void SetdataGridViewMuErrorStIndex(DataGridView dgvControl, int index, string dateTime, string content)
        {
            if (dgvControl.InvokeRequired)
            {
                SetdataGridViewMuErrorStValueCallback d = new SetdataGridViewMuErrorStValueCallback(SetdataGridViewMuErrorStIndex);
                this.Invoke(d, new object[] { dgvControl, index, dateTime, content });
            }
            else
            {
                dgvControl.Rows[index].Cells[0].Value = (index + 1).ToString();    //순번
            }
        }

        private void SetdataGridViewMuTxRxErxStValue(DataGridView dgvControl, int index, string content, string ch, string startDateTime, string stopDateTime)
        {
            if (dgvControl.InvokeRequired)
            {
                SetdataGridViewMuTxRxErxStValueCallback d = new SetdataGridViewMuTxRxErxStValueCallback(SetdataGridViewMuTxRxErxStValue);
                this.Invoke(d, new object[] { dgvControl, index, content, ch, startDateTime, stopDateTime });
            }
            else
            {
                dgvControl.Rows.Add();
                dgvControl.Rows[index].Cells[0].Value = (index + 1).ToString();    //순번
                dgvControl.Rows[index].Cells[1].Value = content;    //내용
                dgvControl.Rows[index].Cells[2].Value = ch;         //채널
                dgvControl.Rows[index].Cells[3].Value = startDateTime;  //시작시간
                dgvControl.Rows[index].Cells[4].Value = stopDateTime;   //중지시간
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region AddStatus( 현재상태 DataBase에 저장 )
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public void AddStatus(string tmpStr)
        {
            try
            {
                statusListInfo tmpStatus = new statusListInfo();

                tmpStatus.datetime = DateTime.Now;
                tmpStatus.content = tmpStr;

                fbDBMS_StatusListInfo.Insert(tmpStatus);    //DB에 저장

                tmpStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + tmpStr;
                listBoxNowStatusDisplay(lbStatusDisplay, tmpStr);
            }
            catch
            {
            }
        }

        private void listBoxNowStatusDisplay(Control control, string text)
        {
            if (lbStatusDisplay.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(listBoxNowStatusDisplay);
                this.Invoke(d, new object[] { control, text });
            }
            else
            {
                if (lbStatusDisplay.Items.Count >= 200)
                    lbStatusDisplay.Items.RemoveAt(0);

                lbStatusDisplay.Items.Insert(lbStatusDisplay.Items.Count, text);
                lbStatusDisplay.SelectedIndex = lbStatusDisplay.Items.Count - 1;
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private void btMenu4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (frmDG == null)
                {
                    frmDG = new frmDebug();
                    frmDG.FormClosing += new FormClosingEventHandler(frmDG_FormClosing);
                    frmDG.cbMURUSet(stationList);
                    frmDG.Show();
                }
                else
                {
                    MessageBox.Show("이미실행되어 있습니다.", "중복실행확인", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddStatus("프로그램을 종료합니다.");
        }

        private bool flagAllSearchVisible = false;
        private void frmMain_DoubleClick(object sender, EventArgs e)
        {
            flagAllSearchVisible = !flagAllSearchVisible;

            SetVisible(cbArrangement, flagAllSearchVisible);
            SetVisible(btArrangement, flagAllSearchVisible);

            SetVisible(tcCCESearch, flagAllSearchVisible);
            SetVisible(tcNMSSearch, flagAllSearchVisible);

            //SetVisible(btDataDelete, flagAllSearchVisible);
            //SetVisible(btCCEDataDelete, flagAllSearchVisible);
        }

        #region NMS, MU, RC, RU, CCE 초기화 작업

        private void NMS_Init()
        {
            int i = 0, j = 0;

            StreamReader fr = null;

            #region 파일로 부터 역 List 정보 읽어오기
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            try
            {
                fr = File.OpenText(clsCommon.DefaultPath + clsCommon.nmsGUIUser + ".txt");

                string tmpStation = fr.ReadLine();

                while (tmpStation != null)
                {
                    stationList.Add(tmpStation);
                    tmpStation = fr.ReadLine();                   
                }
            }
            catch
            {
            }

            fr.Close();
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            for (i = 0; i < 3; i++)
                btMainApparatus[i].Tag = i;

            for (i = 0; i < MainMachineSt.Count; i++)
                MainMachineSt[i].MyID = i;
            MainMachineSt[0].SetStationName("구 로");
            MainMachineSt[1].SetStationName("대 전");
            MainMachineSt[2].SetStationName("NMS");

            clsCommon.stationCount = stationList.Count;

            if (clsCommon.nmsGUIUser == "전라선")
            {
                for (i = 0; i < 19; i++)
                    clsCommon.flagSpare[i] = true;

                #region 파일로 부터 역사별 알람 정보 읽어오기
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                try
                {
                    fr = File.OpenText(clsCommon.DefaultPath + clsCommon.nmsGUIUser + "_AlarmSetup.txt");

                    for (i = 0; i < clsCommon.stationCount; i++)
                    {
                        if (fr.ReadLine() == "True")
                            clsCommon.flagStationAlarm[i] = true;
                        else
                            clsCommon.flagStationAlarm[i] = false;
                    }
                }
                catch
                {
                }

                fr.Close();
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion
            }

            Create_StationButton(stationList.Count);    //역사 갯수만큼 버튼을 만든다.

            //MU 통화권 MU/RU 버튼
            for (i = 0; i < stationList.Count; i++)
            {
                btMuStation[i].Tag = i;

                for (j = 0; j < 4; j++)
                {
                    try
                    {
                        btRuStation[i, j].Tag = (i * 10) + j;
                    }
                    catch
                    {
                        break;
                    }
                }
            }

            //RC 통화권 RC 버튼
            for (i = 0; i < 15; i++)
            {
                btRcStation[i].Tag = i;
                btRc[i].Tag = i;

                if (clsCommon.nmsGUIUser == "경춘선")
                    btRc[i].Width = 100;
            }

            for (i = 0; i < 4; i++)
            {
                ruSt1[i].MyID = i;
                ruSt2[i].MyID = i;

                btAfGainSet[i].Tag = i;

                tbRcName[i].Tag = i;
                tbBdaName[i].Tag = i;

                bdaSt[i].bdaID = (byte)(i + 1);
            }

            for (i = 0; i < 8; i++)
                btMenu[i].Tag = i;

            //회선 시험의 버튼
            for (i = 0; i < 3; i++) btLineTestMode[i].Tag = i;
            for (i = 0; i < 2; i++) btLineTest[i].Tag = i;

            clsCommon.muRfValueTable[0] = 0x61;
            clsCommon.muRfValueTable[1] = 0x66;
            clsCommon.muRfValueTable[2] = 0x6A;
            clsCommon.muRfValueTable[3] = 0x6E;
            clsCommon.muRfValueTable[4] = 0x72;
            clsCommon.muRfValueTable[5] = 0x76;
            clsCommon.muRfValueTable[6] = 0x79;
            clsCommon.muRfValueTable[7] = 0x7D;
            clsCommon.muRfValueTable[8] = 0x81;
            clsCommon.muRfValueTable[9] = 0x84;
            clsCommon.muRfValueTable[10] = 0x88;
            clsCommon.muRfValueTable[11] = 0x8A;
            clsCommon.muRfValueTable[12] = 0x8D;

            clsCommon.ruRfValueTable[0] = 0x76;
            clsCommon.ruRfValueTable[1] = 0x7F;
            clsCommon.ruRfValueTable[2] = 0x86;
            clsCommon.ruRfValueTable[3] = 0x8C;
            clsCommon.ruRfValueTable[4] = 0x93;
            clsCommon.ruRfValueTable[5] = 0x99;
            clsCommon.ruRfValueTable[6] = 0x9F;
            clsCommon.ruRfValueTable[7] = 0xA5;
            clsCommon.ruRfValueTable[8] = 0xAA;
            clsCommon.ruRfValueTable[9] = 0xAE;
            clsCommon.ruRfValueTable[10] = 0xB4;
            clsCommon.ruRfValueTable[11] = 0xB9;
            clsCommon.ruRfValueTable[12] = 0xBC;

            #region 역사별 MU/RU 상태 저장 변수 초기화
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            muruNowData = new MURUData[stationList.Count + 1];

            for (i = 0; i < muruNowData.Length; i++)
                muruNowData[i] = new MURUData();
 
            //MuRu 이름저장변수 초기화 
            clsCommon.muruName = new MuRuName[stationList.Count + 1];
            for (i = 0; i < muruNowData.Length; i++)
                clsCommon.muruName[i] = new MuRuName();

            for (i = 0; i < 32; i++)
                muChPtt[i] = new muChPttSt();

            //MuRu 통신 상태 저장 변수 초기화
            for (i = 0; i < stationList.Count; i++)
            {
                clsCommon.muruComSt[i] = new MuRuComSt();
                clsCommon.muruFmExist[i] = new MuRuFmExist();
            }

            for (i = 0; i < 3; i++)
                clsCommon.cceComSt[i] = new CCEComSt();

            commErrCheck = new CommErrCheck[stationList.Count + 1];
            for (i = 0; i < muruNowData.Length; i++)
                commErrCheck[i] = new CommErrCheck();

            //private MURUDataChange[] mrurDataChange = null;
            mrurDataChange = new MURUDataChange[stationList.Count + 1];
            for (i = 0; i < muruNowData.Length; i++)
                mrurDataChange[i] = new MURUDataChange();
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region 검색 관련 변수 초기화
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //통신 이력 관련 변수 초기화
            muTxRxErxResult = new MuTxRxErxStSearchResult[stationList.Count];
            muTxRxErx = new MuTxRxErxStSearch[stationList.Count];
            for (i = 0; i < muTxRxErx.Length; i++)
            {
                muTxRxErxResult[i] = new MuTxRxErxStSearchResult();

                muTxRxErx[i] = new MuTxRxErxStSearch();

                for (j = 0; j < 5; j++)
                {
                    muTxRxErx[i].cntMuTxRxErx[j] = 0;
                    muTxRxErx[i].flagMuTxRxErx[j] = false;
                }
            }

            //장애 이력 관련 변수 초기화
            muErrResult = new MuErrorStSearchResult[stationList.Count];
            muErr = new MuErrorStSearch[stationList.Count];
            for (i = 0; i < muErr.Length; i++)
            {
                muErrResult[i] = new MuErrorStSearchResult();

                muErr[i] = new MuErrorStSearch();

                for (j = 0; j < 28; j++)
                {
                    muErr[i].cntErr[j] = 0;
                    muErr[i].flagErr[j] = false;
                }
            }

            ruErrResult = new MuErrorStSearchResult[stationList.Count, 4];
            ruErr = new MuErrorStSearch[stationList.Count, 4];
            for (i = 0; i < stationList.Count; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    ruErrResult[i, j] = new MuErrorStSearchResult();
                    ruErr[i, j] = new MuErrorStSearch();

                    for (int k = 0; k < 11; k++)
                    {
                        ruErr[i, j].cntErr[k] = 0;
                        ruErr[i, j].flagErr[k] = false;
                    }
                }
            }

            bdaErrResult = new MuErrorStSearchResult[stationList.Count, 4, 4];
            bdaErr = new MuErrorStSearch[stationList.Count, 4, 4];
            for (i = 0; i < stationList.Count; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        bdaErrResult[i, j, k] = new MuErrorStSearchResult();
                        bdaErr[i, j, k] = new MuErrorStSearch();

                        for (int l = 0; l < 13; l++)
                        {
                            bdaErr[i, j, k].cntErr[k] = 0;
                            bdaErr[i, j, k].flagErr[k] = false;
                        }
                    }
                }
            }

            muFmErrResult = new MuErrorStSearchResult[stationList.Count];
            muFmErr = new MuErrorStSearch[stationList.Count];
            for (i = 0; i < muFmErr.Length; i++)
            {
                muFmErrResult[i] = new MuErrorStSearchResult();

                muFmErr[i] = new MuErrorStSearch();

                for (j = 0; j < 28; j++)
                {
                    muFmErr[i].cntErr[j] = 0;
                    muFmErr[i].flagErr[j] = false;
                }
            }

            ruFmErrResult = new MuErrorStSearchResult[stationList.Count, 4];
            ruFmErr = new MuErrorStSearch[stationList.Count, 4];
            for (i = 0; i < stationList.Count; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    ruFmErrResult[i, j] = new MuErrorStSearchResult();
                    ruFmErr[i, j] = new MuErrorStSearch();

                    for (int k = 0; k < 11; k++)
                    {
                        ruFmErr[i, j].cntErr[k] = 0;
                        ruFmErr[i, j].flagErr[k] = false;
                    }
                }
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region 파일로 부터 MU/RU 이름 정보 읽어오기
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            try
            {
                fr = File.OpenText(clsCommon.DefaultPath + clsCommon.nmsGUIUser + "_MuRuName.txt");

                clsCommon.tmpVer = fr.ReadLine();      //Version Read

                int tmpVer = clsCommon.VerCheck(clsCommon.tmpVer);

                switch (tmpVer)
                {
                    case 2:     //Ver 1.02
                    case 3:     //Ver 1.03
                    case 4:     //Ver 1.04
                    case 5:     //Ver 1.05
                    case 6:     //Ver 1.06
                    case 7:     //Ver 1.07
                    case 8:     //Ver 1.08
                    case 9:     //Ver 1.09
                    case 10:    //Ver 1.10
                    case 11:    //Ver 1.11
                    case 12:    //Ver 1.12
                    case 13:    //Ver 1.13
                    case 14:    //Ver 1.14
                    case 15:    //Ver 1.15
                    case 16:    //Ver 1.16
                    case 17:    //Ver 1.17
                    case 18:    //Ver 1.18
                    case 19:    //Ver 1.19
                    case 20:    //Ver 1.20
                    case 21:    //Ver 1.21
                    case 22:    //Ver 1.22
                    case 23:    //Ver 1.23 ~ 1.28
                    case 24:    //Ver 1.29 ~
                    case 25:    //Ver 1.30 ~
                        for (i = 0; i < muruNowData.Length; i++)
                        {
                            clsCommon.muruName[i].muName = fr.ReadLine();

                            for (j = 0; j < 4; j++) clsCommon.muruName[i].ruName[j].ruName = fr.ReadLine();

                            for (j = 0; j < 4; j++) clsCommon.muruName[i].rcName[j] = fr.ReadLine();
                        }

                        //FM 장치가 있는지의 여부
                        if (tmpVer >= 24)
                        {
                            for (i = 0; i < muruNowData.Length; i++)
                            {
                                if (fr.ReadLine() == "True")
                                    clsCommon.muruFmExist[i].flagMu = true;

                                for (j = 0; j < 4; j++)
                                {
                                    if (fr.ReadLine() == "True")
                                        clsCommon.muruFmExist[i].flagRu[j] = true;
                                }
                            }
                        }
                        break;

                    default:
                        //if (clsCommon.flagLanguage) MessageBox.Show("프로그램 버젼이 맞지 않습니다. 확인후 다시 시도하시기 바랍니다.");
                        //else MessageBox.Show("Program version does not match. Try again after verification.");

                        this.Close();
                        break;
                }
            }
            catch
            {
            }

            fr.Close();
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region 파일로 부터 BDA 이름 정보 읽어오기
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            try
            {
                fr = File.OpenText(clsCommon.DefaultPath + clsCommon.nmsGUIUser + "_BdaName.txt");

                clsCommon.tmpVer = fr.ReadLine();      //Version Read

                int tmpVer = clsCommon.VerCheck(clsCommon.tmpVer);

                switch (tmpVer)
                {
                    case 11:    //Ver 1.11
                    case 12:    //Ver 1.12
                    case 13:    //Ver 1.13
                    case 14:    //Ver 1.14
                    case 15:    //Ver 1.15
                    case 16:    //Ver 1.16
                    case 17:    //Ver 1.17
                    case 18:    //Ver 1.18
                    case 19:    //Ver 1.19
                    case 20:    //Ver 1.20
                    case 21:    //Ver 1.21
                    case 22:    //Ver 1.22
                    case 23:    //Ver 1.23 ~ 1.28
                    case 24:    //Ver 1.29 ~
                    case 25:    //Ver 1.30 ~
                        for (i = 0; i < muruNowData.Length; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                for (int k = 0; k < 4; k++)
                                    clsCommon.muruName[i].ruName[j].bdaName[k] = fr.ReadLine();
                            }
                        }
                        break;

                    default:
                        //if (clsCommon.flagLanguage) MessageBox.Show("프로그램 버젼이 맞지 않습니다. 확인후 다시 시도하시기 바랍니다.");
                        //else MessageBox.Show("Program version does not match. Try again after verification.");

                        this.Close();
                        break;
                }
            }
            catch
            {
            }

            fr.Close();
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            for (i = 0; i < stationList.Count; i++)
            {
                cbLineTestStationList.Items.Add(stationList[i].ToString()); //회선 시험 화면의 역사 선택 콤보박스에 역사이름 추가
                cbSearchStation.Items.Add(stationList[i].ToString());       //이력 검색 화면의 역사 선택 콤보박스에 역사이름 추가
            }

            lbMuRuName.Items.Clear();   //MuRu 이름 설정화면의 역사 이름 표시
            cbSetupMU.Items.Add("선택 안함");       //설정화면의 A/S용
            cbSetupBDANameMU.Items.Add("선택 안함");    //설정화면의 BDA 이름 설정용

            for (i = 0; i < stationList.Count; i++)
            {
                lbMuRuName.Items.Add(stationList[i].ToString());

                cbSetupMU.Items.Add(stationList[i].ToString());
                cbSetupBDANameMU.Items.Add(stationList[i].ToString());

            }

            cbLineTestStationList.SelectedIndex = 0;
            cbSearchStation.SelectedIndex = 0;

            ucErrorSearch.ucSearch_Init(stationList);   //에러 검색 화면의 역사이름 초기화

            ucErrorSearch.ErrorItemInput(0);    //이력조회의 고장내역에 MU고장정보 입력

            MU_Init();

            //경춘선은 RC화면 사용안함.
            if (clsCommon.nmsGUIUser != "경춘선")
            {
                RC_Init();
                RU_Init();  //RU화면을 사용처에 맞게 변경
            }

            #region NMS주장치와의 Network통신 관련 초기화 작업
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            nmsMainMachine = new clsNMSMainMachine(nmsIP, nmsPort);

            nmsMainMachine.nms_SocketConnected += new socket_ConnectedEvent(nmsMainMachine_nms_SocketConnected);
            nmsMainMachine.nms_SocketCloseed += new socket_ClosedEvent(nmsMainMachine_nms_SocketCloseed);

            nmsMainMachine.nms_receiveData += new ReceiveDataEvent(nmsMainMachine_nms_receiveData);

            nmsMainMachine.nms_SendReceiveDataView += new NMSMainMachine_SendReceiveDataViewEvent(nmsMainMachine_nms_SendReceiveDataView);
            nmsMainMachine.nms_DataSendReceive += new NMSMainMachine_DataSendReceiveEvent(nmsMainMachine_nms_DataSendReceive);
            nmsMainMachine.nms_Polling += new NMSMainMachine_PollingEvent(nmsMainMachine_nms_Polling);

            nmsMainMachine.nms_AfGain += new NMSMainMachine_AFGainEvent(nmsMainMachine_nms_AfGain);
            nmsMainMachine.nms_MuStReport += new NMSMainMachine_MuStReportEvent(nmsMainMachine_nms_MuStReport);
            nmsMainMachine.nms_RuStReport += new NMSMainMachine_RuStReportEvent(nmsMainMachine_nms_RuStReport);

            nmsMainMachine.nms_UpsStReport += new NMSMainMachine_UpsStReportEvent(nmsMainMachine_nms_UpsStReport);

            nmsMainMachine.nms_FmStReport += new NMSMainMachine_FMStReportEvent(nmsMainMachine_nms_FmStReport);
            nmsMainMachine.nms_SourcetelFmStReport += new NMSMainMachine_SourcetelFMStReportEvent(nmsMainMachine_nms_SourcetelFmStReport);

            nmsMainMachine.nms_BDAInitRequest += new NMSMainMachine_BDAInitRequestEvent(nmsMainMachine_nms_BDAInitRequest);
            nmsMainMachine.nms_BDAInitReport += new NMSMainMachine_BDAInitReportEvent(nmsMainMachine_nms_BDAInitReport);
            nmsMainMachine.nms_BDAStReport += new NMSMainMachine_BDAStReportEvent(nmsMainMachine_nms_BDAStReport);
            nmsMainMachine.nms_BDALoopTest += new NMSMainMachine_BDALoopTestEvent(nmsMainMachine_nms_BDALoopTest);
            nmsMainMachine.nms_BDACommStReport += new NMSMainMachine_BDACommStReportEvent(nmsMainMachine_nms_BDACommStReport);
            nmsMainMachine.nms_BDARfValueReport += new NMSMainMachine_BDARfValueReportEvent(nmsMainMachine_nms_BDARfValueReport);

            nmsMainMachine.Start();
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
        }

        private void MU_Init()
        {
            int i = 0, j = 0;

            SetImage(pbMURoute, new Bitmap(clsCommon.ImagePath + clsCommon.nmsGUIUser + " 노선도.png"));

            switch (clsCommon.nmsGUIUser)
            {
                case "전라선":
                    #region 전라선 MU 통화권 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #region MU 통화권 버튼 정보 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    //MU 버튼 크기 조정
                    for (i = 0; i < 24; i++)
                    {
                        btMuStation[i].Width = 100;
                        btMuStation[i].Height = 50;

                        //RU 버튼
                        for (j = 0; j < 4; j++)
                        {
                            try
                            {
                                btRuStation[i, j].Width = 80;
                                btRuStation[i, j].Height = 50;
                            }
                            catch
                            {
                            }
                        }
                    }

                    //MU 버튼 위치 조정
                    for (i = 0; i < 11; i++)
                    {
                        SetVisible(btMuStation[i], true);
                        SetText(btMuStation[i], stationList[i]);
                        btMuStation[i].Left = i * 127 + 175;
                        btMuStation[i].Top = 157;

                        SetVisible(btMuStation[23 - i], true);
                        SetText(btMuStation[23 - i], stationList[23 - i]);
                        btMuStation[23 - i].Left = i * 127 + 175;
                        btMuStation[23 - i].Top = 537;
                    }

                    SetVisible(btMuStation[11], true);
                    SetText(btMuStation[11], stationList[11]);
                    btMuStation[11].Left = 1512;
                    btMuStation[11].Top = 279;
                    SetVisible(btMuStation[12], true);
                    SetText(btMuStation[12], stationList[12]);
                    btMuStation[12].Left = 1512;
                    btMuStation[12].Top = 416;

                    //RU 버튼 위치 조정
                    for (i = 0; i < 4; i++)
                    {
                        SetVisible(btRuStation[3, i], true);
                        SetText(btRuStation[3, i], clsCommon.muruName[3].ruName[i].ruName);
                        btRuStation[3, i].Left = i * 95 + 423;
                        btRuStation[3, i].Top = 50;
                    }

                    for (i = 0; i < 2; i++)
                    {
                        for (j = 5; j < 7; j++)
                        {
                            SetVisible(btRuStation[j, i], true);
                            SetText(btRuStation[j, i], clsCommon.muruName[j].ruName[i].ruName);
                        }
                        btRuStation[5, i].Left = i * 95 + 769;
                        btRuStation[5, i].Top = 262;

                        btRuStation[6, i].Left = i * 95 + 896;
                        btRuStation[6, i].Top = 50;

                        SetVisible(btRuStation[10, i], true);
                        SetText(btRuStation[10, i], clsCommon.muruName[10].ruName[i].ruName);
                        btRuStation[10, i].Left = i * 95 + 1404;
                        btRuStation[10, i].Top = 50;

                        for (j = 13; j < 17; j++)
                        {
                            SetVisible(btRuStation[j, i], true);
                            SetText(btRuStation[j, i], clsCommon.muruName[j].ruName[i].ruName);
                        }
                        SetText(btRuStation[13, i], clsCommon.muruName[13].ruName[i].ruName);
                        btRuStation[13, i].Left = 1497 - i * 95;
                        btRuStation[13, i].Top = 648;

                        SetText(btRuStation[14, i], clsCommon.muruName[14].ruName[i].ruName);
                        btRuStation[14, i].Left = 1373 - i * 95;
                        btRuStation[14, i].Top = 432;

                        SetText(btRuStation[15, i], clsCommon.muruName[15].ruName[i].ruName);
                        btRuStation[15, i].Left = 1244 - i * 95;
                        btRuStation[15, i].Top = 648;

                        SetText(btRuStation[16, i], clsCommon.muruName[16].ruName[i].ruName);
                        btRuStation[16, i].Left = 1116 - i * 95;
                        btRuStation[16, i].Top = 432;

                        SetVisible(btRuStation[20, i], true);
                        SetText(btRuStation[20, i], clsCommon.muruName[20].ruName[i].ruName);
                        btRuStation[20, i].Left = 611 - i * 95;
                        btRuStation[20, i].Top = 432;
                    }

                    SetVisible(btRuStation[7, 0], true);
                    SetText(btRuStation[7, 0], clsCommon.muruName[7].ruName[0].ruName);
                    btRuStation[7, 0].Left = 1070;
                    btRuStation[7, 0].Top = 262;

                    for (i = 0; i < 3; i++)
                    {
                        SetVisible(btRuStation[8, i], true);
                        SetText(btRuStation[8, i], clsCommon.muruName[8].ruName[i].ruName);
                        btRuStation[8, i].Left = i * 95 + 1102;
                        btRuStation[8, i].Top = 50;

                        SetVisible(btRuStation[18, i], true);
                        SetText(btRuStation[18, i], clsCommon.muruName[18].ruName[i].ruName);
                        btRuStation[18, i].Left = 912 - i * 95;
                        btRuStation[18, i].Top = 432;
                    }

                    SetVisible(btRuStation[11, 0], true);
                    SetText(btRuStation[11, 0], clsCommon.muruName[11].ruName[0].ruName);
                    btRuStation[11, 0].Left = 1682;
                    btRuStation[11, 0].Top = 278;

                    SetVisible(btRuStation[12, 0], true);
                    SetText(btRuStation[12, 0], clsCommon.muruName[12].ruName[0].ruName);
                    btRuStation[12, 0].Left = 1682;
                    btRuStation[12, 0].Top = 414;
                    
                    SetVisible(btRuStation[17, 0], true);
                    SetText(btRuStation[17, 0], clsCommon.muruName[17].ruName[0].ruName);
                    btRuStation[17, 0].Left = 943;
                    btRuStation[17, 0].Top = 648;

                    SetVisible(btRuStation[19, 0], true);
                    SetText(btRuStation[19, 0], clsCommon.muruName[19].ruName[0].ruName);
                    btRuStation[19, 0].Left = 691;
                    btRuStation[19, 0].Top = 648;

                    for (j = 21; j < 24; j++)
                    {
                        SetVisible(btRuStation[j, 0], true);
                        SetText(btRuStation[j, 0], clsCommon.muruName[j].ruName[0].ruName);
                    }
                    btRuStation[21, 0].Left = 439;
                    btRuStation[21, 0].Top = 648;
                    btRuStation[22, 0].Left = 312;
                    btRuStation[22, 0].Top = 648;
                    btRuStation[23, 0].Left = 185;
                    btRuStation[23, 0].Top = 648;


                    /*
                    //RU 버튼
                    for (i = 0; i < 4; i++)
                    {
                        SetVisible(btRuStation[3, i], true);
                        SetText(btRuStation[3, i], clsCommon.muruName[3].ruName[i].ruName);
                        btRuStation[3, i].Left = i * 76 + 344;
                        btRuStation[3, i].Top = 42;
                    }

                    for (i = 0; i < 2; i++)
                    {
                        for (j = 5; j < 7; j++)
                        {
                            SetVisible(btRuStation[j, i], true);
                            SetText(btRuStation[j, i], clsCommon.muruName[j].ruName[i].ruName);
                        }
                        btRuStation[5, i].Left = i * 76 + 622;
                        btRuStation[5, i].Top = 263;

                        btRuStation[6, i].Left = i * 76 + 723;
                        btRuStation[6, i].Top = 42;

                        SetVisible(btRuStation[10, i], true);
                        SetText(btRuStation[10, i], clsCommon.muruName[10].ruName[i].ruName);
                        btRuStation[10, i].Left = i * 76 + 1129;
                        btRuStation[10, i].Top = 42;

                        for (j = 13; j < 17; j++)
                        {
                            SetVisible(btRuStation[j, i], true);
                            SetText(btRuStation[j, i], clsCommon.muruName[j].ruName[i].ruName);
                        }
                        SetText(btRuStation[13, i], clsCommon.muruName[13].ruName[i].ruName);
                        btRuStation[13, i].Left = 1205 - i * 76;
                        btRuStation[13, i].Top = 643;

                        SetText(btRuStation[14, i], clsCommon.muruName[14].ruName[i].ruName);
                        btRuStation[14, i].Left = 1104 - i * 76;
                        btRuStation[14, i].Top = 422;

                        SetText(btRuStation[15, i], clsCommon.muruName[15].ruName[i].ruName);
                        btRuStation[15, i].Left = 1002 - i * 76;
                        btRuStation[15, i].Top = 643;

                        SetText(btRuStation[16, i], clsCommon.muruName[16].ruName[i].ruName);
                        btRuStation[16, i].Left = 900 - i * 76;
                        btRuStation[16, i].Top = 422;

                        SetVisible(btRuStation[20, i], true);
                        SetText(btRuStation[20, i], clsCommon.muruName[20].ruName[i].ruName);
                        btRuStation[20, i].Left = 496 - i * 76;
                        btRuStation[20, i].Top = 422;
                    }

                    SetVisible(btRuStation[7, 0], true);
                    SetText(btRuStation[7, 0], clsCommon.muruName[7].ruName[0].ruName);
                    btRuStation[7, 0].Left = 862;
                    btRuStation[7, 0].Top = 263;

                    for (i = 0; i < 3; i++)
                    {
                        SetVisible(btRuStation[8, i], true);
                        SetText(btRuStation[8, i], clsCommon.muruName[8].ruName[i].ruName);
                        btRuStation[8, i].Left = i * 76 + 888;
                        btRuStation[8, i].Top = 42;

                        SetVisible(btRuStation[18, i], true);
                        SetText(btRuStation[18, i], clsCommon.muruName[18].ruName[i].ruName);
                        btRuStation[18, i].Left = 736 - i * 76;
                        btRuStation[18, i].Top = 422;
                    }

                    SetVisible(btRuStation[11, 0], true);
                    SetText(btRuStation[11, 0], clsCommon.muruName[11].ruName[0].ruName);
                    btRuStation[11, 0].Left = 1338;
                    btRuStation[11, 0].Top = 273;

                    SetVisible(btRuStation[12, 0], true);
                    SetText(btRuStation[12, 0], clsCommon.muruName[12].ruName[0].ruName);
                    btRuStation[12, 0].Left = 1338;
                    btRuStation[12, 0].Top = 410;
                    
                    SetVisible(btRuStation[17, 0], true);
                    SetText(btRuStation[17, 0], clsCommon.muruName[17].ruName[0].ruName);
                    btRuStation[17, 0].Left = 761;
                    btRuStation[17, 0].Top = 643;

                    SetVisible(btRuStation[19, 0], true);
                    SetText(btRuStation[19, 0], clsCommon.muruName[19].ruName[0].ruName);
                    btRuStation[19, 0].Left = 559;
                    btRuStation[19, 0].Top = 643;

                    for (j = 21; j < 24; j++)
                    {
                        SetVisible(btRuStation[j, 0], true);
                        SetText(btRuStation[j, 0], clsCommon.muruName[j].ruName[0].ruName);
                    }
                    btRuStation[21, 0].Left = 358;
                    btRuStation[21, 0].Top = 643;
                    btRuStation[22, 0].Left = 256;
                    btRuStation[22, 0].Top = 643;
                    btRuStation[23, 0].Left = 154;
                    btRuStation[23, 0].Top = 643;
                    */
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case "중앙선":
                    #region 중앙선 MU 통화권 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #region MU 통화권 버튼 정보 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    //MU 버튼
                    for (i = 0; i < 4; i++)
                    {
                        SetVisible(btMuStation[i], true);
                        SetText(btMuStation[i], stationList[i]);
                        btMuStation[i].Width = 120;
                        btMuStation[i].Height = 60;

                        btMuStation[i].Left = i * 403 + 246;
                        btMuStation[i].Top = 183;

                        SetVisible(btMuStation[7 - i], true);
                        SetText(btMuStation[7 - i], stationList[7 - i]);
                        btMuStation[7 - i].Width = 120;
                        btMuStation[7 - i].Height = 60;

                        btMuStation[7 - i].Left = i * 403 + 246;
                        btMuStation[7 - i].Top = 497;
                    }

                    //RU 버튼
                    SetVisible(btRuStation[0, 0], true);
                    SetText(btRuStation[0, 0], clsCommon.muruName[0].ruName[0].ruName);
                    btRuStation[0, 0].Width = 100;
                    btRuStation[0, 0].Height = 50;
                    btRuStation[0, 0].Left = 256;
                    btRuStation[0, 0].Top = 71;

                    SetVisible(btRuStation[4, 0], true);
                    SetText(btRuStation[4, 0], clsCommon.muruName[4].ruName[0].ruName);
                    btRuStation[4, 0].Width = 100;
                    btRuStation[4, 0].Height = 50;
                    btRuStation[4, 0].Left = 1465;
                    btRuStation[4, 0].Top = 623;

                    SetVisible(btRuStation[5, 0], true);
                    SetText(btRuStation[5, 0], clsCommon.muruName[5].ruName[0].ruName);
                    btRuStation[5, 0].Width = 100;
                    btRuStation[5, 0].Height = 50;
                    btRuStation[5, 0].Left = 1062;
                    btRuStation[5, 0].Top = 623;

                    for (i = 0; i < 2; i++)
                    {
                        SetVisible(btRuStation[2, i], true);
                        SetText(btRuStation[2, i], clsCommon.muruName[2].ruName[i].ruName);
                        btRuStation[2, i].Width = 100;
                        btRuStation[2, i].Height = 50;
                        btRuStation[2, i].Left = i * 116 + 1004;
                        btRuStation[2, i].Top = 71;

                        SetVisible(btRuStation[7, i], true);
                        SetText(btRuStation[7, i], clsCommon.muruName[7].ruName[i].ruName);
                        btRuStation[7, i].Width = 100;
                        btRuStation[7, i].Height = 50;
                        btRuStation[7, i].Left = 314 - i * 116;
                        btRuStation[7, i].Top = 623;
                    }

                    for (i = 0; i < 3; i++)
                    {
                        SetVisible(btRuStation[6, i], true);
                        SetText(btRuStation[6, i], clsCommon.muruName[6].ruName[i].ruName);
                        btRuStation[6, i].Width = 100;
                        btRuStation[6, i].Height = 50;
                        btRuStation[6, i].Left = 775 - i * 116;
                        btRuStation[6, i].Top = 623;
                    }
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case "경춘선":
                    #region 경춘선 MU 통화권 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #region MU 통화권 버튼 정보 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    //MU 버튼
                    for (i = 0; i < 7; i++)
                    {
                        SetVisible(btMuStation[i], true);
                        SetText(btMuStation[i], stationList[i]);
                        btMuStation[i].Left = i * 151 + 93;
                        btMuStation[i].Top = 249;

                        SetVisible(btMuStation[13 - i], true);
                        SetText(btMuStation[13 - i], stationList[13 - i]);
                        btMuStation[13 - i].Left = i * 151 + 93;
                        btMuStation[13 - i].Top = 438;
                    }
                    
                    //RU 버튼                    
                    for (i = 0; i < 2; i++)
                    {
                        //갈매역의 구능 1T, 구능 2T
                        SetVisible(btRuStation[0, i], true);
                        SetText(btRuStation[0, i], clsCommon.muruName[0].ruName[i].ruName);
                        btRuStation[0, i].Left = i * 76 + 60;
                        btRuStation[0, i].Top = 160;

                        //마석역의 마석 T, 답내 T
                        SetVisible(btRuStation[5, i], true);
                        SetText(btRuStation[5, i], clsCommon.muruName[5].ruName[i].ruName);
                        btRuStation[5, i].Left = i * 76 + 815;
                        btRuStation[5, i].Top = 160;

                        //가평역의 상천 1T, 안선 T
                        SetVisible(btRuStation[9, i], true);
                        SetText(btRuStation[9, i], clsCommon.muruName[9].ruName[i].ruName);
                        //btRuStation[9, i].Left = i * 88 + 664;
                        btRuStation[9, i].Left = 752 - i * 88;
                        btRuStation[9, i].Top = 527;

                        //굴봉산역의 서천 T, 굴봉산 T
                        SetVisible(btRuStation[10, i], true);
                        SetText(btRuStation[10, i], clsCommon.muruName[10].ruName[i].ruName);
                        //btRuStation[10, i].Left = i * 76 + 513;
                        btRuStation[10, i].Left = 589 - i * 76;
                        btRuStation[10, i].Top = 527;

                        //김유정역의 강촌 1T, 강촌 3T
                        SetVisible(btRuStation[12, i], true);
                        SetText(btRuStation[12, i], clsCommon.muruName[12].ruName[i].ruName);
                        btRuStation[12, i].Left = 288 - i * 76;
                        btRuStation[12, i].Top = 527;
                    }

                    //금곡역의 어룡 T
                    SetVisible(btRuStation[3, 0], true);
                    SetText(btRuStation[3, 0], clsCommon.muruName[3].ruName[0].ruName);
                    btRuStation[3, 0].Left = 551;
                    btRuStation[3, 0].Top = 160;

                    //평내호평의 마치 T
                    SetVisible(btRuStation[4, 0], true);
                    SetText(btRuStation[4, 0], clsCommon.muruName[4].ruName[0].ruName);
                    btRuStation[4, 0].Left = 702;
                    btRuStation[4, 0].Top = 160;

                    //백양리의 백양 3T
                    SetVisible(btRuStation[11, 0], true);
                    SetText(btRuStation[11, 0], clsCommon.muruName[11].ruName[0].ruName);
                    btRuStation[11, 0].Left = 400;
                    btRuStation[11, 0].Top = 527;

                    for (i = 0; i < 3; i++)
                    {
                        //청평역의 대성 1T, 청평 T, 유답촌 T
                        SetVisible(btRuStation[7, i], true);
                        SetText(btRuStation[7, i], clsCommon.muruName[7].ruName[i].ruName);
                        //btRuStation[7, i].Left = i * 76 + 928;
                        btRuStation[7, i].Left = 1080 - i * 76;
                        btRuStation[7, i].Top = 527;
                    }
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion

                    #region MU 통화권의 BDA 버튼 정보 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    //평내호평의 마치T의 BDA 1/2/3 버튼
                    btMuBda[0].Tag = "5,1,1";
                    SetVisible(btMuBda[0], true);
                    SetText(btMuBda[0], "BDA 1");
                    btMuBda[0].Left = 673;
                    btMuBda[0].Top = 72;
                    btMuBda[1].Tag = "5,1,2";
                    SetVisible(btMuBda[1], true);
                    SetText(btMuBda[1], "BDA 2");
                    btMuBda[1].Left = 717;
                    btMuBda[1].Top = 72;
                    btMuBda[2].Tag = "5,1,3";
                    SetVisible(btMuBda[2], true);
                    SetText(btMuBda[2], "BDA 3");
                    btMuBda[2].Left = 759;
                    btMuBda[2].Top = 72;

                    //마석의 답내T의 BDA 1/2/3 버튼
                    btMuBda[3].Tag = "6,2,1";
                    SetVisible(btMuBda[3], true);
                    SetText(btMuBda[3], "BDA 1");
                    btMuBda[3].Left = 862;
                    btMuBda[3].Top = 72;
                    btMuBda[4].Tag = "6,2,2";
                    SetVisible(btMuBda[4], true);
                    SetText(btMuBda[4], "BDA 2");
                    btMuBda[4].Left = 906;
                    btMuBda[4].Top = 72;
                    btMuBda[5].Tag = "6,2,3";
                    SetVisible(btMuBda[5], true);
                    SetText(btMuBda[5], "BDA 3");
                    btMuBda[5].Left = 948;
                    btMuBda[5].Top = 72;

                    //청평의 대성T의 BDA 1/2 버튼
                    btMuBda[6].Tag = "8,1,1";
                    SetVisible(btMuBda[6], true);
                    SetText(btMuBda[6], "BDA 1");
                    //btMuBda[6].Left = 922;
                    btMuBda[6].Left = 1116;
                    btMuBda[6].Top = 616;
                    btMuBda[7].Tag = "8,1,2";
                    SetVisible(btMuBda[7], true);
                    SetText(btMuBda[7], "BDA 2");
                    //btMuBda[7].Left = 965;
                    btMuBda[7].Left = 1074;
                    btMuBda[7].Top = 616;
                    //청평의 유답촌T의 BDA 1 버튼
                    btMuBda[8].Tag = "8,3,1";
                    SetVisible(btMuBda[8], true);
                    SetText(btMuBda[8], "BDA 1");
                    //btMuBda[8].Left = 1095;
                    btMuBda[8].Left = 943;
                    btMuBda[8].Top = 616;

                    //가평의 상천1T의 BDA 1/2 버튼
                    btMuBda[9].Tag = "10,1,1";
                    SetVisible(btMuBda[9], true);
                    SetText(btMuBda[9], "BDA 1");
                    //btMuBda[9].Left = 635;
                    btMuBda[9].Left = 809;
                    btMuBda[9].Top = 616;
                    btMuBda[10].Tag = "10,1,2";
                    SetVisible(btMuBda[10], true);
                    SetText(btMuBda[10], "BDA 2");
                    //btMuBda[10].Left = 679;
                    btMuBda[10].Left = 767;
                    btMuBda[10].Top = 616;
                    btMuBda[11].Tag = "10,1,3";
                    SetVisible(btMuBda[11], true);
                    SetText(btMuBda[11], "BDA 3");
                    //btMuBda[11].Left = 721;
                    btMuBda[11].Left = 723;
                    btMuBda[11].Top = 616;
                    //가평의 안산T의 BDA 1 버튼
                    btMuBda[12].Tag = "10,2,1";
                    SetVisible(btMuBda[12], true);
                    SetText(btMuBda[12], "BDA 1");
                    //btMuBda[12].Left = 767;
                    btMuBda[12].Left = 679;
                    btMuBda[12].Top = 616;

                    //굴봉산의 서천T의 BDA 1/2 버튼
                    btMuBda[13].Tag = "11,1,1";
                    SetVisible(btMuBda[13], true);
                    SetText(btMuBda[13], "BDA 1");
                    //btMuBda[13].Left = 507;
                    btMuBda[13].Left = 625;
                    btMuBda[13].Top = 616;
                    btMuBda[14].Tag = "11,1,2";
                    SetVisible(btMuBda[14], true);
                    SetText(btMuBda[14], "BDA 2");
                    //btMuBda[14].Left = 549;
                    btMuBda[14].Left = 583;
                    btMuBda[14].Top = 616;

                    //백양리의 백양3T의 BDA 1/2 버튼
                    btMuBda[15].Tag = "12,1,1";
                    SetVisible(btMuBda[15], true);
                    SetText(btMuBda[15], "BDA 1");
                    //btMuBda[15].Left = 394;
                    btMuBda[15].Left = 436;
                    btMuBda[15].Top = 616;
                    btMuBda[16].Tag = "12,1,2";
                    SetVisible(btMuBda[16], true);
                    SetText(btMuBda[16], "BDA 2");
                    //btMuBda[16].Left = 436;
                    btMuBda[16].Left = 394;
                    btMuBda[16].Top = 616;

                    //김유정의 강촌1T의 BDA 1/2 버튼
                    btMuBda[17].Tag = "13,1,1";
                    SetVisible(btMuBda[17], true);
                    SetText(btMuBda[17], "BDA 1");
                    //btMuBda[17].Left = 205;
                    btMuBda[17].Left = 323;
                    btMuBda[17].Top = 616;
                    btMuBda[18].Tag = "13,1,2";
                    SetVisible(btMuBda[18], true);
                    SetText(btMuBda[18], "BDA 2");
                    //btMuBda[18].Left = 247;
                    btMuBda[18].Left = 281;
                    btMuBda[18].Top = 616;
                    //김유정의 강촌3T의 BDA 1 버튼
                    btMuBda[19].Tag = "13,2,1";
                    SetVisible(btMuBda[19], true);
                    SetText(btMuBda[19], "BDA 1");
                    //btMuBda[19].Left = 302;
                    btMuBda[19].Left = 226;
                    btMuBda[19].Top = 616;
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;
            }
        }

        private void RC_Init()
        {
            int i = 0;

            SetImage(pbRCRoute, new Bitmap(clsCommon.ImagePath + clsCommon.nmsGUIUser + " RC 노선도.png"));

            byte cntRcStation = 0;
            byte tmpCntRc = 0;

            switch (clsCommon.nmsGUIUser)
            {
                case "전라선":
                    #region 전라선 RC 통화권 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    cntRC = 18;

                    #region RC 전체 통화권 버튼 정보 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    for (i = 0; i < 14; i++)
                        SetVisible(btRcStation[i], true);

                    for (i = 0; i < 7; i++)
                    {
                        btRcStation[i].Left = i * 156 + 222 + 174;
                        btRcStation[i].Top = 147;
                        btRcStation[13 - i].Left = i * 156 + 222 + 174;
                        btRcStation[13 - i].Top = 527;
                    }

                    SetText(btRcStation[0], "동익산\r\n(RC-3ch)");
                    SetText(btRcStation[1], "삼  례\r\n(RC-3ch)");
                    SetText(btRcStation[2], "동  산\r\n(RC-3ch)");
                    SetText(btRcStation[3], "전  주\r\n(RC-10ch)");
                    SetText(btRcStation[4], "관  촌\r\n(RC-3ch)");
                    SetText(btRcStation[5], "임  실\r\n(RC-3ch)");
                    SetText(btRcStation[6], "오  수\r\n(RC-3ch)");
                    SetText(btRcStation[7], "남  원\r\n(RC-10ch)");
                    SetText(btRcStation[8], "곡  성\r\n(RC-3ch)");
                    SetText(btRcStation[9], "구 례 구\r\n(RC-10ch)");
                    SetText(btRcStation[10], "순  천\r\n(RC-10ch)");
                    SetText(btRcStation[11], "덕  양\r\n(RC-3ch)");
                    SetText(btRcStation[12], "여  천\r\n(RC-3ch)");
                    SetText(btRcStation[13], "여수 엑스포\r\n(RC-3ch)");
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion

                    for (i = 0; i < 14; i++)
                    {
                        rcInfo[i] = new rcButtonInfo();

                        for (int j = 0; j < cntRC; j++)
                            rcInfo[i].rcBtInfo[j].width = 135;
                    }

                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC1.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC1.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC1.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC4.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC5.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC6.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC7.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC8.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC9.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC10.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC11.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC12.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC13.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "전라_RC14.png"));

                    #region RC 상세 통화권 버튼 정보 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "동익산\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 165;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "동익산\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 450;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 1;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "삼  례\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 165;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "삼  례\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 450;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 2;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "동  산\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 165;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "동  산\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 450;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 3;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "전  주\r\nRC-10Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "전  주\r\n(4 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 282;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신  리\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 578;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 5;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "죽림온천\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 841;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 6;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "관  촌\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1185;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "송천중계";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 65;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "아중 1,2";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 220;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "고  덕";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 375;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[3].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신  리";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 529;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 4;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[5].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남관 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 779;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 6;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[5].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "슬치 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 934;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 6;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "슬치 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1123;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "용암 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1278;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "관  촌\r\nRC-5Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "전  주\r\n(4 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 282;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신  리\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 578;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 5;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "관  촌\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 841;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임  실\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1185;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "송천중계";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 65;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "아중 1,2";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 220;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "고  덕";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 375;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[3].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신  리";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 529;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 4;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "슬치 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 779;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "용 암 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 934;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[7].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1202;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임  실\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "관  촌\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 254;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임  실\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오  수\r\n(3 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1090;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "슬치 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 193;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "용 암 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 348;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[7].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 689;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 952;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "대 명 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1107;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 수 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1262;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;
                    
                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오  수\r\nRC-5Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 659;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임  실\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 43;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오  수\r\n(3 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 351;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "서  도\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 659;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 10;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "산  성\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 967;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 11;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남  원\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1275;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 12;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[7].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 60;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 223;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "대 명 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 368;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 수 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 513;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[10].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "인화 1,2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 910;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 11;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[10].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "화 정 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1055;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 11;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[11].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남 원 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1292;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 12;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남  원\r\nRC-5Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "서  도\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 153;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 10;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "산  성\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 498;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 11;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남  원\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 841;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 12;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "곡  성\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1185;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[10].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "인화 1,2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 436;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 11;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[10].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "화 정 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 591;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 11;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[11].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남 원 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 858;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 12;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신기 1,2,3 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1123;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 지 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1278;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    
                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "곡  성\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "주  생\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 254;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 13;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "곡  성\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "압  록\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1090;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[12].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "주 생 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 271;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 13;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신기 1,2,3 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 613;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 지 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 768;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[14].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "송 정 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1031;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[14].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "조 사 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1186;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "구 례 구\r\nRC-5Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 733;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "곡  성\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 117;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "압  록\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 425;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "구 례 구\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 733;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 16;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "괴  목\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1041;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "개  운\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1275;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 18;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신기 1,2,3 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 60;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 지 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 205;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[14].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "송 정 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 368;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[14].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "조 사 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 513;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[15].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남 암 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 676;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 16;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[15].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "외 구 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 821;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 16;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[16].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "병풍 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 984;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[16].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "병풍 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1129;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[17].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "구 만 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1292;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 18;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    
                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "순  천\r\nRC-10Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 733;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "구 례 구\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 117;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 16;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "괴  목\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 425;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "개  운\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 669;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 18;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "순  천\r\n(3 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 977;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 19;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "성  산\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1275;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 20;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[15].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남 암 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 60;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 16;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[15].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "외 구 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 205;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 16;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[16].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "병풍 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 368;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[16].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "병풍 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 513;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[17].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "구 만 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 686;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 18;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[18].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "삼 산 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 849;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 19;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[18].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "조 곡 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 994;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 19;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[18].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "연 향 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1139;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 19;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[19].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "해 룡 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1292;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 20;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    
                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "덕  양\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "성  산\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 254;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 20;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "율  촌\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 21;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "덕  양\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1090;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 22;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[19].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "해 룡 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 271;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 20;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[20].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "발 흥 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 611;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 21;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[20].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = " 율 촌 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 766;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 21;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[21].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "덕 양 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1107;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 22;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여  천\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여  천\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 23;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[22].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여 천 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 689;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 23;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여수 엑스포\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여  천\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 356;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 23;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여수 엑스포\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 988;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 24;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[22].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여 천 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 373;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 23;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[23].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "미 례 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1005;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 24;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;

                    for (i = 0; i < 14; i++)
                    {
                        for (int j = 0; j < cntRC; j++)
                            rcInfo[i].rcBtInfo[j].left += 174;
                    }

                    /*
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "동익산\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 165;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "동익산\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 450;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 1;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "삼  례\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 165;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "삼  례\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 450;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 2;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "동  산\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 165;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "동  산\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 673;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 450;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 3;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "전  주\r\nRC-10Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "전  주\r\n(4 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 282;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신  리\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 578;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 5;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "죽림온천\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 841;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 6;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "관  촌\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1185;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "송천중계";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 65;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "아중 1,2";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 220;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "고  덕";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 375;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[3].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신  리";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 529;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 4;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[5].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남관 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 779;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 6;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[5].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "슬치 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 934;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 6;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "슬치 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1123;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "용암 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1278;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "관  촌\r\nRC-5Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 659;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "전  주\r\n(4 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 193;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 5;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "죽림온천\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 542;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 6;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "관  촌\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 776;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임  실\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 967;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오  수\r\n(3 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1211;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "송천중계";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "아중 1,2";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 141;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "고  덕";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 268;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[3].ruName[3].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신  리";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 395;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 4;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 4;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[5].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남 관 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 495;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 6;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[5].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "슬치 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 622;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 6;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "슬치 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 729;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "용 암 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 856;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[7].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 984;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1101;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "대 명 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1228;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 수 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1355;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;             

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임  실\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "관  촌\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 254;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임  실\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오  수\r\n(3 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1090;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "슬치 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 193;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[6].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "용 암 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 348;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 7;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[7].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 689;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 952;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "대 명 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1107;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 수 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1262;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;
                    
                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오  수\r\nRC-5Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 659;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임  실\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 43;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오  수\r\n(3 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 351;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "서  도\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 659;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 10;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "산  성\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 967;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남  원\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1275;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 10;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[7].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 60;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "임실 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 223;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "대 명 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 368;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[8].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 수 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 513;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[10].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "인화 1,2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 910;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 11;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[10].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "화 정 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1055;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 11;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[11].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남 원 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1292;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 12;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남  원\r\nRC-5Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 659;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "서  도\r\n(0 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 77;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 8;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "산  성\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 368;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 9;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남  원\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 659;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 10;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "주  생\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 950;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 10;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "곡  성\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1241;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[10].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "인화 1,2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 314;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 11;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[10].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "화 정 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 459;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 11;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[11].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남 원 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 676;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 12;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[12].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "주 생 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 967;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 13;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신기 1,2,3 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1184;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 지 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1329;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    
                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "곡  성\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "주  생\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 254;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 13;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "곡  성\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "압  록\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1090;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[12].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "주 생 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 271;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 13;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신기 1,2,3 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 613;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 지 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 768;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[14].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "송 정 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1031;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[14].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "조 사 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1186;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "구 례 구\r\nRC-5Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 733;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "곡  성\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 117;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "압  록\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 425;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "구 례 구\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 733;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 16;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "괴  목\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1041;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "개  운\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1275;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 18;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "신기 1,2,3 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 60;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[13].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "오 지 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 205;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 14;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[14].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "송 정 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 368;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[14].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "조 사 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 513;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 15;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[15].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "남 암 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 676;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 16;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[15].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "내 구 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 821;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 16;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[16].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "병풍 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 984;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[16].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "병풍 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1129;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[17].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "구 만 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1292;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 18;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    
                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "순  천\r\nRC-10Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "괴  목\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 153;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "개  운\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 498;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 18;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "순  천\r\n(3 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 841;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 19;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "성  산\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1185;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 20;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[16].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "병풍 1T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 91;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[16].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "병풍 2T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 246;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 17;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[17].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "구 만 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 515;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 18;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[18].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "삼 산 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 703;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 19;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[18].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "조 곡 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 858;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 19;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[18].ruName[2].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "연 향 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1013;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 19;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 3;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[19].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "해 룡 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1202;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 20;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    
                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "덕  양\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "성  산\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 254;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 20;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "율  촌\r\n(2 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 21;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "덕  양\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1090;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 22;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[19].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "해 룡 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 271;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 20;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[20].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "발 흥 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 611;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 21;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[20].ruName[1].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = " 율 촌 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 766;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 21;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 2;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[21].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "덕 양 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1107;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 22;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여  천\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여  천\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 23;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[22].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여 천 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 689;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 23;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;

                    cntRcStation++;
                    tmpCntRc = 0;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여수 엑스포\r\nRC-3Ch";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 672;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 50;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여  천\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 356;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 23;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여수 엑스포\r\n(1 Ch)";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 135;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 988;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 335;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 24;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 0;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[22].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "여 천 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 373;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 23;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    tmpCntRc++;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = clsCommon.muruName[23].ruName[0].ruName;
                    //rcInfo[cntRcStation].rcBtInfo[tmpCntRc].name = "미 례 T";
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].flagVisibel = true;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].width = 100;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].left = 1005;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].top = 619;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].muID = 24;
                    rcInfo[cntRcStation].rcBtInfo[tmpCntRc].ruID = 1;
                    */
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case "중앙선":
                    #region 중앙선 RC 통화권 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    cntRC = 10;

                    #region RC 전체 통화권 버튼 정보 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    for (i = 0; i < 6; i++)
                        SetVisible(btRcStation[i], true);

                    for (i = 0; i < 3; i++)
                    {
                        btRcStation[i].Left = i * 318 + 350 + 169;
                        btRcStation[i].Top = 147;
                        btRcStation[5 - i].Left = i * 318 + 350 + 169;
                        btRcStation[5 - i].Top = 527;
                    }

                    SetText(btRcStation[0], "지  평");
                    SetText(btRcStation[1], "구  둔");
                    SetText(btRcStation[2], "양  동");
                    SetText(btRcStation[3], "판  대");
                    SetText(btRcStation[4], "서 원 주");
                    SetText(btRcStation[5], "남 원 주");
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion

                    for (i = 0; i < 6; i++)
                    {
                        rcInfo[i] = new rcButtonInfo();

                        for (int j = 0; j < cntRC; j++)
                            rcInfo[i].rcBtInfo[j].width = 135;
                    }

                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "중앙_RC1.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "중앙_RC2.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "중앙_RC3.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "중앙_RC4.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "중앙_RC5.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "중앙_RC6.png"));

                    #region RC 상세 통화권 버튼 정보 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    rcInfo[0].rcBtInfo[0].name = "지 평";
                    rcInfo[0].rcBtInfo[0].flagVisibel = true;
                    rcInfo[0].rcBtInfo[0].left = 672 + 169;
                    rcInfo[0].rcBtInfo[0].top = 49;
                    rcInfo[0].rcBtInfo[1].name = stationList[1];    //석불
                    rcInfo[0].rcBtInfo[1].flagVisibel = true;
                    rcInfo[0].rcBtInfo[1].left = 356 + 169;
                    rcInfo[0].rcBtInfo[1].top = 333;
                    rcInfo[0].rcBtInfo[1].muID = 2;
                    rcInfo[0].rcBtInfo[1].ruID = 0;
                    rcInfo[0].rcBtInfo[2].name = stationList[2];    //구둔
                    rcInfo[0].rcBtInfo[2].flagVisibel = true;
                    rcInfo[0].rcBtInfo[2].left = 988 + 169;
                    rcInfo[0].rcBtInfo[2].top = 333;
                    rcInfo[0].rcBtInfo[2].muID = 3;
                    rcInfo[0].rcBtInfo[2].ruID = 0;
                    rcInfo[0].rcBtInfo[3].name = clsCommon.muruName[2].ruName[0].ruName; //망미 T
                    rcInfo[0].rcBtInfo[3].flagVisibel = true;
                    rcInfo[0].rcBtInfo[3].left = 873 + 169;
                    rcInfo[0].rcBtInfo[3].top = 617;
                    rcInfo[0].rcBtInfo[3].muID = 3;
                    rcInfo[0].rcBtInfo[3].ruID = 1;
                    rcInfo[0].rcBtInfo[4].name = clsCommon.muruName[2].ruName[1].ruName; //지제 T
                    rcInfo[0].rcBtInfo[4].flagVisibel = true;
                    rcInfo[0].rcBtInfo[4].left = 1104 + 169;
                    rcInfo[0].rcBtInfo[4].top = 617;
                    rcInfo[0].rcBtInfo[4].muID = 3;
                    rcInfo[0].rcBtInfo[4].ruID = 2;

                    rcInfo[1].rcBtInfo[0].name = "구 둔";
                    rcInfo[1].rcBtInfo[0].flagVisibel = true;
                    rcInfo[1].rcBtInfo[0].left = 672 + 169;
                    rcInfo[1].rcBtInfo[0].top = 49;
                    rcInfo[1].rcBtInfo[1].name = stationList[1];    //석불
                    rcInfo[1].rcBtInfo[1].flagVisibel = true;
                    rcInfo[1].rcBtInfo[1].left = 254 + 169;
                    rcInfo[1].rcBtInfo[1].top = 333;
                    rcInfo[1].rcBtInfo[1].muID = 2;
                    rcInfo[1].rcBtInfo[1].ruID = 0;
                    rcInfo[1].rcBtInfo[2].name = stationList[2];    //구둔
                    rcInfo[1].rcBtInfo[2].flagVisibel = true;
                    rcInfo[1].rcBtInfo[2].left = 672 + 169;
                    rcInfo[1].rcBtInfo[2].top = 333;
                    rcInfo[1].rcBtInfo[2].muID = 3;
                    rcInfo[1].rcBtInfo[2].ruID = 0;
                    rcInfo[1].rcBtInfo[3].name = stationList[3];    //매곡
                    rcInfo[1].rcBtInfo[3].flagVisibel = true;
                    rcInfo[1].rcBtInfo[3].left = 1090 + 169;
                    rcInfo[1].rcBtInfo[3].top = 333;
                    rcInfo[1].rcBtInfo[3].muID = 4;
                    rcInfo[1].rcBtInfo[3].ruID = 0;
                    rcInfo[1].rcBtInfo[4].name = clsCommon.muruName[2].ruName[0].ruName; //망미 T
                    rcInfo[1].rcBtInfo[4].flagVisibel = true;
                    rcInfo[1].rcBtInfo[4].left = 596 + 169;
                    rcInfo[1].rcBtInfo[4].top = 617;
                    rcInfo[1].rcBtInfo[4].muID = 3;
                    rcInfo[1].rcBtInfo[4].ruID = 1;
                    rcInfo[1].rcBtInfo[5].name = clsCommon.muruName[2].ruName[1].ruName; //지제 T
                    rcInfo[1].rcBtInfo[5].flagVisibel = true;
                    rcInfo[1].rcBtInfo[5].left = 751 + 169;
                    rcInfo[1].rcBtInfo[5].top = 617;
                    rcInfo[1].rcBtInfo[5].muID = 3;
                    rcInfo[1].rcBtInfo[5].ruID = 2;

                    rcInfo[2].rcBtInfo[0].name = "양 동";
                    rcInfo[2].rcBtInfo[0].flagVisibel = true;
                    rcInfo[2].rcBtInfo[0].left = 672 + 169;
                    rcInfo[2].rcBtInfo[0].top = 49;
                    rcInfo[2].rcBtInfo[1].name = stationList[3];    //매곡
                    rcInfo[2].rcBtInfo[1].flagVisibel = true;
                    rcInfo[2].rcBtInfo[1].left = 254 + 169;
                    rcInfo[2].rcBtInfo[1].top = 333;
                    rcInfo[2].rcBtInfo[1].muID = 4;
                    rcInfo[2].rcBtInfo[1].ruID = 0;
                    rcInfo[2].rcBtInfo[2].name = stationList[4];    //양동
                    rcInfo[2].rcBtInfo[2].flagVisibel = true;
                    rcInfo[2].rcBtInfo[2].left = 672 + 169;
                    rcInfo[2].rcBtInfo[2].top = 333;
                    rcInfo[2].rcBtInfo[2].muID = 5;
                    rcInfo[2].rcBtInfo[2].ruID = 0;
                    rcInfo[2].rcBtInfo[3].name = stationList[5];    //판대
                    rcInfo[2].rcBtInfo[3].flagVisibel = true;
                    rcInfo[2].rcBtInfo[3].left = 1090 + 169;
                    rcInfo[2].rcBtInfo[3].top = 333;
                    rcInfo[2].rcBtInfo[3].muID = 6;
                    rcInfo[2].rcBtInfo[3].ruID = 0;
                    rcInfo[2].rcBtInfo[4].name = clsCommon.muruName[4].ruName[0].ruName; //삼산 T
                    rcInfo[2].rcBtInfo[4].flagVisibel = true;
                    rcInfo[2].rcBtInfo[4].left = 672 + 169;
                    rcInfo[2].rcBtInfo[4].top = 617;
                    rcInfo[2].rcBtInfo[4].muID = 5;
                    rcInfo[2].rcBtInfo[4].ruID = 1;
                    rcInfo[2].rcBtInfo[5].name = clsCommon.muruName[5].ruName[0].ruName; //판대 T
                    rcInfo[2].rcBtInfo[5].flagVisibel = true;
                    rcInfo[2].rcBtInfo[5].left = 1090 + 169;
                    rcInfo[2].rcBtInfo[5].top = 617;
                    rcInfo[2].rcBtInfo[5].muID = 6;
                    rcInfo[2].rcBtInfo[5].ruID = 1;

                    rcInfo[3].rcBtInfo[0].name = "판 대";
                    rcInfo[3].rcBtInfo[0].flagVisibel = true;
                    rcInfo[3].rcBtInfo[0].left = 672 + 169;
                    rcInfo[3].rcBtInfo[0].top = 49;
                    rcInfo[3].rcBtInfo[1].name = stationList[5];    //판대
                    rcInfo[3].rcBtInfo[1].flagVisibel = true;
                    rcInfo[3].rcBtInfo[1].left = 672 + 169;
                    rcInfo[3].rcBtInfo[1].top = 333;
                    rcInfo[3].rcBtInfo[1].muID = 6;
                    rcInfo[3].rcBtInfo[1].ruID = 0;
                    rcInfo[3].rcBtInfo[2].name = clsCommon.muruName[5].ruName[0].ruName; //판대 T
                    rcInfo[3].rcBtInfo[2].flagVisibel = true;
                    rcInfo[3].rcBtInfo[2].left = 672 + 169;
                    rcInfo[3].rcBtInfo[2].top = 617;
                    rcInfo[3].rcBtInfo[2].muID = 6;
                    rcInfo[3].rcBtInfo[2].ruID = 1;

                    rcInfo[4].rcBtInfo[0].name = "서원주";
                    rcInfo[4].rcBtInfo[0].flagVisibel = true;
                    rcInfo[4].rcBtInfo[0].left = 606 + 169;
                    rcInfo[4].rcBtInfo[0].top = 49;
                    rcInfo[4].rcBtInfo[1].name = stationList[5];    //판대
                    rcInfo[4].rcBtInfo[1].flagVisibel = true;
                    rcInfo[4].rcBtInfo[1].left = 188 + 169;
                    rcInfo[4].rcBtInfo[1].top = 333;
                    rcInfo[4].rcBtInfo[1].muID = 6;
                    rcInfo[4].rcBtInfo[1].ruID = 0;
                    rcInfo[4].rcBtInfo[2].name = stationList[6];    //서원주
                    rcInfo[4].rcBtInfo[2].flagVisibel = true;
                    rcInfo[4].rcBtInfo[2].left = 606 + 169;
                    rcInfo[4].rcBtInfo[2].top = 333;
                    rcInfo[4].rcBtInfo[2].muID = 7;
                    rcInfo[4].rcBtInfo[2].ruID = 0;
                    rcInfo[4].rcBtInfo[3].name = stationList[7];    //남원주
                    rcInfo[4].rcBtInfo[3].flagVisibel = true;
                    rcInfo[4].rcBtInfo[3].left = 1144 + 169;
                    rcInfo[4].rcBtInfo[3].top = 333;
                    rcInfo[4].rcBtInfo[3].muID = 8;
                    rcInfo[4].rcBtInfo[3].ruID = 0;
                    rcInfo[4].rcBtInfo[4].name = clsCommon.muruName[5].ruName[0].ruName; //판대 T
                    rcInfo[4].rcBtInfo[4].flagVisibel = true;
                    rcInfo[4].rcBtInfo[4].left = 188 + 169;
                    rcInfo[4].rcBtInfo[4].top = 617;
                    rcInfo[4].rcBtInfo[4].muID = 6;
                    rcInfo[4].rcBtInfo[4].ruID = 1;
                    rcInfo[4].rcBtInfo[5].name = clsCommon.muruName[6].ruName[0].ruName; //장지 T
                    rcInfo[4].rcBtInfo[5].flagVisibel = true;
                    rcInfo[4].rcBtInfo[5].left = 375 + 169;
                    rcInfo[4].rcBtInfo[5].top = 617;
                    rcInfo[4].rcBtInfo[5].muID = 7;
                    rcInfo[4].rcBtInfo[5].ruID = 1;
                    rcInfo[4].rcBtInfo[6].name = clsCommon.muruName[6].ruName[1].ruName; //원대 T
                    rcInfo[4].rcBtInfo[6].flagVisibel = true;
                    rcInfo[4].rcBtInfo[6].left = 606 + 169;
                    rcInfo[4].rcBtInfo[6].top = 617;
                    rcInfo[4].rcBtInfo[6].muID = 7;
                    rcInfo[4].rcBtInfo[6].ruID = 2;
                    rcInfo[4].rcBtInfo[7].name = clsCommon.muruName[6].ruName[2].ruName; //동화 T
                    rcInfo[4].rcBtInfo[7].flagVisibel = true;
                    rcInfo[4].rcBtInfo[7].left = 840 + 169;
                    rcInfo[4].rcBtInfo[7].top = 617;
                    rcInfo[4].rcBtInfo[7].muID = 7;
                    rcInfo[4].rcBtInfo[7].ruID = 3;
                    rcInfo[4].rcBtInfo[8].name = clsCommon.muruName[7].ruName[0].ruName; //사제 1T
                    rcInfo[4].rcBtInfo[8].flagVisibel = true;
                    rcInfo[4].rcBtInfo[8].left = 1027 + 169;
                    rcInfo[4].rcBtInfo[8].top = 617;
                    rcInfo[4].rcBtInfo[8].muID = 8;
                    rcInfo[4].rcBtInfo[8].ruID = 1;
                    rcInfo[4].rcBtInfo[9].name = clsCommon.muruName[7].ruName[1].ruName; //사제 2T
                    rcInfo[4].rcBtInfo[9].flagVisibel = true;
                    rcInfo[4].rcBtInfo[9].left = 1261 + 169;
                    rcInfo[4].rcBtInfo[9].top = 617;
                    rcInfo[4].rcBtInfo[9].muID = 8;
                    rcInfo[4].rcBtInfo[9].ruID = 2;

                    rcInfo[5].rcBtInfo[0].name = "남원주";
                    rcInfo[5].rcBtInfo[0].flagVisibel = true;
                    rcInfo[5].rcBtInfo[0].left = 672 + 169;
                    rcInfo[5].rcBtInfo[0].top = 49;
                    rcInfo[5].rcBtInfo[1].name = stationList[7];    //남원주
                    rcInfo[5].rcBtInfo[1].flagVisibel = true;
                    rcInfo[5].rcBtInfo[1].left = 672 + 169;
                    rcInfo[5].rcBtInfo[1].top = 333;
                    rcInfo[5].rcBtInfo[1].muID = 8;
                    rcInfo[5].rcBtInfo[1].ruID = 0;
                    rcInfo[5].rcBtInfo[2].name = clsCommon.muruName[7].ruName[0].ruName; //사제 1T
                    rcInfo[5].rcBtInfo[2].flagVisibel = true;
                    rcInfo[5].rcBtInfo[2].left = 596 + 169;
                    rcInfo[5].rcBtInfo[2].top = 617;
                    rcInfo[5].rcBtInfo[2].muID = 8;
                    rcInfo[5].rcBtInfo[2].ruID = 1;
                    rcInfo[5].rcBtInfo[3].name = clsCommon.muruName[7].ruName[1].ruName; //사제 2T
                    rcInfo[5].rcBtInfo[3].flagVisibel = true;
                    rcInfo[5].rcBtInfo[3].left = 751 + 169;
                    rcInfo[5].rcBtInfo[3].top = 617;
                    rcInfo[5].rcBtInfo[3].muID = 8;
                    rcInfo[5].rcBtInfo[3].ruID = 2;
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case "경춘선":
                    #region 경춘선 RC 통화권 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    cntRC = 24;

                    #region RC 전체 통화권 버튼 정보 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    for (i = 0; i < 10; i++)
                    {
                        SetVisible(btRcStation[i], true);
                        btRcStation[i].Width = 100;
                    }

                    for (i = 0; i < 5; i++)
                    {
                        btRcStation[i].Left = i * 158 + 123;
                        btRcStation[i].Top = 165;
                        btRcStation[9 - i].Left = i * 158 + 123;
                        btRcStation[9 - i].Top = 545;
                    }

                    SetText(btRcStation[0], "망  우");
                    SetText(btRcStation[1], "퇴계원");
                    SetText(btRcStation[2], "평내호평");
                    SetText(btRcStation[3], "마  석");
                    SetText(btRcStation[4], "청  평");
                    SetText(btRcStation[5], "가  평");
                    SetText(btRcStation[6], "강  촌");
                    SetText(btRcStation[7], "김유정");
                    SetText(btRcStation[8], "남춘천");
                    SetText(btRcStation[9], "춘  천");
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion

                    for (i = 0; i < 10; i++)
                        rcInfo[i] = new rcButtonInfo();

                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "경춘_RC1.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "경춘_RC2.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "경춘_RC3.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "경춘_RC4.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "경춘_RC5.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "경춘_RC6.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "경춘_RC7.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "경춘_RC8.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "경춘_RC9.png"));
                    rcBitMap.Add(new Bitmap(clsCommon.ImagePath + "경춘_RC10.png"));

                    #region RC 상세 통화권 버튼 정보 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    rcInfo[0].rcBtInfo[0].name = "망  우";
                    rcInfo[0].rcBtInfo[0].flagVisibel = true;
                    rcInfo[0].rcBtInfo[0].width = 135;
                    rcInfo[0].rcBtInfo[0].left = 422;
                    rcInfo[0].rcBtInfo[0].top = 72;
                    rcInfo[0].rcBtInfo[1].name = stationList[0];    //갈매
                    rcInfo[0].rcBtInfo[1].flagVisibel = true;
                    rcInfo[0].rcBtInfo[1].width = 135;
                    rcInfo[0].rcBtInfo[1].left = 422;
                    rcInfo[0].rcBtInfo[1].top = 325;
                    rcInfo[0].rcBtInfo[1].muID = 1;
                    rcInfo[0].rcBtInfo[1].ruID = 0;
                    rcInfo[0].rcBtInfo[2].name = clsCommon.muruName[0].ruName[0].ruName;     //구능1T
                    rcInfo[0].rcBtInfo[2].flagVisibel = true;
                    rcInfo[0].rcBtInfo[2].width = 100;
                    rcInfo[0].rcBtInfo[2].left = 364;
                    rcInfo[0].rcBtInfo[2].top = 579;
                    rcInfo[0].rcBtInfo[2].muID = 1;
                    rcInfo[0].rcBtInfo[2].ruID = 1;
                    rcInfo[0].rcBtInfo[3].name = clsCommon.muruName[0].ruName[1].ruName;     //구능2T
                    rcInfo[0].rcBtInfo[3].flagVisibel = true;
                    rcInfo[0].rcBtInfo[3].width = 100;
                    rcInfo[0].rcBtInfo[3].left = 507;
                    rcInfo[0].rcBtInfo[3].top = 579;
                    rcInfo[0].rcBtInfo[3].muID = 1;
                    rcInfo[0].rcBtInfo[3].ruID = 2;

                    rcInfo[1].rcBtInfo[0].name = "퇴계원";
                    rcInfo[1].rcBtInfo[0].flagVisibel = true;
                    rcInfo[1].rcBtInfo[0].width = 135;
                    rcInfo[1].rcBtInfo[0].left = 422;
                    rcInfo[1].rcBtInfo[0].top = 72;
                    rcInfo[1].rcBtInfo[1].name = stationList[0];    //갈매
                    rcInfo[1].rcBtInfo[1].flagVisibel = true;
                    rcInfo[1].rcBtInfo[1].width = 135;
                    rcInfo[1].rcBtInfo[1].left = 135;
                    rcInfo[1].rcBtInfo[1].top = 325;
                    rcInfo[1].rcBtInfo[1].muID = 1;
                    rcInfo[1].rcBtInfo[1].ruID = 0;
                    rcInfo[1].rcBtInfo[2].name = stationList[1];    //퇴계원
                    rcInfo[1].rcBtInfo[2].flagVisibel = true;
                    rcInfo[1].rcBtInfo[2].width = 135;
                    rcInfo[1].rcBtInfo[2].left = 326;
                    rcInfo[1].rcBtInfo[2].top = 325;
                    rcInfo[1].rcBtInfo[2].muID = 2;
                    rcInfo[1].rcBtInfo[2].ruID = 0;
                    rcInfo[1].rcBtInfo[3].name = stationList[2];    //사릉
                    rcInfo[1].rcBtInfo[3].flagVisibel = true;
                    rcInfo[1].rcBtInfo[3].width = 135;
                    rcInfo[1].rcBtInfo[3].left = 517;
                    rcInfo[1].rcBtInfo[3].top = 325;
                    rcInfo[1].rcBtInfo[3].muID = 3;
                    rcInfo[1].rcBtInfo[3].ruID = 0;
                    rcInfo[1].rcBtInfo[4].name = stationList[3];    //금곡
                    rcInfo[1].rcBtInfo[4].flagVisibel = true;
                    rcInfo[1].rcBtInfo[4].width = 135;
                    rcInfo[1].rcBtInfo[4].left = 708;
                    rcInfo[1].rcBtInfo[4].top = 325;
                    rcInfo[1].rcBtInfo[4].muID = 4;
                    rcInfo[1].rcBtInfo[4].ruID = 0;
                    rcInfo[1].rcBtInfo[5].name = clsCommon.muruName[0].ruName[0].ruName;     //구능1T
                    rcInfo[1].rcBtInfo[5].flagVisibel = true;
                    rcInfo[1].rcBtInfo[5].width = 100;
                    rcInfo[1].rcBtInfo[5].left = 76;
                    rcInfo[1].rcBtInfo[5].top = 579;
                    rcInfo[1].rcBtInfo[5].muID = 1;
                    rcInfo[1].rcBtInfo[5].ruID = 1;
                    rcInfo[1].rcBtInfo[6].name = clsCommon.muruName[0].ruName[1].ruName;     //구능2T
                    rcInfo[1].rcBtInfo[6].flagVisibel = true;
                    rcInfo[1].rcBtInfo[6].width = 100;
                    rcInfo[1].rcBtInfo[6].left = 219;
                    rcInfo[1].rcBtInfo[6].top = 579;
                    rcInfo[1].rcBtInfo[6].muID = 1;
                    rcInfo[1].rcBtInfo[6].ruID = 2;
                    rcInfo[1].rcBtInfo[7].name = clsCommon.muruName[3].ruName[0].ruName;     //오룡T
                    rcInfo[1].rcBtInfo[7].flagVisibel = true;
                    rcInfo[1].rcBtInfo[7].width = 100;
                    rcInfo[1].rcBtInfo[7].left = 725;
                    rcInfo[1].rcBtInfo[7].top = 579;
                    rcInfo[1].rcBtInfo[7].muID = 4;
                    rcInfo[1].rcBtInfo[7].ruID = 1;
                    
                    rcInfo[2].rcBtInfo[0].name = "평내호평";
                    rcInfo[2].rcBtInfo[0].flagVisibel = true;
                    rcInfo[2].rcBtInfo[0].width = 135;
                    rcInfo[2].rcBtInfo[0].left = 422;
                    rcInfo[2].rcBtInfo[0].top = 45;
                    rcInfo[2].rcBtInfo[1].name = stationList[3];    //금곡
                    rcInfo[2].rcBtInfo[1].flagVisibel = true;
                    rcInfo[2].rcBtInfo[1].width = 135;
                    rcInfo[2].rcBtInfo[1].left = 7;
                    rcInfo[2].rcBtInfo[1].top = 258;
                    rcInfo[2].rcBtInfo[1].muID = 4;
                    rcInfo[2].rcBtInfo[1].ruID = 0;
                    rcInfo[2].rcBtInfo[2].name = stationList[4];    //평내호평
                    rcInfo[2].rcBtInfo[2].flagVisibel = true;
                    rcInfo[2].rcBtInfo[2].width = 135;
                    rcInfo[2].rcBtInfo[2].left = 171;
                    rcInfo[2].rcBtInfo[2].top = 258;
                    rcInfo[2].rcBtInfo[2].muID = 5;
                    rcInfo[2].rcBtInfo[2].ruID = 0;
                    rcInfo[2].rcBtInfo[3].name = stationList[5];    //마  석
                    rcInfo[2].rcBtInfo[3].flagVisibel = true;
                    rcInfo[2].rcBtInfo[3].width = 135;
                    rcInfo[2].rcBtInfo[3].left = 362;
                    rcInfo[2].rcBtInfo[3].top = 258;
                    rcInfo[2].rcBtInfo[3].muID = 6;
                    rcInfo[2].rcBtInfo[3].ruID = 0;
                    rcInfo[2].rcBtInfo[4].name = stationList[6];    //대성리
                    rcInfo[2].rcBtInfo[4].flagVisibel = true;
                    rcInfo[2].rcBtInfo[4].width = 135;
                    rcInfo[2].rcBtInfo[4].left = 529;
                    rcInfo[2].rcBtInfo[4].top = 258;
                    rcInfo[2].rcBtInfo[4].muID = 7;
                    rcInfo[2].rcBtInfo[4].ruID = 0;
                    rcInfo[2].rcBtInfo[5].name = stationList[7];    //청평
                    rcInfo[2].rcBtInfo[5].flagVisibel = true;
                    rcInfo[2].rcBtInfo[5].width = 135;
                    rcInfo[2].rcBtInfo[5].left = 695;
                    rcInfo[2].rcBtInfo[5].top = 258;
                    rcInfo[2].rcBtInfo[5].muID = 8;
                    rcInfo[2].rcBtInfo[5].ruID = 0;
                    rcInfo[2].rcBtInfo[6].name = clsCommon.muruName[3].ruName[0].ruName;     //어룡T
                    rcInfo[2].rcBtInfo[6].flagVisibel = true;
                    rcInfo[2].rcBtInfo[6].width = 100;
                    rcInfo[2].rcBtInfo[6].left = 24;
                    rcInfo[2].rcBtInfo[6].top = 468;
                    rcInfo[2].rcBtInfo[6].muID = 4;
                    rcInfo[2].rcBtInfo[6].ruID = 1;
                    rcInfo[2].rcBtInfo[7].name = clsCommon.muruName[4].ruName[0].ruName;     //마치T
                    rcInfo[2].rcBtInfo[7].flagVisibel = true;
                    rcInfo[2].rcBtInfo[7].width = 100;
                    rcInfo[2].rcBtInfo[7].left = 188;
                    rcInfo[2].rcBtInfo[7].top = 468;
                    rcInfo[2].rcBtInfo[7].muID = 5;
                    rcInfo[2].rcBtInfo[7].ruID = 1;
                    rcInfo[2].rcBtInfo[8].name = clsCommon.muruName[5].ruName[0].ruName;     //마석T
                    rcInfo[2].rcBtInfo[8].flagVisibel = true;
                    rcInfo[2].rcBtInfo[8].width = 100;
                    rcInfo[2].rcBtInfo[8].left = 303;
                    rcInfo[2].rcBtInfo[8].top = 468;
                    rcInfo[2].rcBtInfo[8].muID = 6;
                    rcInfo[2].rcBtInfo[8].ruID = 1;
                    rcInfo[2].rcBtInfo[9].name = clsCommon.muruName[5].ruName[1].ruName;     //답내T
                    rcInfo[2].rcBtInfo[9].flagVisibel = true;
                    rcInfo[2].rcBtInfo[9].width = 100;
                    rcInfo[2].rcBtInfo[9].left = 448;
                    rcInfo[2].rcBtInfo[9].top = 468;
                    rcInfo[2].rcBtInfo[9].muID = 6;
                    rcInfo[2].rcBtInfo[9].ruID = 2;
                    rcInfo[2].rcBtInfo[10].name = clsCommon.muruName[7].ruName[0].ruName;    //대성1T
                    rcInfo[2].rcBtInfo[10].flagVisibel = true;
                    rcInfo[2].rcBtInfo[10].width = 100;
                    rcInfo[2].rcBtInfo[10].left = 568;
                    rcInfo[2].rcBtInfo[10].top = 468;
                    rcInfo[2].rcBtInfo[10].muID = 8;
                    rcInfo[2].rcBtInfo[10].ruID = 1;
                    rcInfo[2].rcBtInfo[11].name = clsCommon.muruName[7].ruName[1].ruName;    //청평T
                    rcInfo[2].rcBtInfo[11].flagVisibel = true;
                    rcInfo[2].rcBtInfo[11].width = 100;
                    rcInfo[2].rcBtInfo[11].left = 713;
                    rcInfo[2].rcBtInfo[11].top = 468;
                    rcInfo[2].rcBtInfo[11].muID = 8;
                    rcInfo[2].rcBtInfo[11].ruID = 2;
                    rcInfo[2].rcBtInfo[12].name = clsCommon.muruName[7].ruName[2].ruName;    //유답촌T
                    rcInfo[2].rcBtInfo[12].flagVisibel = true;
                    rcInfo[2].rcBtInfo[12].width = 100;
                    rcInfo[2].rcBtInfo[12].left = 858;
                    rcInfo[2].rcBtInfo[12].top = 468;
                    rcInfo[2].rcBtInfo[12].muID = 8;
                    rcInfo[2].rcBtInfo[12].ruID = 3;
                    rcInfo[2].rcBtInfo[13].name = "BDA 1";          //평내호평의 마치T - BDA 1/2/3
                    rcInfo[2].rcBtInfo[13].flagVisibel = true;
                    rcInfo[2].rcBtInfo[13].width = 70;
                    rcInfo[2].rcBtInfo[13].left = 123;
                    rcInfo[2].rcBtInfo[13].top = 637;
                    rcInfo[2].rcBtInfo[13].muID = 5;
                    rcInfo[2].rcBtInfo[13].ruID = 1;
                    rcInfo[2].rcBtInfo[14].name = "BDA 2";
                    rcInfo[2].rcBtInfo[14].flagVisibel = true;
                    rcInfo[2].rcBtInfo[14].width = 70;
                    rcInfo[2].rcBtInfo[14].left = 203;
                    rcInfo[2].rcBtInfo[14].top = 637;
                    rcInfo[2].rcBtInfo[14].muID = 5;
                    rcInfo[2].rcBtInfo[14].ruID = 1;
                    rcInfo[2].rcBtInfo[15].name = "BDA 3";
                    rcInfo[2].rcBtInfo[15].flagVisibel = true;
                    rcInfo[2].rcBtInfo[15].width = 70;
                    rcInfo[2].rcBtInfo[15].left = 284;
                    rcInfo[2].rcBtInfo[15].top = 637;
                    rcInfo[2].rcBtInfo[15].muID = 5;
                    rcInfo[2].rcBtInfo[15].ruID = 1;
                    rcInfo[2].rcBtInfo[16].name = "BDA 1";          //마석의 답내T - BDA 1/2/3
                    rcInfo[2].rcBtInfo[16].flagVisibel = true;
                    rcInfo[2].rcBtInfo[16].width = 70;
                    rcInfo[2].rcBtInfo[16].left = 383;
                    rcInfo[2].rcBtInfo[16].top = 637;
                    rcInfo[2].rcBtInfo[16].muID = 6;
                    rcInfo[2].rcBtInfo[16].ruID = 2;
                    rcInfo[2].rcBtInfo[17].name = "BDA 2";
                    rcInfo[2].rcBtInfo[17].flagVisibel = true;
                    rcInfo[2].rcBtInfo[17].width = 70;
                    rcInfo[2].rcBtInfo[17].left = 463;
                    rcInfo[2].rcBtInfo[17].top = 637;
                    rcInfo[2].rcBtInfo[17].muID = 6;
                    rcInfo[2].rcBtInfo[17].ruID = 2;
                    rcInfo[2].rcBtInfo[18].name = "BDA 3";
                    rcInfo[2].rcBtInfo[18].flagVisibel = true;
                    rcInfo[2].rcBtInfo[18].width = 70;
                    rcInfo[2].rcBtInfo[18].left = 544;
                    rcInfo[2].rcBtInfo[18].top = 637;
                    rcInfo[2].rcBtInfo[18].muID = 6;
                    rcInfo[2].rcBtInfo[18].ruID = 2;
                    rcInfo[2].rcBtInfo[19].name = "BDA 1";          //청평의 대성1T - BDA 1/2
                    rcInfo[2].rcBtInfo[19].flagVisibel = true;
                    rcInfo[2].rcBtInfo[19].width = 70;
                    rcInfo[2].rcBtInfo[19].left = 636;
                    rcInfo[2].rcBtInfo[19].top = 637;
                    rcInfo[2].rcBtInfo[19].muID = 8;
                    rcInfo[2].rcBtInfo[19].ruID = 1;
                    rcInfo[2].rcBtInfo[20].name = "BDA 2";
                    rcInfo[2].rcBtInfo[20].flagVisibel = true;
                    rcInfo[2].rcBtInfo[20].width = 70;
                    rcInfo[2].rcBtInfo[20].left = 717;
                    rcInfo[2].rcBtInfo[20].top = 637;
                    rcInfo[2].rcBtInfo[20].muID = 8;
                    rcInfo[2].rcBtInfo[20].ruID = 1;
                    rcInfo[2].rcBtInfo[21].name = "BDA 1";          //청평의 유답촌T - BDA 1
                    rcInfo[2].rcBtInfo[21].flagVisibel = true;
                    rcInfo[2].rcBtInfo[21].width = 70;
                    rcInfo[2].rcBtInfo[21].left = 874;
                    rcInfo[2].rcBtInfo[21].top = 637;
                    rcInfo[2].rcBtInfo[21].muID = 8;
                    rcInfo[2].rcBtInfo[21].ruID = 3;
                                        
                    rcInfo[3].rcBtInfo[0].name = "마  석";
                    rcInfo[3].rcBtInfo[0].flagVisibel = true;
                    rcInfo[3].rcBtInfo[0].width = 135;
                    rcInfo[3].rcBtInfo[0].left = 422;
                    rcInfo[3].rcBtInfo[0].top = 45;
                    rcInfo[3].rcBtInfo[1].name = stationList[4];    //평내호평
                    rcInfo[3].rcBtInfo[1].flagVisibel = true;
                    rcInfo[3].rcBtInfo[1].width = 135;
                    rcInfo[3].rcBtInfo[1].left = 170;
                    rcInfo[3].rcBtInfo[1].top = 258;
                    rcInfo[3].rcBtInfo[1].muID = 5;
                    rcInfo[3].rcBtInfo[1].ruID = 0;
                    rcInfo[3].rcBtInfo[2].name = stationList[5];    //마  석
                    rcInfo[3].rcBtInfo[2].flagVisibel = true;
                    rcInfo[3].rcBtInfo[2].width = 135;
                    rcInfo[3].rcBtInfo[2].left = 422;
                    rcInfo[3].rcBtInfo[2].top = 258;
                    rcInfo[3].rcBtInfo[2].muID = 6;
                    rcInfo[3].rcBtInfo[2].ruID = 0;
                    rcInfo[3].rcBtInfo[3].name = stationList[6];    //대성리
                    rcInfo[3].rcBtInfo[3].flagVisibel = true;
                    rcInfo[3].rcBtInfo[3].width = 135;
                    rcInfo[3].rcBtInfo[3].left = 675;
                    rcInfo[3].rcBtInfo[3].top = 258;
                    rcInfo[3].rcBtInfo[3].muID = 7;
                    rcInfo[3].rcBtInfo[3].ruID = 0;                    
                    rcInfo[3].rcBtInfo[4].name = clsCommon.muruName[4].ruName[0].ruName;     //마치 T
                    rcInfo[3].rcBtInfo[4].flagVisibel = true;
                    rcInfo[3].rcBtInfo[4].width = 100;
                    rcInfo[3].rcBtInfo[4].left = 188;
                    rcInfo[3].rcBtInfo[4].top = 468;
                    rcInfo[3].rcBtInfo[4].muID = 5;
                    rcInfo[3].rcBtInfo[4].ruID = 1;
                    rcInfo[3].rcBtInfo[5].name = clsCommon.muruName[5].ruName[0].ruName;     //마석 T
                    rcInfo[3].rcBtInfo[5].flagVisibel = true;
                    rcInfo[3].rcBtInfo[5].width = 100;
                    rcInfo[3].rcBtInfo[5].left = 363;
                    rcInfo[3].rcBtInfo[5].top = 468;
                    rcInfo[3].rcBtInfo[5].muID = 6;
                    rcInfo[3].rcBtInfo[5].ruID = 1;
                    rcInfo[3].rcBtInfo[6].name = clsCommon.muruName[5].ruName[1].ruName;     //답내 T
                    rcInfo[3].rcBtInfo[6].flagVisibel = true;
                    rcInfo[3].rcBtInfo[6].width = 100;
                    rcInfo[3].rcBtInfo[6].left = 508;
                    rcInfo[3].rcBtInfo[6].top = 468;
                    rcInfo[3].rcBtInfo[6].muID = 6;
                    rcInfo[3].rcBtInfo[6].ruID = 2;
                    rcInfo[3].rcBtInfo[7].name = "BDA 1";          //평내호평의 마치T - BDA 1/2/3
                    rcInfo[3].rcBtInfo[7].flagVisibel = true;
                    rcInfo[3].rcBtInfo[7].width = 70;
                    rcInfo[3].rcBtInfo[7].left = 123;
                    rcInfo[3].rcBtInfo[7].top = 637;
                    rcInfo[3].rcBtInfo[7].muID = 5;
                    rcInfo[3].rcBtInfo[7].ruID = 1;
                    rcInfo[3].rcBtInfo[8].name = "BDA 2";
                    rcInfo[3].rcBtInfo[8].flagVisibel = true;
                    rcInfo[3].rcBtInfo[8].width = 70;
                    rcInfo[3].rcBtInfo[8].left = 203;
                    rcInfo[3].rcBtInfo[8].top = 637;
                    rcInfo[3].rcBtInfo[8].muID = 5;
                    rcInfo[3].rcBtInfo[8].ruID = 1;
                    rcInfo[3].rcBtInfo[9].name = "BDA 3";
                    rcInfo[3].rcBtInfo[9].flagVisibel = true;
                    rcInfo[3].rcBtInfo[9].width = 70;
                    rcInfo[3].rcBtInfo[9].left = 284;
                    rcInfo[3].rcBtInfo[9].top = 637;
                    rcInfo[3].rcBtInfo[9].muID = 5;
                    rcInfo[3].rcBtInfo[9].ruID = 1;
                    rcInfo[3].rcBtInfo[10].name = "BDA 1";          //마석의 답내T - BDA 1/2/3
                    rcInfo[3].rcBtInfo[10].flagVisibel = true;
                    rcInfo[3].rcBtInfo[10].width = 70;
                    rcInfo[3].rcBtInfo[10].left = 443;
                    rcInfo[3].rcBtInfo[10].top = 637;
                    rcInfo[3].rcBtInfo[10].muID = 6;
                    rcInfo[3].rcBtInfo[10].ruID = 2;
                    rcInfo[3].rcBtInfo[11].name = "BDA 2";
                    rcInfo[3].rcBtInfo[11].flagVisibel = true;
                    rcInfo[3].rcBtInfo[11].width = 70;
                    rcInfo[3].rcBtInfo[11].left = 523;
                    rcInfo[3].rcBtInfo[11].top = 637;
                    rcInfo[3].rcBtInfo[11].muID = 6;
                    rcInfo[3].rcBtInfo[11].ruID = 2;
                    rcInfo[3].rcBtInfo[12].name = "BDA 3";
                    rcInfo[3].rcBtInfo[12].flagVisibel = true;
                    rcInfo[3].rcBtInfo[12].width = 70;
                    rcInfo[3].rcBtInfo[12].left = 604;
                    rcInfo[3].rcBtInfo[12].top = 637;
                    rcInfo[3].rcBtInfo[12].muID = 6;
                    rcInfo[3].rcBtInfo[12].ruID = 2;

                    rcInfo[4].rcBtInfo[0].name = "청  평";
                    rcInfo[4].rcBtInfo[0].flagVisibel = true;
                    rcInfo[4].rcBtInfo[0].width = 135;
                    rcInfo[4].rcBtInfo[0].left = 422;
                    rcInfo[4].rcBtInfo[0].top = 45;
                    rcInfo[4].rcBtInfo[1].name = stationList[6];    //대성리
                    rcInfo[4].rcBtInfo[1].flagVisibel = true;
                    rcInfo[4].rcBtInfo[1].width = 135;
                    rcInfo[4].rcBtInfo[1].left = 170;
                    rcInfo[4].rcBtInfo[1].top = 258;
                    rcInfo[4].rcBtInfo[1].muID = 7;
                    rcInfo[4].rcBtInfo[1].ruID = 0;
                    rcInfo[4].rcBtInfo[2].name = stationList[7];    //청  평
                    rcInfo[4].rcBtInfo[2].flagVisibel = true;
                    rcInfo[4].rcBtInfo[2].width = 135;
                    rcInfo[4].rcBtInfo[2].left = 422;
                    rcInfo[4].rcBtInfo[2].top = 258;
                    rcInfo[4].rcBtInfo[2].muID = 8;
                    rcInfo[4].rcBtInfo[2].ruID = 0;
                    rcInfo[4].rcBtInfo[3].name = stationList[8];    //상  천
                    rcInfo[4].rcBtInfo[3].flagVisibel = true;
                    rcInfo[4].rcBtInfo[3].width = 135;
                    rcInfo[4].rcBtInfo[3].left = 675;
                    rcInfo[4].rcBtInfo[3].top = 258;
                    rcInfo[4].rcBtInfo[3].muID = 9;
                    rcInfo[4].rcBtInfo[3].ruID = 0;                    
                    rcInfo[4].rcBtInfo[4].name = clsCommon.muruName[7].ruName[0].ruName;     //대성1T
                    rcInfo[4].rcBtInfo[4].flagVisibel = true;
                    rcInfo[4].rcBtInfo[4].width = 100;
                    rcInfo[4].rcBtInfo[4].left = 294;
                    rcInfo[4].rcBtInfo[4].top = 468;
                    rcInfo[4].rcBtInfo[4].muID = 8;
                    rcInfo[4].rcBtInfo[4].ruID = 1;
                    rcInfo[4].rcBtInfo[5].name = clsCommon.muruName[7].ruName[1].ruName;     //청평T
                    rcInfo[4].rcBtInfo[5].flagVisibel = true;
                    rcInfo[4].rcBtInfo[5].width = 100;
                    rcInfo[4].rcBtInfo[5].left = 439;
                    rcInfo[4].rcBtInfo[5].top = 468;
                    rcInfo[4].rcBtInfo[5].muID = 8;
                    rcInfo[4].rcBtInfo[5].ruID = 2;
                    rcInfo[4].rcBtInfo[6].name = clsCommon.muruName[7].ruName[2].ruName;     //유답촌T
                    rcInfo[4].rcBtInfo[6].flagVisibel = true;
                    rcInfo[4].rcBtInfo[6].width = 100;
                    rcInfo[4].rcBtInfo[6].left = 584;
                    rcInfo[4].rcBtInfo[6].top = 468;
                    rcInfo[4].rcBtInfo[6].muID = 8;
                    rcInfo[4].rcBtInfo[6].ruID = 3;
                    rcInfo[4].rcBtInfo[7].name = "BDA 1";           //청평의 대성1T - BDA 1/2
                    rcInfo[4].rcBtInfo[7].flagVisibel = true;
                    rcInfo[4].rcBtInfo[7].width = 70;
                    rcInfo[4].rcBtInfo[7].left = 269;
                    rcInfo[4].rcBtInfo[7].top = 637;
                    rcInfo[4].rcBtInfo[7].muID = 8;
                    rcInfo[4].rcBtInfo[7].ruID = 1;
                    rcInfo[4].rcBtInfo[8].name = "BDA 2";
                    rcInfo[4].rcBtInfo[8].flagVisibel = true;
                    rcInfo[4].rcBtInfo[8].width = 70;
                    rcInfo[4].rcBtInfo[8].left = 349;
                    rcInfo[4].rcBtInfo[8].top = 637;
                    rcInfo[4].rcBtInfo[8].muID = 8;
                    rcInfo[4].rcBtInfo[8].ruID = 1;
                    rcInfo[4].rcBtInfo[9].name = "BDA 1";           //청평의 유답촌T - BDA 1
                    rcInfo[4].rcBtInfo[9].flagVisibel = true;
                    rcInfo[4].rcBtInfo[9].width = 70;
                    rcInfo[4].rcBtInfo[9].left = 599;
                    rcInfo[4].rcBtInfo[9].top = 637;
                    rcInfo[4].rcBtInfo[9].muID = 8;
                    rcInfo[4].rcBtInfo[9].ruID = 3;

                    rcInfo[5].rcBtInfo[0].name = "가  평";
                    rcInfo[5].rcBtInfo[0].flagVisibel = true;
                    rcInfo[5].rcBtInfo[0].width = 135;
                    rcInfo[5].rcBtInfo[0].left = 422;
                    rcInfo[5].rcBtInfo[0].top = 45;
                    rcInfo[5].rcBtInfo[1].name = stationList[7];    //청  평
                    rcInfo[5].rcBtInfo[1].flagVisibel = true;
                    rcInfo[5].rcBtInfo[1].width = 135;
                    rcInfo[5].rcBtInfo[1].left = 116;
                    rcInfo[5].rcBtInfo[1].top = 258;
                    rcInfo[5].rcBtInfo[1].muID = 8;
                    rcInfo[5].rcBtInfo[1].ruID = 0;
                    rcInfo[5].rcBtInfo[2].name = stationList[8];    //상  천
                    rcInfo[5].rcBtInfo[2].flagVisibel = true;
                    rcInfo[5].rcBtInfo[2].width = 135;
                    rcInfo[5].rcBtInfo[2].left = 270;
                    rcInfo[5].rcBtInfo[2].top = 258;
                    rcInfo[5].rcBtInfo[2].muID = 9;
                    rcInfo[5].rcBtInfo[2].ruID = 0;
                    rcInfo[5].rcBtInfo[3].name = stationList[9];    //가  평
                    rcInfo[5].rcBtInfo[3].flagVisibel = true;
                    rcInfo[5].rcBtInfo[3].width = 135;
                    rcInfo[5].rcBtInfo[3].left = 422;
                    rcInfo[5].rcBtInfo[3].top = 258;
                    rcInfo[5].rcBtInfo[3].muID = 10;
                    rcInfo[5].rcBtInfo[3].ruID = 0;
                    rcInfo[5].rcBtInfo[4].name = stationList[10];   //굴봉산
                    rcInfo[5].rcBtInfo[4].flagVisibel = true;
                    rcInfo[5].rcBtInfo[4].width = 135;
                    rcInfo[5].rcBtInfo[4].left = 670;
                    rcInfo[5].rcBtInfo[4].top = 258;
                    rcInfo[5].rcBtInfo[4].muID = 11;
                    rcInfo[5].rcBtInfo[4].ruID = 0;
                    rcInfo[5].rcBtInfo[5].name = stationList[11];    //백양리
                    rcInfo[5].rcBtInfo[5].flagVisibel = true;
                    rcInfo[5].rcBtInfo[5].width = 135;
                    rcInfo[5].rcBtInfo[5].left = 835;
                    rcInfo[5].rcBtInfo[5].top = 258;
                    rcInfo[5].rcBtInfo[5].muID = 12;
                    rcInfo[5].rcBtInfo[5].ruID = 0;
                    rcInfo[5].rcBtInfo[6].name = clsCommon.muruName[7].ruName[0].ruName;     //대성1T
                    rcInfo[5].rcBtInfo[6].flagVisibel = true;
                    rcInfo[5].rcBtInfo[6].width = 100;
                    rcInfo[5].rcBtInfo[6].left = 5;
                    rcInfo[5].rcBtInfo[6].top = 468;
                    rcInfo[5].rcBtInfo[6].muID = 8;
                    rcInfo[5].rcBtInfo[6].ruID = 1;
                    rcInfo[5].rcBtInfo[7].name = clsCommon.muruName[7].ruName[1].ruName;     //청평T
                    rcInfo[5].rcBtInfo[7].flagVisibel = true;
                    rcInfo[5].rcBtInfo[7].width = 100;
                    rcInfo[5].rcBtInfo[7].left = 132;
                    rcInfo[5].rcBtInfo[7].top = 468;
                    rcInfo[5].rcBtInfo[7].muID = 8;
                    rcInfo[5].rcBtInfo[7].ruID = 2;
                    rcInfo[5].rcBtInfo[8].name = clsCommon.muruName[7].ruName[2].ruName;     //유답촌T
                    rcInfo[5].rcBtInfo[8].flagVisibel = true;
                    rcInfo[5].rcBtInfo[8].width = 100;
                    rcInfo[5].rcBtInfo[8].left = 261;
                    rcInfo[5].rcBtInfo[8].top = 468;
                    rcInfo[5].rcBtInfo[8].muID = 8;
                    rcInfo[5].rcBtInfo[8].ruID = 3;
                    rcInfo[5].rcBtInfo[9].name = clsCommon.muruName[9].ruName[0].ruName;     //상천1T
                    rcInfo[5].rcBtInfo[9].flagVisibel = true;
                    rcInfo[5].rcBtInfo[9].width = 100;
                    rcInfo[5].rcBtInfo[9].left = 376;
                    rcInfo[5].rcBtInfo[9].top = 468;
                    rcInfo[5].rcBtInfo[9].muID = 10;
                    rcInfo[5].rcBtInfo[9].ruID = 1;
                    rcInfo[5].rcBtInfo[10].name = clsCommon.muruName[9].ruName[1].ruName;    //안산T
                    rcInfo[5].rcBtInfo[10].flagVisibel = true;
                    rcInfo[5].rcBtInfo[10].width = 100;
                    rcInfo[5].rcBtInfo[10].left = 504;
                    rcInfo[5].rcBtInfo[10].top = 468;
                    rcInfo[5].rcBtInfo[10].muID = 10;
                    rcInfo[5].rcBtInfo[10].ruID = 2;
                    rcInfo[5].rcBtInfo[11].name = clsCommon.muruName[10].ruName[0].ruName;   //서천T
                    rcInfo[5].rcBtInfo[11].flagVisibel = true;
                    rcInfo[5].rcBtInfo[11].width = 100;
                    rcInfo[5].rcBtInfo[11].left = 624;
                    rcInfo[5].rcBtInfo[11].top = 468;
                    rcInfo[5].rcBtInfo[11].muID = 11;
                    rcInfo[5].rcBtInfo[11].ruID = 1;
                    rcInfo[5].rcBtInfo[12].name = clsCommon.muruName[10].ruName[1].ruName;   //굴봉산T
                    rcInfo[5].rcBtInfo[12].flagVisibel = true;
                    rcInfo[5].rcBtInfo[12].width = 100;
                    rcInfo[5].rcBtInfo[12].left = 752;
                    rcInfo[5].rcBtInfo[12].top = 468;
                    rcInfo[5].rcBtInfo[12].muID = 11;
                    rcInfo[5].rcBtInfo[12].ruID = 2;
                    rcInfo[5].rcBtInfo[13].name = clsCommon.muruName[11].ruName[0].ruName;   //백양3T
                    rcInfo[5].rcBtInfo[13].flagVisibel = true;
                    rcInfo[5].rcBtInfo[13].width = 100;
                    rcInfo[5].rcBtInfo[13].left = 870;
                    rcInfo[5].rcBtInfo[13].top = 468;
                    rcInfo[5].rcBtInfo[13].muID = 12;
                    rcInfo[5].rcBtInfo[13].ruID = 1;
                    rcInfo[5].rcBtInfo[14].name = "BDA 1";           //청평의 대성1T - BDA 1/2
                    rcInfo[5].rcBtInfo[14].flagVisibel = true;
                    rcInfo[5].rcBtInfo[14].width = 70;
                    rcInfo[5].rcBtInfo[14].left = 20;
                    rcInfo[5].rcBtInfo[14].top = 637;
                    rcInfo[5].rcBtInfo[14].muID = 8;
                    rcInfo[5].rcBtInfo[14].ruID = 1;
                    rcInfo[5].rcBtInfo[15].name = "BDA 2";
                    rcInfo[5].rcBtInfo[15].flagVisibel = true;
                    rcInfo[5].rcBtInfo[15].width = 70;
                    rcInfo[5].rcBtInfo[15].left = 101;
                    rcInfo[5].rcBtInfo[15].top = 637;
                    rcInfo[5].rcBtInfo[15].muID = 8;
                    rcInfo[5].rcBtInfo[15].ruID = 1;
                    rcInfo[5].rcBtInfo[16].name = "BDA 1";           //청평의 유답촌T - BDA 1
                    rcInfo[5].rcBtInfo[16].flagVisibel = true;
                    rcInfo[5].rcBtInfo[16].width = 70;
                    rcInfo[5].rcBtInfo[16].left = 276;
                    rcInfo[5].rcBtInfo[16].top = 637;
                    rcInfo[5].rcBtInfo[16].muID = 8;
                    rcInfo[5].rcBtInfo[16].ruID = 3;
                    rcInfo[5].rcBtInfo[17].name = "BDA 1";           //가평의 상천1T - BDA 1/2
                    rcInfo[5].rcBtInfo[17].flagVisibel = true;
                    rcInfo[5].rcBtInfo[17].width = 70;
                    rcInfo[5].rcBtInfo[17].left = 351;
                    rcInfo[5].rcBtInfo[17].top = 637;
                    rcInfo[5].rcBtInfo[17].muID = 10;
                    rcInfo[5].rcBtInfo[17].ruID = 1;
                    rcInfo[5].rcBtInfo[18].name = "BDA 2";
                    rcInfo[5].rcBtInfo[18].flagVisibel = true;
                    rcInfo[5].rcBtInfo[18].width = 70;
                    rcInfo[5].rcBtInfo[18].left = 432;
                    rcInfo[5].rcBtInfo[18].top = 637;
                    rcInfo[5].rcBtInfo[18].muID = 10;
                    rcInfo[5].rcBtInfo[18].ruID = 1;
                    rcInfo[5].rcBtInfo[19].name = "BDA 1";           //가평의 안산T - BDA 1
                    rcInfo[5].rcBtInfo[19].flagVisibel = true;
                    rcInfo[5].rcBtInfo[19].width = 70;
                    rcInfo[5].rcBtInfo[19].left = 519;
                    rcInfo[5].rcBtInfo[19].top = 637;
                    rcInfo[5].rcBtInfo[19].muID = 10;
                    rcInfo[5].rcBtInfo[19].ruID = 2;
                    rcInfo[5].rcBtInfo[20].name = "BDA 1";           //굴봉산의 서천T - BDA 1/2
                    rcInfo[5].rcBtInfo[20].flagVisibel = true;
                    rcInfo[5].rcBtInfo[20].width = 70;
                    rcInfo[5].rcBtInfo[20].left = 599;
                    rcInfo[5].rcBtInfo[20].top = 637;
                    rcInfo[5].rcBtInfo[20].muID = 11;
                    rcInfo[5].rcBtInfo[20].ruID = 1;
                    rcInfo[5].rcBtInfo[21].name = "BDA 2";
                    rcInfo[5].rcBtInfo[21].flagVisibel = true;
                    rcInfo[5].rcBtInfo[21].width = 70;
                    rcInfo[5].rcBtInfo[21].left = 680;
                    rcInfo[5].rcBtInfo[21].top = 637;
                    rcInfo[5].rcBtInfo[21].muID = 11;
                    rcInfo[5].rcBtInfo[21].ruID = 1;
                    rcInfo[5].rcBtInfo[22].name = "BDA 1";           //백양리의 백양3T - BDA 1/2
                    rcInfo[5].rcBtInfo[22].flagVisibel = true;
                    rcInfo[5].rcBtInfo[22].width = 70;
                    rcInfo[5].rcBtInfo[22].left = 804;
                    rcInfo[5].rcBtInfo[22].top = 637;
                    rcInfo[5].rcBtInfo[22].muID = 12;
                    rcInfo[5].rcBtInfo[22].ruID = 1;
                    rcInfo[5].rcBtInfo[23].name = "BDA 2";
                    rcInfo[5].rcBtInfo[23].flagVisibel = true;
                    rcInfo[5].rcBtInfo[23].width = 70;
                    rcInfo[5].rcBtInfo[23].left = 885;
                    rcInfo[5].rcBtInfo[23].top = 637;
                    rcInfo[5].rcBtInfo[23].muID = 12;
                    rcInfo[5].rcBtInfo[23].ruID = 1;

                    rcInfo[6].rcBtInfo[0].name = "강  촌";
                    rcInfo[6].rcBtInfo[0].flagVisibel = true;
                    rcInfo[6].rcBtInfo[0].width = 135;
                    rcInfo[6].rcBtInfo[0].left = 422;
                    rcInfo[6].rcBtInfo[0].top = 45;
                    rcInfo[6].rcBtInfo[1].name = stationList[11];    //백양리
                    rcInfo[6].rcBtInfo[1].flagVisibel = true;
                    rcInfo[6].rcBtInfo[1].width = 135;
                    rcInfo[6].rcBtInfo[1].left = 270;
                    rcInfo[6].rcBtInfo[1].top = 258;
                    rcInfo[6].rcBtInfo[1].muID = 12;
                    rcInfo[6].rcBtInfo[1].ruID = 0;
                    rcInfo[6].rcBtInfo[2].name = stationList[12];    //김유정
                    rcInfo[6].rcBtInfo[2].flagVisibel = true;
                    rcInfo[6].rcBtInfo[2].width = 135;
                    rcInfo[6].rcBtInfo[2].left = 548;
                    rcInfo[6].rcBtInfo[2].top = 258;
                    rcInfo[6].rcBtInfo[2].muID = 13;
                    rcInfo[6].rcBtInfo[2].ruID = 0;
                    rcInfo[6].rcBtInfo[3].name = clsCommon.muruName[11].ruName[0].ruName;    //백양3T
                    rcInfo[6].rcBtInfo[3].flagVisibel = true;
                    rcInfo[6].rcBtInfo[3].width = 100;
                    rcInfo[6].rcBtInfo[3].left = 288;
                    rcInfo[6].rcBtInfo[3].top = 468;
                    rcInfo[6].rcBtInfo[3].muID = 12;
                    rcInfo[6].rcBtInfo[3].ruID = 1;
                    rcInfo[6].rcBtInfo[4].name = clsCommon.muruName[12].ruName[0].ruName;    //강촌1T
                    rcInfo[6].rcBtInfo[4].flagVisibel = true;
                    rcInfo[6].rcBtInfo[4].width = 100;
                    rcInfo[6].rcBtInfo[4].left = 502;
                    rcInfo[6].rcBtInfo[4].top = 468;
                    rcInfo[6].rcBtInfo[4].muID = 13;
                    rcInfo[6].rcBtInfo[4].ruID = 1;
                    rcInfo[6].rcBtInfo[5].name = clsCommon.muruName[12].ruName[1].ruName;    //강촌3T
                    rcInfo[6].rcBtInfo[5].flagVisibel = true;
                    rcInfo[6].rcBtInfo[5].width = 100;
                    rcInfo[6].rcBtInfo[5].left = 630;
                    rcInfo[6].rcBtInfo[5].top = 468;
                    rcInfo[6].rcBtInfo[5].muID = 13;
                    rcInfo[6].rcBtInfo[5].ruID = 2;
                    rcInfo[6].rcBtInfo[6].name = "BDA 1";           //백양리의 백양3T - BDA 1/2
                    rcInfo[6].rcBtInfo[6].flagVisibel = true;
                    rcInfo[6].rcBtInfo[6].width = 70;
                    rcInfo[6].rcBtInfo[6].left = 263;
                    rcInfo[6].rcBtInfo[6].top = 637;
                    rcInfo[6].rcBtInfo[6].muID = 12;
                    rcInfo[6].rcBtInfo[6].ruID = 1;
                    rcInfo[6].rcBtInfo[7].name = "BDA 2";
                    rcInfo[6].rcBtInfo[7].flagVisibel = true;
                    rcInfo[6].rcBtInfo[7].width = 70;
                    rcInfo[6].rcBtInfo[7].left = 344;
                    rcInfo[6].rcBtInfo[7].top = 637;
                    rcInfo[6].rcBtInfo[7].muID = 12;
                    rcInfo[6].rcBtInfo[7].ruID = 1;
                    rcInfo[6].rcBtInfo[8].name = "BDA 1";           //김유정의 강촌1T - BDA 1/2
                    rcInfo[6].rcBtInfo[8].flagVisibel = true;
                    rcInfo[6].rcBtInfo[8].width = 70;
                    rcInfo[6].rcBtInfo[8].left = 477;
                    rcInfo[6].rcBtInfo[8].top = 637;
                    rcInfo[6].rcBtInfo[8].muID = 13;
                    rcInfo[6].rcBtInfo[8].ruID = 1;
                    rcInfo[6].rcBtInfo[9].name = "BDA 2";
                    rcInfo[6].rcBtInfo[9].flagVisibel = true;
                    rcInfo[6].rcBtInfo[9].width = 70;
                    rcInfo[6].rcBtInfo[9].left = 558;
                    rcInfo[6].rcBtInfo[9].top = 637;
                    rcInfo[6].rcBtInfo[9].muID = 13;
                    rcInfo[6].rcBtInfo[9].ruID = 1;
                    rcInfo[6].rcBtInfo[10].name = "BDA 1";           //김유정의 강촌3T - BDA 1
                    rcInfo[6].rcBtInfo[10].flagVisibel = true;
                    rcInfo[6].rcBtInfo[10].width = 70;
                    rcInfo[6].rcBtInfo[10].left = 645;
                    rcInfo[6].rcBtInfo[10].top = 637;
                    rcInfo[6].rcBtInfo[10].muID = 13;
                    rcInfo[6].rcBtInfo[10].ruID = 2;

                    rcInfo[7].rcBtInfo[0].name = "김유정";
                    rcInfo[7].rcBtInfo[0].flagVisibel = true;
                    rcInfo[7].rcBtInfo[0].width = 135;
                    rcInfo[7].rcBtInfo[0].left = 422;
                    rcInfo[7].rcBtInfo[0].top = 45;
                    rcInfo[7].rcBtInfo[1].name = stationList[12];    //김유정
                    rcInfo[7].rcBtInfo[1].flagVisibel = true;
                    rcInfo[7].rcBtInfo[1].width = 135;
                    rcInfo[7].rcBtInfo[1].left = 422;
                    rcInfo[7].rcBtInfo[1].top = 258;
                    rcInfo[7].rcBtInfo[1].muID = 13;
                    rcInfo[7].rcBtInfo[1].ruID = 0;
                    rcInfo[7].rcBtInfo[2].name = clsCommon.muruName[12].ruName[0].ruName;    //강촌 1T
                    rcInfo[7].rcBtInfo[2].flagVisibel = true;
                    rcInfo[7].rcBtInfo[2].width = 100;
                    rcInfo[7].rcBtInfo[2].left = 376;
                    rcInfo[7].rcBtInfo[2].top = 468;
                    rcInfo[7].rcBtInfo[2].muID = 13;
                    rcInfo[7].rcBtInfo[2].ruID = 1;
                    rcInfo[7].rcBtInfo[3].name = clsCommon.muruName[12].ruName[1].ruName;    //강촌 3T
                    rcInfo[7].rcBtInfo[3].flagVisibel = true;
                    rcInfo[7].rcBtInfo[3].width = 100;
                    rcInfo[7].rcBtInfo[3].left = 504;
                    rcInfo[7].rcBtInfo[3].top = 468;
                    rcInfo[7].rcBtInfo[3].muID = 13;
                    rcInfo[7].rcBtInfo[3].ruID = 2;
                    rcInfo[7].rcBtInfo[4].name = "BDA 1";           //김유정의 강촌1T - BDA 1/2
                    rcInfo[7].rcBtInfo[4].flagVisibel = true;
                    rcInfo[7].rcBtInfo[4].width = 70;
                    rcInfo[7].rcBtInfo[4].left = 351;
                    rcInfo[7].rcBtInfo[4].top = 637;
                    rcInfo[7].rcBtInfo[4].muID = 13;
                    rcInfo[7].rcBtInfo[4].ruID = 1;
                    rcInfo[7].rcBtInfo[5].name = "BDA 2";
                    rcInfo[7].rcBtInfo[5].flagVisibel = true;
                    rcInfo[7].rcBtInfo[5].width = 70;
                    rcInfo[7].rcBtInfo[5].left = 432;
                    rcInfo[7].rcBtInfo[5].top = 637;
                    rcInfo[7].rcBtInfo[5].muID = 13;
                    rcInfo[7].rcBtInfo[5].ruID = 1;
                    rcInfo[7].rcBtInfo[6].name = "BDA 1";           //김유정의 강촌3T - BDA 1
                    rcInfo[7].rcBtInfo[6].flagVisibel = true;
                    rcInfo[7].rcBtInfo[6].width = 70;
                    rcInfo[7].rcBtInfo[6].left = 519;
                    rcInfo[7].rcBtInfo[6].top = 637;
                    rcInfo[7].rcBtInfo[6].muID = 13;
                    rcInfo[7].rcBtInfo[6].ruID = 2;

                    rcInfo[8].rcBtInfo[0].name = "남춘천";
                    rcInfo[8].rcBtInfo[0].flagVisibel = true;
                    rcInfo[8].rcBtInfo[0].width = 135;
                    rcInfo[8].rcBtInfo[0].left = 422;
                    rcInfo[8].rcBtInfo[0].top = 183;
                    rcInfo[8].rcBtInfo[1].name = stationList[13];   //춘  천
                    rcInfo[8].rcBtInfo[1].flagVisibel = true;
                    rcInfo[8].rcBtInfo[1].width = 135;
                    rcInfo[8].rcBtInfo[1].left = 422;
                    rcInfo[8].rcBtInfo[1].top = 467;
                    rcInfo[8].rcBtInfo[1].muID = 14;
                    rcInfo[8].rcBtInfo[1].ruID = 0;

                    rcInfo[9].rcBtInfo[0].name = "춘  천";
                    rcInfo[9].rcBtInfo[0].flagVisibel = true;
                    rcInfo[9].rcBtInfo[0].width = 135;
                    rcInfo[9].rcBtInfo[0].left = 422;
                    rcInfo[9].rcBtInfo[0].top = 45;
                    rcInfo[9].rcBtInfo[1].name = stationList[11];    //백양리
                    rcInfo[9].rcBtInfo[1].flagVisibel = true;
                    rcInfo[9].rcBtInfo[1].width = 135;
                    rcInfo[9].rcBtInfo[1].left = 170;
                    rcInfo[9].rcBtInfo[1].top = 258;
                    rcInfo[9].rcBtInfo[1].muID = 12;
                    rcInfo[9].rcBtInfo[1].ruID = 0;
                    rcInfo[9].rcBtInfo[2].name = stationList[12];   //김유정
                    rcInfo[9].rcBtInfo[2].flagVisibel = true;
                    rcInfo[9].rcBtInfo[2].width = 135;
                    rcInfo[9].rcBtInfo[2].left = 422;
                    rcInfo[9].rcBtInfo[2].top = 258;
                    rcInfo[9].rcBtInfo[2].muID = 13;
                    rcInfo[9].rcBtInfo[2].ruID = 0;
                    rcInfo[9].rcBtInfo[3].name = stationList[13];   //춘  천
                    rcInfo[9].rcBtInfo[3].flagVisibel = true;
                    rcInfo[9].rcBtInfo[3].width = 135;
                    rcInfo[9].rcBtInfo[3].left = 675;
                    rcInfo[9].rcBtInfo[3].top = 258;
                    rcInfo[9].rcBtInfo[3].muID = 14;
                    rcInfo[9].rcBtInfo[3].ruID = 0;
                    rcInfo[9].rcBtInfo[4].name = clsCommon.muruName[11].ruName[0].ruName;    //백양3T
                    rcInfo[9].rcBtInfo[4].flagVisibel = true;
                    rcInfo[9].rcBtInfo[4].width = 100;
                    rcInfo[9].rcBtInfo[4].left = 188;
                    rcInfo[9].rcBtInfo[4].top = 468;
                    rcInfo[9].rcBtInfo[4].muID = 12;
                    rcInfo[9].rcBtInfo[4].ruID = 1;
                    rcInfo[9].rcBtInfo[5].name = clsCommon.muruName[12].ruName[0].ruName;    //강촌1T
                    rcInfo[9].rcBtInfo[5].flagVisibel = true;
                    rcInfo[9].rcBtInfo[5].width = 100;
                    rcInfo[9].rcBtInfo[5].left = 363;
                    rcInfo[9].rcBtInfo[5].top = 468;
                    rcInfo[9].rcBtInfo[5].muID = 13;
                    rcInfo[9].rcBtInfo[5].ruID = 1;
                    rcInfo[9].rcBtInfo[6].name = clsCommon.muruName[12].ruName[1].ruName;    //강촌3T
                    rcInfo[9].rcBtInfo[6].flagVisibel = true;
                    rcInfo[9].rcBtInfo[6].width = 100;
                    rcInfo[9].rcBtInfo[6].left = 508;
                    rcInfo[9].rcBtInfo[6].top = 458;
                    rcInfo[9].rcBtInfo[6].muID = 13;
                    rcInfo[9].rcBtInfo[6].ruID = 2;
                    rcInfo[9].rcBtInfo[7].name = "BDA 1";           //백양리의 백양3T - BDA 1/2
                    rcInfo[9].rcBtInfo[7].flagVisibel = true;
                    rcInfo[9].rcBtInfo[7].width = 70;
                    rcInfo[9].rcBtInfo[7].left = 163;
                    rcInfo[9].rcBtInfo[7].top = 637;
                    rcInfo[9].rcBtInfo[7].muID = 12;
                    rcInfo[9].rcBtInfo[7].ruID = 1;
                    rcInfo[9].rcBtInfo[8].name = "BDA 2";
                    rcInfo[9].rcBtInfo[8].flagVisibel = true;
                    rcInfo[9].rcBtInfo[8].width = 70;
                    rcInfo[9].rcBtInfo[8].left = 244;
                    rcInfo[9].rcBtInfo[8].top = 637;
                    rcInfo[9].rcBtInfo[8].muID = 12;
                    rcInfo[9].rcBtInfo[8].ruID = 1;
                    rcInfo[9].rcBtInfo[9].name = "BDA 1";           //김유정의 강촌1T - BDA 1/2
                    rcInfo[9].rcBtInfo[9].flagVisibel = true;
                    rcInfo[9].rcBtInfo[9].width = 70;
                    rcInfo[9].rcBtInfo[9].left = 338;
                    rcInfo[9].rcBtInfo[9].top = 637;
                    rcInfo[9].rcBtInfo[9].muID = 13;
                    rcInfo[9].rcBtInfo[9].ruID = 1;
                    rcInfo[9].rcBtInfo[10].name = "BDA 2";
                    rcInfo[9].rcBtInfo[10].flagVisibel = true;
                    rcInfo[9].rcBtInfo[10].width = 70;
                    rcInfo[9].rcBtInfo[10].left = 419;
                    rcInfo[9].rcBtInfo[10].top = 637;
                    rcInfo[9].rcBtInfo[10].muID = 13;
                    rcInfo[9].rcBtInfo[10].ruID = 1;
                    rcInfo[9].rcBtInfo[11].name = "BDA 1";           //김유정의 강촌3T - BDA 1
                    rcInfo[9].rcBtInfo[11].flagVisibel = true;
                    rcInfo[9].rcBtInfo[11].width = 70;
                    rcInfo[9].rcBtInfo[11].left = 523;
                    rcInfo[9].rcBtInfo[11].top = 637;
                    rcInfo[9].rcBtInfo[11].muID = 13;
                    rcInfo[9].rcBtInfo[11].ruID = 2;
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;
            }
        }

        private void RU_Init()
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "전라선":
                    #region 전라선 RU 화면
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case "중앙선":
                    #region 중앙선 RC 통화권 초기화
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case "경춘선":
                    break;
            }
        }

        private void CCE_Init()
        {
            int i = 0, j = 0;

            #region 컨트롤 배열 Tag 정의
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #region Main 화면의 컨트롤 배열 Tag 정의
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 2; i++)
            {
                btMPU[i].Tag = i;
                pbMPU[i].Tag = i;
                btPower[i].Tag = i;
            }

            for (i = 0; i < 9; i++)
            {
                btCCP[i].Tag = i;
                btConsole[i].Tag = i;
            }

            for (i = 0; i < 30; i++) btBase[i].Tag = i;
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region Console I/F 화면의 컨트롤 배열 Tag 정의
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 9; i++) btConsoleSub[i].Tag = i;
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region Broad I/F 화면의 컨트롤 배열 Tag 정의
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 30; i++)
            {
                lblBroadSelSt1[i].Tag = i;
                lblBroadSelSt2[i].Tag = i;
                lblBroadSelSt3[i].Tag = i;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region Base I/F 화면의 컨트롤 배열 Tag 정의
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 30; i++) btBaseSub[i].Tag = i;
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region CCE Test Panel관련 변수 초기화
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            CCEControlTextInit();

            for (i = 0; i < 2; i++)
            {
                useSt[i] = new UseSt();

                cpuSt[i] = new CpuSt();

                for (j = 0; j < 9; j++)
                {
                    ccpSt[i, j] = new CcpSt();
                    consoleSt[i, j] = new ConsoleSt();
                }

                broadSt[i] = new BroadSt();

                for (j = 0; j < 30; j++)
                    baseSt[i, j] = new BaseSt();
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region CCE Test Panel과의 Network통신 관련 초기화 작업
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 2; i++)
            {
                cceTestPanel[i] = new clsCCETestPanel(cceIP[i], ccePort[i]);

                cceTestPanel[i].MyID = i + 1;

                cceTestPanel[i].socket_Accepted += new socket_AcceptedEvent(frmMain_socket_Accepted);
                cceTestPanel[i].socket_Closed += new socket_ServerClosedEvent(frmMain_socket_Closed);

                cceTestPanel[i].dataSendReceive += new DataSendReceiveEvent(frmMain_dataSendReceive);
                cceTestPanel[i].sendReceiveDataView += new SendReceiveDataViewEvent(frmMain_sendReceiveDataView);

                cceTestPanel[i].mpu_CpuSt += new MPU_CpuStEvent(frmMain_mpu_CpuSt);
                cceTestPanel[i].mpu_CcpConsoleBroadSt += new MPU_CcpConsoleBroadStEvent(frmMain_mpu_CcpConsoleBroadSt);
                cceTestPanel[i].mpu_BaseSt += new MPU_BaseStEvent(frmMain_mpu_BaseSt);
                cceTestPanel[i].mpu_GainValue += new MPU_GainValueEvent(frmMain_mpu_GainValue);
                cceTestPanel[i].mpu_BroadUnitSelectedSt += new MPU_BroadUnitSelectedStEvent(frmMain_mpu_BroadUnitSelectedSt);
                cceTestPanel[i].mpu_IfUseSt += new MPU_IFUseStEvent(frmMain_mpu_IfUseSt);

                cceTestPanel[i].mpu_LineTestValue += new MPU_LineTestValueEvent(frmMain_mpu_LineTestValue);
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
        }

        #endregion

        #region 공통 메뉴 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void btMenu_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag);

            int i = 0;

            //송신 출력 시험중이면 중지하고 넘어간다.
            switch (depth)
            {
                case faultInfoMU:
                    if (MUSt.flagSendOutTest)
                    {
                        MUSt.flagSendOutTest = false;
                        MUSt.btMuSendOutTest_ColorSet();    //송신출력시험 버튼 색 변경

                        nmsMainMachine.EditData_CTL_SendOutTest(clsCommon.presentMUID, clsCommon.presentRUID, false);
                        AddStatus(nowStation + "의 MU의 송신출력시험을 중지하였습니다.");
                    }
                    break;

                case faultInfoRU:
                    if (RUSt.flagSendOutTest)
                    {
                        RUSt.flagSendOutTest = false;
                        RUSt.btRuSendOutTest_ColorSet();    //송신출력시험 버튼 색 변경

                        nmsMainMachine.EditData_CTL_SendOutTest(clsCommon.presentMUID, clsCommon.presentRUID, false);
                        AddStatus(nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + "의 송신출력시험을 중지하였습니다.");
                    }
                    break;
            }

            switch (index)
            {
                case 0:     //위로
                    switch (depth)
                    {
                        case faultInfoMU:       //MU
                            clsCommon.presentMUID = 0;

                            depth = faultInfoAll;
                            btMenu_Click(faultInfoAll);     //전체감시화면으로 이동
                            break;

                        case faultInfoRU:
                            clsCommon.presentRUID = 0;

                            depth = faultInfoMU;
                            btMenu_Click(faultInfoMU);      //MU 감시화면으로 이동
                            break;

                        case faultInfoMain:         //주장치
                        case faultInfoSearch:       //고장내역조회
                        case faultInfoSetup:        //설정
                        case faultInfoLineTest:     //회선 시험
                            break;

                        default:    //RC 통화권일때는 RC 통화권 전체를 보는 화면과 RC 세부통화권을 보는 화면이 있음. 세부통화권 화면에서 전체 통화권화면으로 전환할경우임..
                            RcRouteView(true);
                            break;
                    }
                    break;

                case 1:     //전체감시화면
                case 5:     //전체감시화면(MU 통화권)
                case 6:     //전체감시화면(RC 통화권)
                    clsCommon.presentMUID = 0;
                    clsCommon.presentRUID = 0;

                    depth = faultInfoAll;
                    btMenu_Click(faultInfoAll);

                    switch (index)
                    {
                        case 1: SetVisible(gbStation, true); SetVisible(gbMuRoute, false); SetVisible(gbRcRoute, false); break;
                        case 5: SetVisible(gbStation, false); SetVisible(gbMuRoute, true); SetVisible(gbRcRoute, false); break;
                        case 6: SetVisible(gbStation, false); SetVisible(gbMuRoute, false); SetVisible(gbRcRoute, true); RcRouteView(true); break;
                    }

                    for (i = 1; i < 7; i++)
                        SetColor(btMenu[i], colorBase);
                    for (i = 0; i < 3; i++)
                        SetColor(btMainApparatus[i], colorBase);
                    SetColor(btMenu[index], Color.YellowGreen);
                    break;

                case 2:     //고장내역조회
                    clsCommon.presentMUID = 0;
                    clsCommon.presentRUID = 0;

                    depth = faultInfoSearch;
                    btMenu_Click(faultInfoSearch);

                    for (i = 1; i < 7; i++)
                        SetColor(btMenu[i], colorBase);
                    for (i = 0; i < 3; i++)
                        SetColor(btMainApparatus[i], colorBase);
                    SetColor(btMenu[index], Color.YellowGreen);
                    break;

                case 3:     //설정
                    frmPW_Show(1);
                    break;

                case 4:     //회선 시험
                    clsCommon.presentMUID = 0;
                    clsCommon.presentRUID = 0;

                    depth = faultInfoLineTest;
                    btMenu_Click(faultInfoLineTest);

                    for (i = 1; i < 7; i++)
                        SetColor(btMenu[i], colorBase);
                    for (i = 0; i < 3; i++)
                        SetColor(btMainApparatus[i], colorBase);
                    SetColor(btMenu[index], Color.YellowGreen);
                    break;
            }
        }

        private void btMenu_Click(int index)
        {
            int i = 0;

            for (i = 0; i < 7; i++)
                SetVisible(gbFaultInfo[i], false);

            SetVisible(gbFaultInfo[index], true);

            switch (index)
            {
                case faultInfoMU:
                    MuStInit(clsCommon.muruComSt[clsCommon.presentMUID - 1].flagMu);
                    MuFmStInit(clsCommon.muruComSt[clsCommon.presentMUID - 1].flagFm);
                    MuUpsStInit(clsCommon.muruComSt[clsCommon.presentMUID - 1].flagUps);

                    nmsRuComSt_Display(clsCommon.presentMUID);

                    if (clsCommon.muruComSt[clsCommon.presentMUID - 1].flagMu) nmsMUSt_Display(clsCommon.presentMUID);     //MU 상태 적용
                    if (clsCommon.muruComSt[clsCommon.presentMUID - 1].flagFm) nmsFMSt_Display(clsCommon.presentMUID, 0);  //MU의 FM 상태 적용
                    if (clsCommon.muruComSt[clsCommon.presentMUID - 1].flagUps) nmsUPSSt_Display(clsCommon.presentMUID);    //UPS 상태 적용
                    break;

                case faultInfoRU:
                    string tmpRuName = string.Empty;
                    if (clsCommon.nmsGUIUser == "경춘선") tmpRuName = " RU\r\n(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ")\r\n 정보";
                    else tmpRuName = " RU\r\n(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ") 정보";
                    SetText(lblRUName, nowStation + tmpRuName);

                    for (i = 0; i < 4; i++)
                    {
                        if (clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].bdaName[i] == "") BdaStInit(false, (byte)i);
                        else BdaStInit(clsCommon.muruComSt[clsCommon.presentMUID - 1].ruBdaCommSt[clsCommon.presentRUID - 1].flagBda[i], (byte)i);

                        bdaSt[i].BDANameSet(clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].bdaName[i]);
                    }

                    RuStInit(clsCommon.muruComSt[clsCommon.presentMUID - 1].ruBdaCommSt[clsCommon.presentRUID - 1].flagRu);
                    RuFmStInit(clsCommon.muruComSt[clsCommon.presentMUID - 1].ruBdaCommSt[clsCommon.presentRUID - 1].flagFm);

                    nmsRuComSt_Display(clsCommon.presentMUID);

                    if (clsCommon.muruComSt[clsCommon.presentMUID - 1].ruBdaCommSt[clsCommon.presentRUID - 1].flagRu) nmsRUSt_Display(clsCommon.presentMUID, clsCommon.presentRUID);
                    if (clsCommon.muruComSt[clsCommon.presentMUID - 1].ruBdaCommSt[clsCommon.presentRUID - 1].flagFm) nmsFMSt_Display(clsCommon.presentMUID, clsCommon.presentRUID);

                    for (i = 0; i < 4; i++)
                    {
                        nmsBdaComSt_Display(clsCommon.presentMUID, clsCommon.presentRUID, (byte)i);

                        if (clsCommon.muruComSt[clsCommon.presentMUID - 1].ruBdaCommSt[clsCommon.presentRUID - 1].flagBda[i])
                        {
                            nmsRUBDASt_Display(clsCommon.presentMUID, clsCommon.presentRUID, (byte)(i + 1));

                            if (clsCommon.nmsGUIUser == "경춘선")
                            {
                                //2012년 04월 12일 RXRSSI값을 BDA의 VHF RX에 표시한다.
                                bdaSt[i].nmsRUBDA_VHFRX_Display(muruNowData[clsCommon.presentMUID].ruData[clsCommon.presentRUID].ruData.rxRssiValue * -1);
                            }
                        }

                        bdaSt[i].flagInquiry = false;
                        bdaSt[i].flagLoopTest = false;
                        bdaSt[i].btBDAInquiry_ColorSet();   //조회 버튼색 초기화
                        bdaSt[i].btLoopTest_ColorSet();     //Loop Test 버튼색 초기화
                    }
                    break;
            }

            //gbFaultInfoAll  - 0
            //gbFaultInfoMain - 1
            //gbFaultInfoMU   - 2
            //gbFaultInfoRU   - 3
            //gbFaultInfoSearch - 4
            //gbFaultInfoSetup - 5
            //gbfaultInfoLineTest - 6
        }

        private void btMenu8_Click(object sender, EventArgs e)
        {   //경보음 해제
            SetChecked(cbBellPlay, !flagSound);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Mu, Ru,  MuFm, MuUps, Ru, RuFm, Bda , CCE 초기화 작업
        private void MuStInit(bool flagAction)
        {
            MUSt.MuStInit(flagAction);      //MU 화면 초기화
        }

        private void MuFmStInit(bool flagAction)
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    MuFm.FmStInit(flagAction);      //FM 화면 초기화
                    break;

                default:
                    MUSt.FmStInit(flagAction);      //소스텔의 FM 화면 초기화
                    break;
            }
        }

        private void MuUpsStInit(bool flagAction)
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "전라선":
                    MuUps.UpsStInit(flagAction);    //UPS 화면 초기화
                    break;

                case "경춘선":
                    MuUps.UpsStInit(flagAction);    //UPS 화면 초기화
                    break;
            }
        }

        private void RuStInit(bool flagAction)
        {
            RUSt.RuStInit(flagAction);
        }

        private void RuFmStInit(bool flagAction)
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    RuFm.FmStInit(flagAction);
                    break;

                default:
                    RUSt.FmStInit(flagAction);      //소스텔의 FM 화면 초기화
                    break;
            }
        }

        private void BdaStInit(bool flagAction, byte bdaID)
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    bdaSt[bdaID].BdaStInit(flagAction);
                    break;

                default:
                    RUSt.BDAInit(bdaID, flagAction);    //소스텔의 BDA 화면 초기화
                    break;
            }
        }

        private void CCEStInit(bool flagAction)
        {
            if (clsCommon.nmsGUIUser == "경춘선")
            {
            }
            else
            {
                SetEnable(panel_Main, flagAction);

                if (!flagAction)
                {
                    int i = 0;

                    SetImage(pbMPU1, NMS.Properties.Resources.st_OFF);
                    SetImage(pbMPU2, NMS.Properties.Resources.st_OFF);

                    SetColor(btMPU1, colorBase);
                    SetColor(btMPU2, colorBase);

                    SetColor(btPW1, colorBase);
                    SetColor(btPW2, colorBase);

                    for (i = 0; i < 9; i++)
                    {
                        SetColor(btCCP[i], colorBase);
                        SetColor(btConsole[i], colorBase);
                    }
                    SetColor(btBroad, colorBase);
                    for (i = 0; i < 30; i++)
                        SetColor(btBase[i], colorBase);
                }
            }
        }

        #endregion

        #region DB 관련 갱신 기능
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void NMSDB_Connect()
        {
            if (fbDBMS_NMS != null)
            {
                fbDBMS_NMS.Dispose();
                fbDBMS_NMS = null;
            }

            string tmpPath = clsCommon.DataBasePath + DateTime.Now.Year.ToString("0000") + @"\";
            if (!Directory.Exists(tmpPath)) Directory.CreateDirectory(tmpPath);

            string dbFile = "NMS_" + DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + day.ToString("00") + ".FDB";
            if (!File.Exists(tmpPath + dbFile))
                File.Copy(clsCommon.DataBasePath + "NMS.FDB", tmpPath + dbFile);

            fbDBMS_NMS = new nmsDBMS();
            fbDBMS_NMS.DBConnect(tmpPath + dbFile);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 비밀번호 입력후 처리
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void frmPW_Show(int tmpPwApplyIndex)
        {
            pwApplyIndex = tmpPwApplyIndex;

            if (frmPW == null)
            {
                frmPW = new frmPassword();
                frmPW.FormClosing += new FormClosingEventHandler(frmPW_FormClosing);
                frmPW.OK_Cancel_Click += new OK_Cancel_Click_Event(frmPW_OK_Cancel_Click);
            }

            frmPW.tbPW_Focus();
            frmPW.Show();
        }

        void frmPW_OK_Cancel_Click(bool flagAction)
        {
            //비밀번호 입력완료시 처리할 내용...
            if (flagAction)
            {
                switch (pwApplyIndex)
                {
                    case 1:     //설정화면으로 넘어가기
                        clsCommon.presentMUID = 0;
                        clsCommon.presentRUID = 0;

                        depth = faultInfoSetup;
                        btMenu_Click(faultInfoSetup);

                        int i = 0;
                        for (i = 1; i < 7; i++)
                            SetColor(btMenu[i], colorBase);
                        for (i = 0; i < 3; i++)
                            SetColor(btMainApparatus[i], colorBase);
                        SetColor(btMenu[3], Color.YellowGreen);   //설정버튼 색 변경
                        break;
                }
            }
        }

        void frmPW_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPW = null;
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 전체 감시 화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private string mainTitle = string.Empty;

        private void btMainApparatus_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag);

            if (index == 2) return;

            clsCommon.presentMUID = 0;
            clsCommon.presentRUID = 0;

            depth = faultInfoMain;
            btMenu_Click(faultInfoMain);    //주장치 화면

            switch (index)
            {
                case 0: mainTitle = "구로 주장치"; break;
                case 1: mainTitle = "대전 주장치"; break;
                case 2: mainTitle = "NMS 주장치"; break;
            }

            cceID = index;
            btCCEMenu_Click(gbViewMain);

            int i = 0;
            for (i = 1; i < 7; i++)
                SetColor(btMenu[i], colorBase);
            for (i = 0; i < 3; i++)
                SetColor(btMainApparatus[i], colorBase);
            SetColor(btMainApparatus[index], Color.YellowGreen);

            MainStView();
        }

        private void MainMachineSt_ClickEvent(int MyID)
        {
            if (MyID == 2) return;

            clsCommon.presentMUID = 0;
            clsCommon.presentRUID = 0;

            depth = faultInfoMain;
            btMenu_Click(faultInfoMain);    //주장치 화면

            switch(MyID)
            {
                case 0: mainTitle = "구로 주장치"; break;
                case 1: mainTitle = "대전 주장치"; break;
                case 2: mainTitle = "NMS 주장치"; break;
            }

            cceID = MyID;
            btCCEMenu_Click(gbViewMain);

            MainStView();
        }

        private void lblStation_Click(object sender, EventArgs e)
        {
        }

        private void Station_Click(int index)
        {
            nowStation = stationList[index];

            clsCommon.presentMUID = (byte)(index + 1);
            clsCommon.presentRUID = 0;

            depth = faultInfoMU;
            //SetText(gbFaultInfo[faultInfoMU], nowStation + " MU("+ clsCommon.muruName[clsCommon.presentMUID-1].muName + ") 정보");
            SetText(lblMUName, nowStation + "\r\nMU 정보");
            btMenu_Click(faultInfoMU);      //MU 화면

            SetMuRuNameApply();     //MU/RU 이름 적용
            SetRcNameApply();       //CCE/RC 이름 적용
        }

        private void Create_StationButton(int cnt)
        {
            int tmpStartX = 10;
            int tmpStartY = 25;

            int tmpGapX = 5;
            int tmpGapY = 5;

            int tmpRow = 0;
            int tmpCol = 0;

            int tmpWidth = 0;
            int tmpHeight = 0;

            int tmpLeft = 0;
            int tmpTop = 0;

            //int tmpCnt = Convert.ToInt32(cbArrangement.Text);
            int tmpCnt = cnt;

            if (tmpCnt <= 5) {       tmpStartX = 20; tmpStartY = 60; tmpRow = 1; tmpCol = 5; tmpGapX = 15; }
            else if (tmpCnt <= 10) { tmpStartX = 20; tmpStartY = 40; tmpRow = 2; tmpCol = 5; tmpGapX = 15; tmpGapY = 20; }
            else if (tmpCnt <= 15) { tmpStartX = 20; tmpStartY = 40; tmpRow = 3; tmpCol = 5; tmpGapX = 15; tmpGapY = 10; }
            else if (tmpCnt <= 20) { tmpStartX = 20; tmpStartY = 35; tmpRow = 4; tmpCol = 5; tmpGapX = 15; tmpGapY = 10; }
            else if (tmpCnt <= 25) { tmpStartX = 20; tmpStartY = 35; tmpRow = 5; tmpCol = 5; tmpGapX = 15; tmpGapY = 8; }
            else if (tmpCnt <= 30) { tmpStartX = 20; tmpStartY = 35; tmpRow = 5; tmpCol = 6; tmpGapX = 12; tmpGapY = 8; }
            else if (tmpCnt <= 35) { tmpStartX = 20; tmpStartY = 30; tmpRow = 5; tmpCol = 7;  tmpGapX = 10; tmpGapY = 8; }
            else if (tmpCnt <= 42) { tmpStartX = 20; tmpStartY = 30; tmpRow = 6; tmpCol = 7;  tmpGapX = 10; tmpGapY = 8; }
            else if (tmpCnt <= 48) { tmpStartX = 18;  tmpStartY = 30; tmpRow = 6; tmpCol = 8;  tmpGapX = 9; tmpGapY = 8; }
            else if (tmpCnt <= 56) { tmpStartX = 18;  tmpStartY = 30; tmpRow = 7; tmpCol = 8;  tmpGapX = 9; tmpGapY = 6; }
            else if (tmpCnt <= 63) { tmpStartX = 20;  tmpStartY = 30; tmpRow = 7; tmpCol = 9;  tmpGapX = 8; tmpGapY = 6; }
            else if (tmpCnt <= 72) { tmpStartX = 20;  tmpStartY = 30; tmpRow = 8; tmpCol = 9;  tmpGapX = 8; tmpGapY = 6; }
            else if (tmpCnt <= 80) { tmpStartX = 18; tmpStartY = 30; tmpRow = 8; tmpCol = 10; tmpGapX = 7; tmpGapY = 6; }
            else if (tmpCnt <= 90) { tmpStartX = 18; tmpStartY = 30; tmpRow = 9; tmpCol = 10; tmpGapX = 7; tmpGapY = 6; }
            else if (tmpCnt <= 99) { tmpStartX = 16; tmpStartY = 30; tmpRow = 9; tmpCol = 11; tmpGapX = 7; tmpGapY = 6; }

            StationSt.Clear();
            gbStation.Controls.Clear();

            //역사 상태 사용자 컨트롤(stationSt) 크기
            switch (clsCommon.nmsGUIUser)
            {
                case "전라선":
                    tmpWidth = 1750 / tmpCol;
                    tmpHeight = 700 / tmpRow;
                    break;

                case "중앙선":
                    tmpWidth = 1400 / tmpCol;
                    tmpHeight = 700 / tmpRow;
                    break;

                case "경춘선":
                default:
                    tmpWidth = 900 / tmpCol;
                    tmpHeight = 700 / tmpRow;
                    break;
            }

            for (int i = 0; i < tmpRow; i++)
            {
                for (int j = 0; j < tmpCol; j++)
                {
                    stationSt tmpStationSt = new stationSt();                    
                    tmpStationSt.MyID = (i * tmpCol) + j;

                    if (clsCommon.nmsGUIUser == "전라선")
                        tmpStationSt.AlarmSet(true);    //알람설정용으로 사용...

                    tmpStationSt.ClickEvent += new ButtonClickEvent(StationSt_ClickEvent);

                    gbStation.Controls.Add(tmpStationSt);

                    tmpStationSt.Font = MainMachineSt1.Font;

                    //크기
                    tmpStationSt.Width = tmpWidth;
                    tmpStationSt.Height = tmpHeight;

                    //위치
                    tmpLeft = tmpStartX + (tmpWidth * j) + (tmpGapX * j);
                    tmpTop = tmpStartY + (tmpHeight * i) + (tmpGapY * i);

                    tmpStationSt.Left = tmpLeft;
                    tmpStationSt.Top = tmpTop;

                    StationSt.Add(tmpStationSt);
                }
            }

            try
            {
                for (int i = 0; i < stationList.Count; i++)
                    StationSt[i].SetStationName(stationList[i].ToString());
            }
            catch
            {
            }
        }

        void StationSt_ClickEvent(int MyID)
        {
            if (MyID >= stationList.Count) return;
            Station_Click(MyID);
        }

        private void btArrangement_Click(object sender, EventArgs e)
        {
            Create_StationButton(Convert.ToInt32(cbArrangement.Text));
        }

        #region MU 통화권 감시화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void btMuStation_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag);
            Station_Click(index);
        }

        private void btRuStation_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag);

            Station_Click(index / 10);

            clsCommon.presentRUID = (byte)(index % 10 + 1);

            depth = faultInfoRU;
            btMenu_Click(faultInfoRU);     //RU 감시 화면
        }

        private void btMuBda_Click(object sender, EventArgs e)
        {
            string tmpTag = ((Button)sender).Tag.ToString();
            string[] tmpInfo = tmpTag.Split(new char[] { ',' });

            Station_Click(Convert.ToByte(tmpInfo[0]) - 1);
            clsCommon.presentRUID = Convert.ToByte(tmpInfo[1]);

            depth = faultInfoRU;
            btMenu_Click(faultInfoRU);     //RU 감시 화면
        }

        /// <summary>
        /// MU 버튼에 색을 칠한다.
        /// </summary>
        /// <param name="muID">muID</param>
        /// <param name="index">상태 0:통신안함(colorBase), 1:정상(colorSelect), 2:이상(colorError)</param>
        private void SetColorMuButton(byte muID, int index)
        {
            if (btMuStation[muID - 1].Text == "") return;

            switch (index)
            {
                case 0:     //통신안함
                    if (btMuStation[muID - 1].BackColor != colorBase)
                        AddStatus("MU(" + btMuStation[muID - 1].Text + ")에 통신 Error가 발생하였습니다.");

                    SetColor(btMuStation[muID - 1], colorBase);
                    break;

                case 1:     //정상
                    if (btMuStation[muID - 1].BackColor == colorBase)
                        AddStatus("MU(" + btMuStation[muID - 1].Text + ")에 통신 Error가 복구되었습니다.");

                        SetColor(btMuStation[muID - 1], colorSelect);
                    break;

                case 2:     //대기
                    if (btMuStation[muID - 1].BackColor == colorBase)
                        AddStatus("MU(" + btMuStation[muID - 1].Text + ")에 통신 Error가 복구되었습니다.");

                        SetColor(btMuStation[muID - 1], colorError);
                    break;
            }
        }

        /// <summary>
        /// RU 버튼에 색을 칠한다.
        /// </summary>
        /// <param name="muID">muID</param>
        /// <param name="ruID">ruID</param>
        /// <param name="index">상태 0:통신안함(colorBase), 1:정상(colorSelect), 2:이상(colorError)</param>
        private void SetColorRuButton(byte muID, byte ruID, int index)
        {
            if (btRuStation[muID - 1, ruID - 1].Text == "") return;

            switch (index)
            {
                case 0:     //통신안함
                    if (btRuStation[muID - 1, ruID - 1].BackColor != colorBase)
                        AddStatus(btMuStation[muID - 1].Text + "역의 RU(" + btRuStation[muID - 1, ruID - 1].Text + ")에 통신 Error가 발생하였습니다.");
                    
                    SetColor(btRuStation[muID - 1, ruID - 1], colorBase);
                    break;

                case 1:     //정상
                    if (btRuStation[muID - 1, ruID - 1].BackColor == colorBase)
                        AddStatus(btMuStation[muID - 1].Text + "역의 RU(" + btRuStation[muID - 1, ruID - 1].Text + ")에 통신 Error가 복구되었습니다.");

                    SetColor(btRuStation[muID - 1, ruID - 1], colorSelect);
                    break;

                case 2:     //이상
                    if (btRuStation[muID - 1, ruID - 1].BackColor == colorBase)
                        AddStatus(btMuStation[muID - 1].Text + "역의 RU(" + btRuStation[muID - 1, ruID - 1].Text + ")에 통신 Error가 복구되었습니다.");

                    SetColor(btRuStation[muID - 1, ruID - 1], colorError);
                    break;
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region RC 통화권 감시화면 관렴
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void RcRouteView(bool flagAction)
        {
            SetVisible(panelRCAll, flagAction);
            SetVisible(panelRC, !flagAction);
        }

        private int rcStationIndex = 0;
        private void btRcStation_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag);

            rcStationIndex = index;

            RcRouteView(false);

            SetImage(pbRC, rcBitMap[rcStationIndex]);

            for (int i = 0; i < cntRC; i++)
            {
                SetText(btRc[i], rcInfo[rcStationIndex].rcBtInfo[i].name);
                SetVisible(btRc[i], rcInfo[rcStationIndex].rcBtInfo[i].flagVisibel);
                btRc[i].Width = rcInfo[rcStationIndex].rcBtInfo[i].width;
                btRc[i].Left = rcInfo[rcStationIndex].rcBtInfo[i].left;
                btRc[i].Top = rcInfo[rcStationIndex].rcBtInfo[i].top;

                try
                {
                    //통신상태 확인
                    bool flagCommSt = false;
                    if (rcInfo[rcStationIndex].rcBtInfo[i].ruID == 0) flagCommSt = clsCommon.muruComSt[rcInfo[rcStationIndex].rcBtInfo[i].muID - 1].flagMu;
                    else flagCommSt = clsCommon.muruComSt[rcInfo[rcStationIndex].rcBtInfo[i].muID - 1].ruBdaCommSt[rcInfo[rcStationIndex].rcBtInfo[i].ruID - 1].flagRu;

                    if (flagCommSt)
                    {   //통신상태 정상
                        //Error 상태 확인
                        if (clsCommon.flagMuRuBdaError[rcInfo[rcStationIndex].rcBtInfo[i].muID - 1, rcInfo[rcStationIndex].rcBtInfo[i].ruID, 0]) SetColor(btRc[i], colorError);
                        else SetColor(btRc[i], colorSelect);
                    }
                    else
                    {   //통신이상
                        SetColor(btRc[i], colorBase);
                    }
                }
                catch
                {
                }
            }
        }

        private void btRC_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag);

            if(index == 0) return;

            Station_Click(rcInfo[rcStationIndex].rcBtInfo[index].muID - 1);

            if (rcInfo[rcStationIndex].rcBtInfo[index].ruID != 0)
            {
                clsCommon.presentRUID = rcInfo[rcStationIndex].rcBtInfo[index].ruID;
                
                depth = faultInfoRU;
                btMenu_Click(faultInfoRU);     //RU 감시 화면
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 주장치 감시화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void CCEControlTextInit()
        {
            int i = 0;

            //Main 화면의 컨트롤 Text 표시
            for (i = 0; i < 9; i++)
            {
                SetText(btCCP[i], "CCP " + (i + 1).ToString());
                SetText(btConsole[i], "Console I/F " + (i + 1).ToString());
            }

            for (i = 0; i < 30; i++)
                SetText(btBase[i], "Base I/F " + (i + 1).ToString());

            //Console I/F 화면의 컨트롤 Text 표시
            for (i = 0; i < 9; i++)
                SetText(btConsoleSub[i], "Console I/F " + (i + 1).ToString());

            //Broad I/F 화면의 컨트롤 Text 표시
            for (i = 0; i < 30; i++)
            {
                SetText(lblBroadSelSt1[i], (i + 1).ToString());
                SetText(lblBroadSelSt2[i], (i + 1).ToString());
                SetText(lblBroadSelSt3[i], (i + 1).ToString());
            }

            //Base I/F 화면의 컨트롤 Text 표시
            for (i = 0; i < 30; i++)
                SetText(btBaseSub[i], (i + 1).ToString());
        }

        private void IFUseStView()
        {
            int i = 0;

            for (i = 0; i < 9; i++)
            {
                //CCP 버튼 표시
                if (useSt[cceID].flagCCP[i]) SetEnable(btCCP[i], true);
                else SetEnable(btCCP[i], false);

                //Console I/F 버튼 표시
                if (useSt[cceID].flagConsole[i])
                {
                    SetEnable(btConsole[i], true);
                    SetEnable(btConsoleSub[i], true);
                }
                else
                {
                    SetEnable(btConsole[i], false);
                    SetEnable(btConsoleSub[i], false);
                }
            }

            //Broad I/F 버튼 표시
            if (useSt[cceID].flagBroad) SetEnable(btBroad, true);
            else SetEnable(btBroad, false);

            //Base I/F 버튼 표시
            for (i = 0; i < 30; i++)
            {
                if (useSt[cceID].flagBase[i])
                {
                    SetEnable(btBase[i], true);
                    SetEnable(btBaseSub[i], true);
                }
                else
                {
                    SetEnable(btBase[i], false);
                    SetEnable(btBaseSub[i], false);
                }
            }
        }

        private void btCCEMenu_Click(int index)
        {
            for (int i = 0; i < 4; i++)
                SetVisible(panelView[i], false);

            SetVisible(panelView[index], true);

            string tmpStr = string.Empty;

            switch (index)
            {
                case gbViewMain: tmpStr = mainTitle + " ( 메인화면 )"; break;
                case gbViewConsole: tmpStr = mainTitle + " ( Console I/F 화면 )"; break;
                case gbViewBroad: tmpStr = mainTitle + " ( Broad I/F 화면 )"; break;
                case gbViewBase: tmpStr = mainTitle + " ( Base I/F 화면 )"; break;
            }

            SetText(lblMainMachineTitle, tmpStr);

            cceDepth = index;
        }

        private void btComMenu1_Click(object sender, EventArgs e)
        {
            btCCEMenu_Click(0);
        }

        #region Main 화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void MainStView()
        {
            int i = 0;

            if (!clsCommon.cceComSt[cceID].flagCCE)
            {
                CCEStInit(false);
                return;
            }

            IFUseStView();

            //CPU 상태 표시
            if (cpuSt[cceID].mainStby == 0x31)
            {   //Main
                SetColor(btMPU[0], colorSelect);
                SetColor(btMPU[1], colorBase);
            }
            else
            {   //Stby
                SetColor(btMPU[0], colorBase);
                SetColor(btMPU[1], colorSelect);
            }

            for (i = 0; i < 2; i++)
            {
                //Main/Stby CPU Fault
                if (cpuSt[cceID].cpuSt[i] == 0) SetImage(pbMPU[i], NMS.Properties.Resources.st_Normal);
                else SetImage(pbMPU[i], NMS.Properties.Resources.st_Error);

                //Main/Stby Power Fault
                if (cpuSt[cceID].cpuSt[i + 2] == 0) SetColor(btPower[i], colorSelect);
                else SetColor(btPower[i], colorError);
            }

            //CCP Communication Fault 상태 표시
            for (i = 0; i < 9; i++)
            {
                if (useSt[cceID].flagCCP[i])
                {
                    if (ccpSt[cceID, i].flagCommunicationFault) SetColor(btCCP[i], colorSelect);
                    else SetColor(btCCP[i], colorError);
                }
                else
                {
                    SetColor(btCCP[i], colorBase);
                }
            }

            //Console I/F Communication Fault 상태 표시
            for (i = 0; i < 9; i++)
            {
                if (useSt[cceID].flagConsole[i])
                {
                    if (consoleSt[cceID, i].otherSt[0] == 0) SetColor(btConsole[i], colorSelect);
                    else SetColor(btConsole[i], colorError);
                }
                else
                {
                    SetColor(btConsole[i], colorBase);
                }
            }

            //Broad I/F Communication Fault 상태 표시
            if (useSt[cceID].flagBroad)
            {
                if (broadSt[cceID].otherSt[0] == 0) SetColor(btBroad, colorSelect);
                else SetColor(btBroad, colorError);
            }
            else
            {
                SetColor(btBroad, colorBase);
            }

            //Base I/F Communication Fault 상태 표시
            for (i = 0; i < 30; i++)
            {
                if (useSt[cceID].flagBase[i])
                {
                    if (baseSt[cceID, i].otherSt[0] == 0) SetColor(btBase[i], colorSelect);
                    else SetColor(btBase[i], colorError);
                }
                else
                {
                    SetColor(btBase[i], colorBase);
                }
            }
        }

        private void btCCEMPU_Click(object sender, EventArgs e)
        {
        }

        private void btCCEPW_Click(object sender, EventArgs e)
        {
        }

        private void btCCECCP_Click(object sender, EventArgs e)
        {
        }

        private void btCCEConsol_Click(object sender, EventArgs e)
        {
            selectedIndex = Convert.ToInt32(((Button)sender).Tag);
            btCCEMenu_Click(gbViewConsole);  //Console I/F 화면으로 이동
            ConsoleIFStView(selectedIndex);
        }

        private void btCCEBroad_Click(object sender, EventArgs e)
        {
            selectedIndex = 0;
            btCCEMenu_Click(gbViewBroad);    //Broad I/F 화면으로 이동
            BroadIFStView();
        }

        private void btCCEBase_Click(object sender, EventArgs e)
        {
            selectedIndex = Convert.ToInt32(((Button)sender).Tag);
            btCCEMenu_Click(gbViewBase);    //Base I/F 화면으로 이동
            BaseIFStView(selectedIndex);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Console I/F 화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void btConsoleSub_Click(object sender, EventArgs e)
        {
            selectedIndex = Convert.ToInt32(((Button)sender).Tag);
            ConsoleIFStView(selectedIndex);
        }

        private void ConsoleIFStView(int index)
        {
            int i = 0;

            SetText(gbConsoleSt, "Console I/F " + (index + 1).ToString());

            //선택한 Console I/F 상태 표시

            //선택한 Console I/F 표시
            for (i = 0; i < 9; i++)
                SetColor(btConsoleSub[i], colorBase);
            SetColor(btConsoleSub[index], colorSelect);

            //채널 표시
            SetText(lblConsoleCH, consoleSt[cceID, index].ch.ToString() + " CH");

            //기타 상태 표시
            if (consoleSt[cceID, index].otherSt[0] == 0) SetImage(pbConsoleOtherSt[0], NMS.Properties.Resources.st_Normal);
            else SetImage(pbConsoleOtherSt[0], NMS.Properties.Resources.st_Error);

            for (i = 1; i < 3; i++)
            {
                if (consoleSt[cceID, index].otherSt[i] == 0) SetImage(pbConsoleOtherSt[i], NMS.Properties.Resources.st_OFF);
                else SetImage(pbConsoleOtherSt[i], NMS.Properties.Resources.st_ON);
            }

            //Gain 값 표시
            for (i = 0; i < 8; i++)
                SetText(lblConsoleGain[i], consoleSt[cceID, index].gainValue[i].ToString());
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Broad I/F 화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void BroadIFStView()
        {
            int i = 0;

            //Broad 1,2,3의 Enable/Ptt 상태
            for (i = 0; i < 3; i++)
            {
                if (broadSt[cceID].otherSt[i] == 0) SetImage(pbBroadEnable[i], NMS.Properties.Resources.st_Normal);
                else SetImage(pbBroadEnable[i], NMS.Properties.Resources.st_Error);

                if (broadSt[cceID].otherSt[i + 4] == 0) SetImage(pbBroadPtt[i], NMS.Properties.Resources.st_Normal);
                else SetImage(pbBroadPtt[i], NMS.Properties.Resources.st_Error);
            }

            //Gain 값 표시
            for (i = 0; i < 4; i++)
                SetText(lblBroadGain[i], broadSt[cceID].gainValue[i].ToString());

            //선택 기지국 표시
            for (i = 0; i < 30; i++)
            {
                if (broadSt[cceID].unitSelectedSt[0, i] == 1) SetColor(lblBroadSelSt1[i], colorSelect);
                else SetColor(lblBroadSelSt1[i], colorBase);

                if (broadSt[cceID].unitSelectedSt[1, i] == 1) SetColor(lblBroadSelSt2[i], colorSelect);
                else SetColor(lblBroadSelSt2[i], colorBase);

                if (broadSt[cceID].unitSelectedSt[2, i] == 1) SetColor(lblBroadSelSt3[i], colorSelect);
                else SetColor(lblBroadSelSt3[i], colorBase);
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Base I/F 화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void btBaseSub_Click(object sender, EventArgs e)
        {
            selectedIndex = Convert.ToInt32(((Button)sender).Tag);
            BaseIFStView(selectedIndex);
        }

        private void BaseIFStView(int index)
        {
            int i = 0;

            SetText(gbBaseSt, "Base I/F " + (index + 1).ToString());

            //선택한 Base I/F 상태 표시

            //선택한 Base I/F 표시
            for (i = 0; i < 30; i++)
                SetColor(btBaseSub[i], colorBase);
            SetColor(btBaseSub[index], colorSelect);

            //채널 표시
            SetText(lblBaseCH, baseSt[cceID, index].ch.ToString() + " CH");

            //기타 상태 표시
            if (baseSt[cceID, index].otherSt[0] == 0) SetImage(pbBaseOtherSt[0], NMS.Properties.Resources.st_Normal);
            else SetImage(pbBaseOtherSt[0], NMS.Properties.Resources.st_Error);

            for (i = 1; i <= 4; i++)
            {
                if (baseSt[cceID, index].otherSt[i] == 0) SetImage(pbBaseOtherSt[i], NMS.Properties.Resources.st_OFF);
                else SetImage(pbBaseOtherSt[i], NMS.Properties.Resources.st_ON);
            }

            for (i = 5; i < 7; i++)
            {
                if (baseSt[cceID, index].otherSt[i] == 0) SetImage(pbBaseOtherSt[i], NMS.Properties.Resources.st_Normal);
                else SetImage(pbBaseOtherSt[i], NMS.Properties.Resources.st_Error);
            }

            //Gain 값 표시
            for (i = 0; i < 8; i++)
                SetText(lblBaseGain[i], baseSt[cceID, index].gainValue[i].ToString());
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region MU 감시화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void RU_ClickEvent(int MyID)
        {
            int index = MyID;

            switch (depth)
            {
                case faultInfoMU:
                    if (MUSt.flagSendOutTest)
                    {
                        MUSt.flagSendOutTest = false;
                        MUSt.btMuSendOutTest_ColorSet();    //송신출력시험 버튼 색 변경

                        nmsMainMachine.EditData_CTL_SendOutTest(clsCommon.presentMUID, clsCommon.presentRUID, false);
                        AddStatus(nowStation + "의 MU의 송신출력시험을 중지하였습니다.");
                    }
                    break;

                case faultInfoRU:
                    if (RUSt.flagSendOutTest)
                    {
                        RUSt.flagSendOutTest = false;
                        RUSt.btRuSendOutTest_ColorSet();    //송신출력시험 버튼 색 변경

                        nmsMainMachine.EditData_CTL_SendOutTest(clsCommon.presentMUID, clsCommon.presentRUID, false);
                        AddStatus(nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + "의 송신출력시험을 중지하였습니다.");
                    }
                    break;
            }

            clsCommon.presentRUID = (byte)(index + 1);

            depth = faultInfoRU;
            btMenu_Click(faultInfoRU);     //RU 감시 화면
        }

        void MUSt_muControlClick(byte btCode, byte index, byte value)
        {
            string tmpStr = string.Empty;

            switch (btCode)
            {
                case 0:     //Main/Stby 절체
                    if (muruNowData[clsCommon.presentMUID].muData.otherSt1[0] == 0)
                    {
                        MessageBox.Show("절체방법이 자동으로 되어있습니다. 절체방법이 수동으로 되어 있을때만 주/예비 절체를 할수있습니다.");
                        return;
                    }

                    if (MessageBox.Show("주/예비 절체시 통화가 끊어질수 있습니다. 절체 하시겠습니까?",
                        "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

                    nmsMainMachine.EditData_CTL_MainStbyChange(clsCommon.presentMUID, clsCommon.presentRUID, clsCommon.HexaConvert(index));

                    tmpStr = nowStation + "의 MU";

                    if (index == 0) tmpStr += " : MAIN으로";
                    else tmpStr += " : STBY로";

                    AddStatus(tmpStr + "장비로 절체하였습니다.");
                    break;

                case 1:     //Auto/Manual 절체
                    if (MessageBox.Show("자동/수동 절체시 통화가 끊어질수 있습니다. 절체 하시겠습니까?",
                        "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

                    nmsMainMachine.EditData_CTL_AutoManualChange(clsCommon.presentMUID, clsCommon.presentRUID, clsCommon.HexaConvert(index));

                    tmpStr = nowStation + "의 MU : 절체방법을 ";

                    if (index == 0) tmpStr += "AUTO로";
                    else tmpStr += "MANUAL로";

                    AddStatus(tmpStr + " 변경하였습니다.");
                    break;

                case 2:     //Rf 출력값 설정(Main/Stby)
                    if (MessageBox.Show("송신 출력값을 설정하시겠습니까?",
                        "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

                    byte rfValue = value;

                    try
                    {
                        if ((rfValue < 5) || (rfValue > 17))
                        {
                            MessageBox.Show("설정 범위를 벋어났습니다. 설정범위는 5W ~ 17W 입니다.");
                            return;
                        }

                        rfValue = clsCommon.muRfValueTable[rfValue - 5];
                    }
                    catch
                    {
                        rfValue = 0;
                    }

                    nmsMainMachine.EditData_CTL_RFValueSet(clsCommon.presentMUID, clsCommon.presentRUID, clsCommon.HexaConvert(index), rfValue);

                    tmpStr = nowStation +"의 MU";

                    if (index == 0) tmpStr += " : 주장비";
                    else tmpStr += " : 예비장비";

                    AddStatus(tmpStr + " 송신 출력을 " + value.ToString() + "W로 설정하였습니다.");
                    break;

                case 3:     //무전기 형식 설정(Wide/Narrow)
                    if (MessageBox.Show("무전기 형식을 변경하시겠습니까?",
                        "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

                    byte wideNarrow = 0;

                    if (muruNowData[clsCommon.presentMUID].muData.otherSt1[2] == 0) wideNarrow = 1;
                    else wideNarrow = 0;

                    nmsMainMachine.EditData_CTL_WideNarrowChange(clsCommon.presentMUID, clsCommon.presentRUID, clsCommon.HexaConvert(wideNarrow));

                    tmpStr = nowStation +"의 MU : 무전기 형식을"; 

                    if (wideNarrow == 0) tmpStr += " Wide";
                    else tmpStr += " Narrow";

                    AddStatus(tmpStr + "로 변경하였습니다.");
                    break;

                case 4:     //채널복귀시간 설정
                    if (MessageBox.Show("체널 복귀 시간을 설정하시겠습니까?",
                        "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

                    nmsMainMachine.EditData_CTL_ChReturnTimeSet(clsCommon.presentMUID, clsCommon.presentRUID, value);

                    tmpStr = nowStation +"의 MU :";

                    tmpStr += " 채널복귀시간을 " + value.ToString();

                    AddStatus(tmpStr + "초로 설정하였습니다.");
                    break;

                case 5:     //송신출력시험
                    tmpStr = nowStation + "의 MU : 송신출력시험을";

                    if (MUSt.flagSendOutTest)
                    {   //시험 중지
                        MUSt.flagSendOutTest = false;
                        tmpStr += " 중지하였습니다.";
                    }
                    else
                    {   //시험 시작
                        MUSt.flagSendOutTest = true;
                        tmpStr += " 시작하였습니다.";
                    }
                    nmsMainMachine.EditData_CTL_SendOutTest(clsCommon.presentMUID, clsCommon.presentRUID, MUSt.flagSendOutTest);
                    MUSt.btMuSendOutTest_ColorSet();    //송신출력시험 버튼 색 변경

                    AddStatus(tmpStr);
                    break;
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region RU 감시화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void RUSt_ruControlClick(byte btCode, byte index, byte value)
        {
            string tmpStr = string.Empty;

            switch (btCode)
            {
                case 0:     //주/예비 절체
                    if (muruNowData[clsCommon.presentMUID].ruData[clsCommon.presentRUID].ruData.otherSt1[0] == 0)
                    {
                        MessageBox.Show("절체방법이 자동으로 되어있습니다. 수동으로 되어 있을때만 주/예비 절체를 할수있습니다.");
                        return;
                    }
                    
                    if (MessageBox.Show("주/예비 절체시 통화가 끊어질수 있습니다. 절체 하시겠습니까?",
                        "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

                    nmsMainMachine.EditData_CTL_MainStbyChange(clsCommon.presentMUID, clsCommon.presentRUID, clsCommon.HexaConvert(index));

                    tmpStr = nowStation + "의 RU("+ clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ")";

                    if (index == 0) tmpStr += " : 주";
                    else tmpStr += " : 예비";

                    AddStatus(tmpStr + "장비로 절체하였습니다.");
                    break;

                case 1:     //자동/수동 절체방법 변경
                    if (MessageBox.Show("자동/수동 절체시 통화가 끊어질수 있습니다. 절체 하시겠습니까?",
                        "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

                    byte autoManual = 0;

                    if (muruNowData[clsCommon.presentMUID].ruData[clsCommon.presentRUID].ruData.otherSt1[0] == 0) autoManual = 1;
                    else autoManual = 0;

                    nmsMainMachine.EditData_CTL_AutoManualChange(clsCommon.presentMUID, clsCommon.presentRUID, clsCommon.HexaConvert(autoManual));

                    tmpStr = nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ") : 절체방법을";

                    if (autoManual == 0) tmpStr += " 자동으로";
                    else tmpStr += " 수동으로";

                    AddStatus(tmpStr + " 변경하였습니다.");
                    break;

                case 2:     //RF 출력 조절
                    if (MessageBox.Show("송신 출력값을 설정하시겠습니까?",
                        "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

                    byte mainSpare = 0;
                    byte rfValue = 0;

                    try
                    {
                        rfValue = value;

                        if ((rfValue < 5) || (rfValue > 17))
                        {
                            MessageBox.Show("설정 범위를 벋어났습니다. 설정범위는 5W ~ 17W 입니다.");
                            return;
                        }

                        rfValue = clsCommon.ruRfValueTable[rfValue - 5];
                    }
                    catch
                    {
                        rfValue = 0;
                    }

                    nmsMainMachine.EditData_CTL_RFValueSet(clsCommon.presentMUID, clsCommon.presentRUID, clsCommon.HexaConvert(mainSpare), rfValue);

                    tmpStr = nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ") : ";

                    AddStatus(tmpStr + "송신 출력을 " + value.ToString() + "W로 설정하였습니다.");
                    break;

                case 3:     //Wide/Narrow 절체
                    if (MessageBox.Show("무전기 형식을 변경하시겠습니까?",
                        "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

                    byte wideNarrow = 0;

                    if (muruNowData[clsCommon.presentMUID].ruData[clsCommon.presentRUID].ruData.otherSt1[2] == 0) wideNarrow = 1;
                    else wideNarrow = 0;

                    nmsMainMachine.EditData_CTL_WideNarrowChange(clsCommon.presentMUID, clsCommon.presentRUID, clsCommon.HexaConvert(wideNarrow));

                    tmpStr = nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ") : 무전기형식을";

                    if (wideNarrow == 0) tmpStr += " Wide";
                    else tmpStr += " Narrow";

                    AddStatus(tmpStr + "로 변경하였습니다.");
                    break;

                case 4:
                    tmpStr = nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ") : 송신출력시험을";

                    if (RUSt.flagSendOutTest)
                    {   //시험 중지
                        RUSt.flagSendOutTest = false;
                        tmpStr += " 중지하였습니다.";
                    }
                    else
                    {   //시험 시작
                        RUSt.flagSendOutTest = true;
                        tmpStr += " 시작하였습니다.";
                    }
                    nmsMainMachine.EditData_CTL_SendOutTest(clsCommon.presentMUID, clsCommon.presentRUID, RUSt.flagSendOutTest);
                    RUSt.btRuSendOutTest_ColorSet();    //송신출력시험 버튼 색 변경

                    AddStatus(tmpStr);
                    break;

                case 5: //BDA 초기화
                    bool flagBDAExist = false;                    
                    for (int k = 0; k < 4; k++)
                    {
                        if (clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].bdaName[k] != "")
                        {
                            flagBDAExist = true;
                            break;
                        }
                    }
                    if (!flagBDAExist) return;
                    
                    nmsMainMachine.EditData_BDA_FreqSet(clsCommon.presentMUID, clsCommon.presentRUID, 0, 0);

                    //현재 보고 있는 BDA 화면을 초기화 시킨다.
                    for (byte i = 0; i < 4; i++)
                    {
                        if (clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].bdaName[i] != "")
                        {
                            clsCommon.muruComSt[clsCommon.presentMUID - 1].ruBdaCommSt[clsCommon.presentRUID - 1].flagBdaFirst[i] = false;
                            clsCommon.muruComSt[clsCommon.presentMUID - 1].ruBdaCommSt[clsCommon.presentRUID - 1].flagBda[i] = false;

                            try
                            {
                                btBdaSetColor(clsCommon.presentMUID, clsCommon.presentRUID, i, colorBase);    //MU통화권 화면의 BDA 버튼 Error 표시
                            }
                            catch
                            {
                            }

                            BdaStInit(true, i);
                        }
                    }

                    tmpStr = nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ")의 BDA를 초기화시켰습니다.";
                    AddStatus(tmpStr);
                    break;
            }
        }

        private void BDAInitSet(byte muID, byte ruID)
        {
            BDAInit tmpBDAInit = new BDAInit();

            for (int i = 0; i < 4; i++)
                tmpBDAInit.flagBDAEnable[i] = chkBDAEnable[i].Checked;

            tmpBDAInit.flagBDAPollEnable = chkBDAPollEnable.Checked;

            try
            {
                tmpBDAInit.pollTime = Convert.ToByte(tbBDAPollTime.Text);
            }
            catch
            {
            }

            nmsMainMachine.EditData_BDA_InitSet(muID, ruID, tmpBDAInit);

            string tmpStr = nowStation + "의 RU(" + clsCommon.muruName[muID - 1].ruName[ruID - 1].ruName + ") : BDA 설정 초기값을 설정하였습니다";
            AddStatus(tmpStr);
        }

        private void bdaSt_ControlClick(byte bdaID, byte btCode)
        {
            string tmpStr = string.Empty;
            switch (btCode)
            {
                case 0:     //BDA 상태 조회
                    bdaSt[bdaID - 1].flagInquiry = true;

                    nmsMainMachine.EditData_BDA_StInquiry(clsCommon.presentMUID, clsCommon.presentRUID, bdaID);

                    tmpStr = nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ") : BDA " + bdaID.ToString() + "의 상태를 조회 하였습니다.";
                    AddStatus(tmpStr);

                    /*  
                    if (!bdaSt[bdaID - 1].flagInquiry)
                    {
                        bdaSt[bdaID - 1].flagInquiry = true;

                        nmsMainMachine.EditData_BDA_StInquiry(clsCommon.presentMUID, clsCommon.presentRUID, bdaID);

                        tmpStr = nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ") : BDA " + bdaID.ToString() + "의 상태를 조회 하였습니다.";
                        AddStatus(tmpStr);
                    }
                    else
                    {
                        bdaSt[bdaID - 1].flagInquiry = false;
                        bdaSt[bdaID - 1].btBDAInquiry_ColorSet();
                    }
                    */
                    break;

                case 1:     //BDA LoopTest
                    bdaSt[bdaID - 1].flagLoopTest = true;

                    nmsMainMachine.EditData_BDA_LoopTest(clsCommon.presentMUID, clsCommon.presentRUID, bdaID);

                    tmpStr = nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ") : BDA " + bdaID.ToString() + "의 LoopTest를 하였습니다.";
                    AddStatus(tmpStr);
                    
                    /*
                    if (!bdaSt[bdaID - 1].flagLoopTest)
                    {
                        bdaSt[bdaID - 1].flagLoopTest = true;

                        nmsMainMachine.EditData_BDA_LoopTest(clsCommon.presentMUID, clsCommon.presentRUID, bdaID);

                        tmpStr = nowStation + "의 RU(" + clsCommon.muruName[clsCommon.presentMUID - 1].ruName[clsCommon.presentRUID - 1].ruName + ") : BDA " + bdaID.ToString() + "의 LoopTest를 하였습니다.";
                        AddStatus(tmpStr);
                    }
                    else
                    {
                        bdaSt[bdaID - 1].flagLoopTest = false;
                        bdaSt[bdaID - 1].btLoopTest_ColorSet();
                    }
                    */
                    break;
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 이력조회 화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void tcMainSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcMainSearch.SelectedIndex)
            {

                case 0:     //통신내역
                case 1:     //장애내역
                case 5:     //기타 검색
                    SetEnable(dTPStop, true);

                    //SetEnable(gbSearchTime, true);
                    SetEnable(gbSearchWord, false);
                    break;

                case 2:     //운용내역
                    SetEnable(dTPStop, true);

                    //SetEnable(gbSearchTime, true);
                    SetEnable(gbSearchWord, true);
                    break;

                case 3:     //주장치 관련 내역
                case 4:     //NMS 관련 내역
                    SetEnable(dTPStop, false);

                    //SetEnable(gbSearchTime, false);
                    SetEnable(gbSearchWord, false);
                    break;
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0, cnt = 0;
            byte errCount = 0;

            ArrayList[] searchResultList = null;

            ArrayList tmpResultList = new ArrayList();  //검색결과를 저장할 배열

            //검색할 날자/시간
            int intYear = dTPStart.Value.Year;
            int intMonth = dTPStart.Value.Month;
            int intDay = dTPStart.Value.Day;
            int intHour = Convert.ToInt32(cbSearchStartH.Text);
            int intMin = Convert.ToInt32(cbSearchStartM.Text);
            int intSec = 0;
            DateTime startDateTime = new DateTime(intYear, intMonth, intDay);

            intYear = dTPStop.Value.Year;
            intMonth = dTPStop.Value.Month;
            intDay = dTPStop.Value.Day;
            intHour = Convert.ToInt32(cbSearchStopH.Text);
            intMin = Convert.ToInt32(cbSearchStopM.Text);
            intSec = 59;
            DateTime stopDateTime = new DateTime(intYear, intMonth, intDay);

            DataSet ds = new DataSet();

            TimeSpan tmpTimeSpan = stopDateTime - startDateTime;

            switch (tcMainSearch.SelectedIndex)
            {
                case 0:     //통신이력
                    #region 통신이력 검색 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    //MU별 통신이력 저장할 변수 초기화
                    for (i = 0; i < muTxRxErx.Length; i++)
                    {
                        muTxRxErxResult[i].codeTxRxErx.Clear();
                        muTxRxErxResult[i].contentTxRxErx.Clear();
                        muTxRxErxResult[i].chTxRxErx.Clear();
                        muTxRxErxResult[i].startTime.Clear();
                        muTxRxErxResult[i].stopTime.Clear();

                        for (j = 0; j < 5; j++)
                        {
                            muTxRxErx[i].cntMuTxRxErx[j] = 0;
                            muTxRxErx[i].flagMuTxRxErx[j] = false;
                        }
                    }

                    #region MU의 통신이력 상태 읽어와 정리하기
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    //Database 검색
                    searchResultList = new ArrayList[tmpTimeSpan.Days + 1];      //날자수만큼 검색 결과를 저장할 변수

                    //날자별로 DataBase 파일에 접속하여 검색
                    for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                    {
                        searchResultList[i] = new ArrayList();

                        DateTime tmpDate = startDateTime.AddDays(i);

                        string tmpPath = clsCommon.DataBasePath + tmpDate.Year.ToString("0000") + @"\";
                        string dbFile = "NMS_" + tmpDate.Year.ToString("0000") + tmpDate.Month.ToString("00") + tmpDate.Day.ToString("00") + ".FDB";

                        if (System.IO.File.Exists(tmpPath + dbFile))
                        {
                            if (searchDBMS != null)
                            {
                                searchDBMS.Dispose();
                                searchDBMS = null;
                            }

                            searchDBMS = new nmsDBMS();
                            searchDBMS.DBConnect(tmpPath + dbFile);

                            searchResultList[i] = searchDBMS.MuTxRxErxStFind(startDateTime, stopDateTime);
                        }
                    }

                    for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                    {
                        for (j = 0; j < searchResultList[i].Count; j++)
                        {
                            MuInfo tmpMuInfo = (MuInfo)searchResultList[i][j];

                            int tmpMuId = tmpMuInfo.mu_id - 1;

                            #region 주 송신 상태 이력 저장
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            if (tmpMuInfo.mainPtt == '1')
                            {
                                if (!muTxRxErx[tmpMuId].flagMuTxRxErx[0])
                                {
                                    muTxRxErx[tmpMuId].cntMuTxRxErx[0]++;
                                    muTxRxErx[tmpMuId].flagMuTxRxErx[0] = true;

                                    muTxRxErxResult[tmpMuId].codeTxRxErx.Add(0);
                                    muTxRxErxResult[tmpMuId].startTime.Add(tmpMuInfo.datetime);
                                    muTxRxErxResult[tmpMuId].contentTxRxErx.Add("주 송신");
                                    muTxRxErxResult[tmpMuId].chTxRxErx.Add(tmpMuInfo.mainCh.ToString());
                                }
                            }
                            else
                            {
                                if (muTxRxErx[tmpMuId].flagMuTxRxErx[0])
                                {
                                    muTxRxErx[tmpMuId].flagMuTxRxErx[0] = false;
                                    muTxRxErxResult[tmpMuId].stopTime.Add(tmpMuInfo.datetime);
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion

                            #region 주 수신 상태 이력 저장
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            if (tmpMuInfo.mainBusy == '1')
                            {
                                if (!muTxRxErx[tmpMuId].flagMuTxRxErx[1])
                                {
                                    muTxRxErx[tmpMuId].cntMuTxRxErx[1]++;
                                    muTxRxErx[tmpMuId].flagMuTxRxErx[1] = true;

                                    muTxRxErxResult[tmpMuId].codeTxRxErx.Add(1);
                                    muTxRxErxResult[tmpMuId].startTime.Add(tmpMuInfo.datetime);
                                    muTxRxErxResult[tmpMuId].contentTxRxErx.Add("주 수신");
                                    muTxRxErxResult[tmpMuId].chTxRxErx.Add(tmpMuInfo.mainCh.ToString());
                                }
                            }
                            else
                            {
                                if (muTxRxErx[tmpMuId].flagMuTxRxErx[1])
                                {
                                    muTxRxErx[tmpMuId].flagMuTxRxErx[1] = false;
                                    muTxRxErxResult[tmpMuId].stopTime.Add(tmpMuInfo.datetime);
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion

                            switch (clsCommon.nmsGUIUser)
                            {
                                case "경춘선":
                                    break;

                                case "전라선":
                                case "중앙선":
                                    #region 예비 송신 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.stbyPtt == '1')
                                    {
                                        if (!muTxRxErx[tmpMuId].flagMuTxRxErx[2])
                                        {
                                            muTxRxErx[tmpMuId].cntMuTxRxErx[2]++;
                                            muTxRxErx[tmpMuId].flagMuTxRxErx[2] = true;

                                            muTxRxErxResult[tmpMuId].codeTxRxErx.Add(2);
                                            muTxRxErxResult[tmpMuId].startTime.Add(tmpMuInfo.datetime);
                                            muTxRxErxResult[tmpMuId].contentTxRxErx.Add("예비 송신");
                                            muTxRxErxResult[tmpMuId].chTxRxErx.Add(tmpMuInfo.stbyCh.ToString());
                                        }
                                    }
                                    else
                                    {
                                        if (muTxRxErx[tmpMuId].flagMuTxRxErx[2])
                                        {
                                            muTxRxErx[tmpMuId].flagMuTxRxErx[2] = false;
                                            muTxRxErxResult[tmpMuId].stopTime.Add(tmpMuInfo.datetime);
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region 예비 수신 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.stbyBusy == '1')
                                    {
                                        if (!muTxRxErx[tmpMuId].flagMuTxRxErx[3])
                                        {
                                            muTxRxErx[tmpMuId].cntMuTxRxErx[3]++;
                                            muTxRxErx[tmpMuId].flagMuTxRxErx[3] = true;

                                            muTxRxErxResult[tmpMuId].codeTxRxErx.Add(3);
                                            muTxRxErxResult[tmpMuId].startTime.Add(tmpMuInfo.datetime);
                                            muTxRxErxResult[tmpMuId].contentTxRxErx.Add("예비 수신");
                                            muTxRxErxResult[tmpMuId].chTxRxErx.Add(tmpMuInfo.stbyCh.ToString());
                                        }
                                    }
                                    else
                                    {
                                        if (muTxRxErx[tmpMuId].flagMuTxRxErx[3])
                                        {
                                            muTxRxErx[tmpMuId].flagMuTxRxErx[3] = false;
                                            muTxRxErxResult[tmpMuId].stopTime.Add(tmpMuInfo.datetime);
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion
                                    break;
                            }

                            #region 감청 수신 상태 이력 저장
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            if (tmpMuInfo.monBusy == '1')
                            {
                                if (!muTxRxErx[tmpMuId].flagMuTxRxErx[4])
                                {
                                    muTxRxErx[tmpMuId].cntMuTxRxErx[4]++;
                                    muTxRxErx[tmpMuId].flagMuTxRxErx[4] = true;

                                    muTxRxErxResult[tmpMuId].codeTxRxErx.Add(4);
                                    muTxRxErxResult[tmpMuId].startTime.Add(tmpMuInfo.datetime);
                                    muTxRxErxResult[tmpMuId].contentTxRxErx.Add("감청 수신");
                                    muTxRxErxResult[tmpMuId].chTxRxErx.Add(tmpMuInfo.monCh.ToString());
                                }
                            }
                            else
                            {
                                if (muTxRxErx[tmpMuId].flagMuTxRxErx[4])
                                {
                                    muTxRxErx[tmpMuId].flagMuTxRxErx[4] = false;
                                    muTxRxErxResult[tmpMuId].stopTime.Add(tmpMuInfo.datetime);
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion
                        }
                    }
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    
                    SetListViewItemClear(lvTxRxErxStAllDiaplay);

                    for (i = 0; i < muTxRxErx.Length; i++)
                    {
                        string[] tmpData = new string[7];

                        tmpData[0] = (i + 1).ToString();
                        try
                        {
                            tmpData[1] = (i + 1).ToString() + "(" + stationList[i] + ")";
                        }
                        catch
                        {
                            tmpData[1] = (i + 1).ToString();
                        }

                        for (j = 0; j < 5; j++)
                            tmpData[j + 2] = muTxRxErx[i].cntMuTxRxErx[j].ToString();

                        ListViewItem tmpLV = new ListViewItem(tmpData);
                        SetListViewItemInster(lvTxRxErxStAllDiaplay, i, tmpLV);
                    }
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case 1:     //장애이력
                    #region 장애이력 검색 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    int cntIndex = 0;

                    switch (tcErrorSearch.SelectedIndex)
                    {
                        case 0:     //MU 장애이력
                            #region MU 장애이력 검색 처리
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            //MU별 장애이력 저장할 변수 초기화
                            for (i = 0; i < muErr.Length; i++)
                            {
                                muErrResult[i].errCode.Clear();
                                muErrResult[i].errDateTime.Clear();
                                muErrResult[i].errContent.Clear();

                                for (j = 0; j < 28; j++)
                                {
                                    muErr[i].cntErr[j] = 0;
                                    muErr[i].flagErr[j] = false;
                                }
                            }

                            #region MU의 장애 상태 읽어와 정리하기
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            //Database 검색
                            searchResultList = new ArrayList[tmpTimeSpan.Days + 1];      //날자수만큼 검색 결과를 저장할 변수

                            //날자별로 DataBase 파일에 접속하여 검색
                            for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                            {
                                searchResultList[i] = new ArrayList();

                                DateTime tmpDate = startDateTime.AddDays(i);

                                string tmpPath = clsCommon.DataBasePath + tmpDate.Year.ToString("0000") + @"\";
                                string dbFile = "NMS_" + tmpDate.Year.ToString("0000") + tmpDate.Month.ToString("00") + tmpDate.Day.ToString("00") + ".FDB";

                                if (System.IO.File.Exists(tmpPath + dbFile))
                                {
                                    if (searchDBMS != null)
                                    {
                                        searchDBMS.Dispose();
                                        searchDBMS = null;
                                    }

                                    searchDBMS = new nmsDBMS();
                                    searchDBMS.DBConnect(tmpPath + dbFile);

                                    searchResultList[i] = searchDBMS.MuErrorStFind(startDateTime, stopDateTime);
                                }
                            }

                            for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                            {
                                for (j = 0; j < searchResultList[i].Count; j++)
                                {
                                    MuInfo tmpMuInfo = (MuInfo)searchResultList[i][j];

                                    int tmpMuId = tmpMuInfo.mu_id - 1;

                                    #region AC 전원 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.ac == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[0])
                                        {
                                            muErr[tmpMuId].cntErr[0]++;
                                            muErr[tmpMuId].flagErr[0] = true;

                                            muErrResult[tmpMuId].errCode.Add(0);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("AC 전원 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[0])
                                        {
                                            muErr[tmpMuId].flagErr[0] = false;

                                            muErrResult[tmpMuId].errCode.Add(0);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("AC 전원 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region DC 전원 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.dc == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[1])
                                        {
                                            muErr[tmpMuId].cntErr[1]++;
                                            muErr[tmpMuId].flagErr[1] = true;

                                            muErrResult[tmpMuId].errCode.Add(1);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("DC 전원 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[1])
                                        {
                                            muErr[tmpMuId].flagErr[1] = false;

                                            muErrResult[tmpMuId].errCode.Add(1);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("DC 전원 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region TRX UInit 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.trxUnit == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[2])
                                        {
                                            muErr[tmpMuId].cntErr[2]++;
                                            muErr[tmpMuId].flagErr[2] = true;

                                            muErrResult[tmpMuId].errCode.Add(2);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("TRX Unit Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[2])
                                        {
                                            muErr[tmpMuId].flagErr[2] = false;

                                            muErrResult[tmpMuId].errCode.Add(2);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("TRX Unit Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region 주 통신 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.mainComm == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[3])
                                        {
                                            muErr[tmpMuId].cntErr[3]++;
                                            muErr[tmpMuId].flagErr[3] = true;

                                            muErrResult[tmpMuId].errCode.Add(3);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("주 통신 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[3])
                                        {
                                            muErr[tmpMuId].flagErr[3] = false;

                                            muErrResult[tmpMuId].errCode.Add(3);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("주 통신 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    switch (clsCommon.nmsGUIUser)
                                    {
                                        case "경춘선":
                                        case "중앙선":
                                            break;

                                        case "전라선":
                                            #region 예비 통신 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpMuInfo.stbyComm == '1')
                                            {
                                                if (!muErr[tmpMuId].flagErr[4])
                                                {
                                                    muErr[tmpMuId].cntErr[4]++;
                                                    muErr[tmpMuId].flagErr[4] = true;

                                                    muErrResult[tmpMuId].errCode.Add(4);
                                                    muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                                    muErrResult[tmpMuId].errContent.Add("예비 통신 Error");
                                                }
                                            }
                                            else
                                            {
                                                if (muErr[tmpMuId].flagErr[4])
                                                {
                                                    muErr[tmpMuId].flagErr[4] = false;

                                                    muErrResult[tmpMuId].errCode.Add(4);
                                                    muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                                    muErrResult[tmpMuId].errContent.Add("예비 통신 Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion
                                            break;
                                    }

                                    #region 감청 통신 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.monComm == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[5])
                                        {
                                            muErr[tmpMuId].cntErr[5]++;
                                            muErr[tmpMuId].flagErr[5] = true;

                                            muErrResult[tmpMuId].errCode.Add(5);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("감청 통신 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[5])
                                        {
                                            muErr[tmpMuId].flagErr[5] = false;

                                            muErrResult[tmpMuId].errCode.Add(5);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("감청 통신 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region MU TRX CPU 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.muTrxCpu == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[6])
                                        {
                                            muErr[tmpMuId].cntErr[6]++;
                                            muErr[tmpMuId].flagErr[6] = true;

                                            muErrResult[tmpMuId].errCode.Add(6);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("TRX CPU 장착 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[6])
                                        {
                                            muErr[tmpMuId].flagErr[6] = false;

                                            muErrResult[tmpMuId].errCode.Add(6);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("TRX CPU 장착 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region MU OPT CPU 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.muOptCpu == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[7])
                                        {
                                            muErr[tmpMuId].cntErr[7]++;
                                            muErr[tmpMuId].flagErr[7] = true;

                                            muErrResult[tmpMuId].errCode.Add(7);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT CPU 장착 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[7])
                                        {
                                            muErr[tmpMuId].flagErr[7] = false;

                                            muErrResult[tmpMuId].errCode.Add(7);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT CPU 장착 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region MU UPS 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.MuUps == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[8])
                                        {
                                            muErr[tmpMuId].cntErr[8]++;
                                            muErr[tmpMuId].flagErr[8] = true;

                                            muErrResult[tmpMuId].errCode.Add(8);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("UPS 연결 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[8])
                                        {
                                            muErr[tmpMuId].flagErr[8] = false;

                                            muErrResult[tmpMuId].errCode.Add(8);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("UPS 연결 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region OPT DC 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.optDc == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[9])
                                        {
                                            muErr[tmpMuId].cntErr[9]++;
                                            muErr[tmpMuId].flagErr[9] = true;

                                            muErrResult[tmpMuId].errCode.Add(9);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT DC 전원 상태 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[9])
                                        {
                                            muErr[tmpMuId].flagErr[9] = false;

                                            muErrResult[tmpMuId].errCode.Add(9);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT DC 전원 상태 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region OPT ModOpen 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.optModOpen == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[10])
                                        {
                                            muErr[tmpMuId].cntErr[10]++;
                                            muErr[tmpMuId].flagErr[10] = true;

                                            muErrResult[tmpMuId].errCode.Add(10);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT MODOPEN 상태 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[10])
                                        {
                                            muErr[tmpMuId].flagErr[10] = false;

                                            muErrResult[tmpMuId].errCode.Add(10);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT MODOPEN 상태 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region OPT 1~4 LD 알람 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.opt1Ld == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[11])
                                        {
                                            muErr[tmpMuId].cntErr[11]++;
                                            muErr[tmpMuId].flagErr[11] = true;

                                            muErrResult[tmpMuId].errCode.Add(11);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 1 LD 알람 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[11])
                                        {
                                            muErr[tmpMuId].flagErr[11] = false;

                                            muErrResult[tmpMuId].errCode.Add(11);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 1 LD 알람 Error 복구");
                                        }
                                    }

                                    if (tmpMuInfo.opt2Ld == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[12])
                                        {
                                            muErr[tmpMuId].cntErr[12]++;
                                            muErr[tmpMuId].flagErr[12] = true;

                                            muErrResult[tmpMuId].errCode.Add(12);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 2 LD 알람 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[12])
                                        {
                                            muErr[tmpMuId].flagErr[12] = false;

                                            muErrResult[tmpMuId].errCode.Add(12);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 2 LD 알람 Error 복구");
                                        }
                                    }

                                    if (tmpMuInfo.opt3Ld == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[13])
                                        {
                                            muErr[tmpMuId].cntErr[13]++;
                                            muErr[tmpMuId].flagErr[13] = true;

                                            muErrResult[tmpMuId].errCode.Add(13);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 3 LD 알람 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[13])
                                        {
                                            muErr[tmpMuId].flagErr[13] = false;

                                            muErrResult[tmpMuId].errCode.Add(13);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 3 LD 알람 Error 복구");
                                        }
                                    }

                                    if (tmpMuInfo.opt4Ld == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[14])
                                        {
                                            muErr[tmpMuId].cntErr[14]++;
                                            muErr[tmpMuId].flagErr[14] = true;

                                            muErrResult[tmpMuId].errCode.Add(14);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 4 LD 알람 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[14])
                                        {
                                            muErr[tmpMuId].flagErr[14] = false;

                                            muErrResult[tmpMuId].errCode.Add(14);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 4 LD 알람 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region OPT 1~4 PD 알람 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.opt1Pd == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[15])
                                        {
                                            muErr[tmpMuId].cntErr[15]++;
                                            muErr[tmpMuId].flagErr[15] = true;

                                            muErrResult[tmpMuId].errCode.Add(15);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 1 PD 알람 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[15])
                                        {
                                            muErr[tmpMuId].flagErr[15] = false;

                                            muErrResult[tmpMuId].errCode.Add(15);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 1 PD 알람 Error 복구");
                                        }
                                    }

                                    if (tmpMuInfo.opt2Pd == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[16])
                                        {
                                            muErr[tmpMuId].cntErr[16]++;
                                            muErr[tmpMuId].flagErr[16] = true;

                                            muErrResult[tmpMuId].errCode.Add(16);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 2 PD 알람 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[16])
                                        {
                                            muErr[tmpMuId].flagErr[16] = false;

                                            muErrResult[tmpMuId].errCode.Add(16);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 2 PD 알람 Error 복구");
                                        }
                                    }

                                    if (tmpMuInfo.opt3Pd == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[17])
                                        {
                                            muErr[tmpMuId].cntErr[17]++;
                                            muErr[tmpMuId].flagErr[17] = true;

                                            muErrResult[tmpMuId].errCode.Add(17);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 3 PD 알람 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[17])
                                        {
                                            muErr[tmpMuId].flagErr[17] = false;

                                            muErrResult[tmpMuId].errCode.Add(17);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 3 PD 알람 Error 복구");
                                        }
                                    }

                                    if (tmpMuInfo.opt4Pd == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[18])
                                        {
                                            muErr[tmpMuId].cntErr[18]++;
                                            muErr[tmpMuId].flagErr[18] = true;

                                            muErrResult[tmpMuId].errCode.Add(18);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 4 PD 알람 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[18])
                                        {
                                            muErr[tmpMuId].flagErr[18] = false;

                                            muErrResult[tmpMuId].errCode.Add(18);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("OPT 4 PD 알람 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region 주 Pll Lock 장애 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.mainPllLock == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[19])
                                        {
                                            muErr[tmpMuId].cntErr[19]++;
                                            muErr[tmpMuId].flagErr[19] = true;

                                            muErrResult[tmpMuId].errCode.Add(19);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("주 PLL LOCK 장애 상태");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[19])
                                        {
                                            muErr[tmpMuId].flagErr[19] = false;

                                            muErrResult[tmpMuId].errCode.Add(19);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("주 PLL LOCK 장애 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    switch (clsCommon.nmsGUIUser)
                                    {
                                        case "경춘선":
                                        case "중앙선":
                                            break;

                                        case "전라선":
                                            #region 예비 Pll Lock 장애 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpMuInfo.stbyPllLock == '1')
                                            {
                                                if (!muErr[tmpMuId].flagErr[20])
                                                {
                                                    muErr[tmpMuId].cntErr[20]++;
                                                    muErr[tmpMuId].flagErr[20] = true;

                                                    muErrResult[tmpMuId].errCode.Add(20);
                                                    muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                                    muErrResult[tmpMuId].errContent.Add("예비 PLL LOCK 장애 상태");
                                                }
                                            }
                                            else
                                            {
                                                if (muErr[tmpMuId].flagErr[20])
                                                {
                                                    muErr[tmpMuId].flagErr[20] = false;

                                                    muErrResult[tmpMuId].errCode.Add(20);
                                                    muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                                    muErrResult[tmpMuId].errContent.Add("예비 PLL LOCK 장애 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion
                                            break;
                                    }

                                    #region 감청 Pll Lock 장애 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpMuInfo.monPllLock == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[21])
                                        {
                                            muErr[tmpMuId].cntErr[21]++;
                                            muErr[tmpMuId].flagErr[21] = true;

                                            muErrResult[tmpMuId].errCode.Add(21);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("감청 PLL LOCK 장애 상태");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[21])
                                        {
                                            muErr[tmpMuId].flagErr[21] = false;

                                            muErrResult[tmpMuId].errCode.Add(21);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("감청 PLL LOCK 장애 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    switch (clsCommon.nmsGUIUser)
                                    {
                                        case "경춘선":
                                            #region FM 재방송 장치 Power 장애 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpMuInfo.fm_Power == '1')
                                            {
                                                if (!muErr[tmpMuId].flagErr[22])
                                                {
                                                    muErr[tmpMuId].cntErr[22]++;
                                                    muErr[tmpMuId].flagErr[22] = true;

                                                    muErrResult[tmpMuId].errCode.Add(22);
                                                    muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                                    muErrResult[tmpMuId].errContent.Add("FM 재방송 장치 POWER 장애 상태");
                                                }
                                            }
                                            else
                                            {
                                                if (muErr[tmpMuId].flagErr[22])
                                                {
                                                    muErr[tmpMuId].flagErr[22] = false;

                                                    muErrResult[tmpMuId].errCode.Add(22);
                                                    muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                                    muErrResult[tmpMuId].errContent.Add("FM 재방송 장치 POWER 장애 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region FM 재방송 장치 Rf 장애 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpMuInfo.fm_Rf == '1')
                                            {
                                                if (!muErr[tmpMuId].flagErr[23])
                                                {
                                                    muErr[tmpMuId].cntErr[23]++;
                                                    muErr[tmpMuId].flagErr[23] = true;

                                                    muErrResult[tmpMuId].errCode.Add(23);
                                                    muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                                    muErrResult[tmpMuId].errContent.Add("FM 재방송 장치 RF 장애 상태");
                                                }
                                            }
                                            else
                                            {
                                                if (muErr[tmpMuId].flagErr[23])
                                                {
                                                    muErr[tmpMuId].flagErr[23] = false;

                                                    muErrResult[tmpMuId].errCode.Add(23);
                                                    muErrResult[tmpMuId].errDateTime.Add(tmpMuInfo.datetime);
                                                    muErrResult[tmpMuId].errContent.Add("FM 재방송 장치 RF 장애 복구");
                                                }
                                            }
                                        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion
                                            break;
                                    }
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion

                            #region UPS의 장애 상태 읽어와 정리하기
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            //Database 검색
                            searchResultList = new ArrayList[tmpTimeSpan.Days + 1];      //날자수만큼 검색 결과를 저장할 변수

                            //날자별로 DataBase 파일에 접속하여 검색
                            for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                            {
                                searchResultList[i] = new ArrayList();

                                DateTime tmpDate = startDateTime.AddDays(i);

                                string tmpPath = clsCommon.DataBasePath + tmpDate.Year.ToString("0000") + @"\";
                                string dbFile = "NMS_" + tmpDate.Year.ToString("0000") + tmpDate.Month.ToString("00") + tmpDate.Day.ToString("00") + ".FDB";

                                if (System.IO.File.Exists(tmpPath + dbFile))
                                {
                                    if (searchDBMS != null)
                                    {
                                        searchDBMS.Dispose();
                                        searchDBMS = null;
                                    }

                                    searchDBMS = new nmsDBMS();
                                    searchDBMS.DBConnect(tmpPath + dbFile);

                                    searchResultList[i] = searchDBMS.UpsErrorStFind(startDateTime, stopDateTime);
                                }
                            }

                            for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                            {
                                for (j = 0; j < searchResultList[i].Count; j++)
                                {
                                    UpsInfo tmpUpsInfo = (UpsInfo)searchResultList[i][j];

                                    int tmpMuId = tmpUpsInfo.mu_id - 1;

                                    #region 입력전원 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpUpsInfo.upsFailed == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[22])
                                        {
                                            muErr[tmpMuId].cntErr[22]++;
                                            muErr[tmpMuId].flagErr[22] = true;

                                            muErrResult[tmpMuId].errCode.Add(22);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpUpsInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("UPS 입력전원 장애");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[22])
                                        {
                                            muErr[tmpMuId].flagErr[22] = false;

                                            muErrResult[tmpMuId].errCode.Add(22);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpUpsInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("UPS 입력전원 장애 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region Bypass 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (clsCommon.nmsGUIUser != "경춘선")
                                    {
                                        if (tmpUpsInfo.bypass == '1')
                                        {
                                            if (!muErr[tmpMuId].flagErr[23])
                                            {
                                                muErr[tmpMuId].cntErr[23]++;
                                                muErr[tmpMuId].flagErr[23] = true;

                                                muErrResult[tmpMuId].errCode.Add(23);
                                                muErrResult[tmpMuId].errDateTime.Add(tmpUpsInfo.datetime);
                                                muErrResult[tmpMuId].errContent.Add("UPS Bypass 장애");
                                            }
                                        }
                                        else
                                        {
                                            if (muErr[tmpMuId].flagErr[23])
                                            {
                                                muErr[tmpMuId].flagErr[23] = false;

                                                muErrResult[tmpMuId].errCode.Add(23);
                                                muErrResult[tmpMuId].errDateTime.Add(tmpUpsInfo.datetime);
                                                muErrResult[tmpMuId].errContent.Add("UPS Bypass 장애 복구");
                                            }
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region Battery Low 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpUpsInfo.batteryLow == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[24])
                                        {
                                            muErr[tmpMuId].cntErr[24]++;
                                            muErr[tmpMuId].flagErr[24] = true;

                                            muErrResult[tmpMuId].errCode.Add(24);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpUpsInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("UPS Battery Low 장애");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[24])
                                        {
                                            muErr[tmpMuId].flagErr[24] = false;

                                            muErrResult[tmpMuId].errCode.Add(24);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpUpsInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("UPS Battery Low 장애 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region UPS Error 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpUpsInfo.utilityFail == '1')
                                    {
                                        if (!muErr[tmpMuId].flagErr[25])
                                        {
                                            muErr[tmpMuId].cntErr[25]++;
                                            muErr[tmpMuId].flagErr[25] = true;

                                            muErrResult[tmpMuId].errCode.Add(25);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpUpsInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("UPS 장애");
                                        }
                                    }
                                    else
                                    {
                                        if (muErr[tmpMuId].flagErr[25])
                                        {
                                            muErr[tmpMuId].flagErr[25] = false;

                                            muErrResult[tmpMuId].errCode.Add(25);
                                            muErrResult[tmpMuId].errDateTime.Add(tmpUpsInfo.datetime);
                                            muErrResult[tmpMuId].errContent.Add("UPS 장애 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion

                            SetListViewItemClear(lvMUErrorStAllDiaplay);

                            for (i = 0; i < muErr.Length; i++)
                            {
                                string[] tmpData = new string[30];

                                tmpData[0] = (i + 1).ToString();
                                try
                                {
                                    tmpData[1] = (i + 1).ToString() + "(" + stationList[i] + ")";
                                }
                                catch
                                {
                                    tmpData[1] = (i + 1).ToString();
                                }

                                for (j = 0; j < 28; j++)
                                    tmpData[j + 2] = muErr[i].cntErr[j].ToString();

                                ListViewItem tmpLV = new ListViewItem(tmpData);
                                SetListViewItemInster(lvMUErrorStAllDiaplay, i, tmpLV);
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion
                            break;

                        case 1:      //RU 장애이력
                            #region RU 장애이력 검색 처리
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            //RU별 장애이력 저장할 변수 초기화
                            for (i = 0; i < stationList.Count; i++)
                            {
                                for (j = 0; j < 4; j++)
                                {
                                    ruErrResult[i, j].errCode.Clear();
                                    ruErrResult[i, j].errDateTime.Clear();
                                    ruErrResult[i, j].errContent.Clear();

                                    for (int k = 0; k < 11; k++)
                                    {
                                        ruErr[i, j].cntErr[k] = 0;
                                        ruErr[i, j].flagErr[k] = false;
                                    }
                                }
                            }

                            #region RU의 장애 상태 읽어와 정리하기
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            //Database 검색
                            searchResultList = new ArrayList[tmpTimeSpan.Days + 1];      //날자수만큼 검색 결과를 저장할 변수

                            //날자별로 DataBase 파일에 접속하여 검색
                            for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                            {
                                searchResultList[i] = new ArrayList();

                                DateTime tmpDate = startDateTime.AddDays(i);

                                string tmpPath = clsCommon.DataBasePath + tmpDate.Year.ToString("0000") + @"\";
                                string dbFile = "NMS_" + tmpDate.Year.ToString("0000") + tmpDate.Month.ToString("00") + tmpDate.Day.ToString("00") + ".FDB";

                                if (System.IO.File.Exists(tmpPath + dbFile))
                                {
                                    if (searchDBMS != null)
                                    {
                                        searchDBMS.Dispose();
                                        searchDBMS = null;
                                    }

                                    searchDBMS = new nmsDBMS();
                                    searchDBMS.DBConnect(tmpPath + dbFile);

                                    searchResultList[i] = searchDBMS.RuErrorStFind(startDateTime, stopDateTime);
                                }
                            }

                            for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                            {
                                for (j = 0; j < searchResultList[i].Count; j++)
                                {
                                    RuInfo tmpRuInfo = (RuInfo)searchResultList[i][j];

                                    int tmpMuId = tmpRuInfo.mu_id - 1;
                                    int tmpRuId = tmpRuInfo.ru_id - 1;

                                    #region AC 전원 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpRuInfo.ac == '1')
                                    {
                                        if (!ruErr[tmpMuId, tmpRuId].flagErr[0])
                                        {
                                            ruErr[tmpMuId, tmpRuId].cntErr[0]++;
                                            ruErr[tmpMuId, tmpRuId].flagErr[0] = true;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(0);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("AC 전원 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (ruErr[tmpMuId, tmpRuId].flagErr[0])
                                        {
                                            ruErr[tmpMuId, tmpRuId].flagErr[0] = false;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(0);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("AC 전원 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region DC 전원 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpRuInfo.dc == '1')
                                    {
                                        if (!ruErr[tmpMuId, tmpRuId].flagErr[1])
                                        {
                                            ruErr[tmpMuId, tmpRuId].cntErr[1]++;
                                            ruErr[tmpMuId, tmpRuId].flagErr[1] = true;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(1);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("DC 전원 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (ruErr[tmpMuId, tmpRuId].flagErr[1])
                                        {
                                            ruErr[tmpMuId, tmpRuId].flagErr[1] = false;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(1);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("DC 전원 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region ModOpen 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpRuInfo.modOpen == '1')
                                    {
                                        if (!ruErr[tmpMuId, tmpRuId].flagErr[2])
                                        {
                                            ruErr[tmpMuId, tmpRuId].cntErr[2]++;
                                            ruErr[tmpMuId, tmpRuId].flagErr[2] = true;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(2);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("MODOPEN Error");
                                        }
                                    }
                                    else
                                    {
                                        if (ruErr[tmpMuId, tmpRuId].flagErr[2])
                                        {
                                            ruErr[tmpMuId, tmpRuId].flagErr[2] = false;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(2);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("MODOPEN Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region RuCpu 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpRuInfo.ruCpu == '1')
                                    {
                                        if (!ruErr[tmpMuId, tmpRuId].flagErr[3])
                                        {
                                            ruErr[tmpMuId, tmpRuId].cntErr[3]++;
                                            ruErr[tmpMuId, tmpRuId].flagErr[3] = true;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(3);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("RU CPU Error");
                                        }
                                    }
                                    else
                                    {
                                        if (ruErr[tmpMuId, tmpRuId].flagErr[3])
                                        {
                                            ruErr[tmpMuId, tmpRuId].flagErr[3] = false;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(3);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("RU CPU Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region 데이터 광접속 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpRuInfo.data == '1')
                                    {
                                        if (!ruErr[tmpMuId, tmpRuId].flagErr[4])
                                        {
                                            ruErr[tmpMuId, tmpRuId].cntErr[4]++;
                                            ruErr[tmpMuId, tmpRuId].flagErr[4] = true;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(4);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("데이터 광접속 상태 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (ruErr[tmpMuId, tmpRuId].flagErr[4])
                                        {
                                            ruErr[tmpMuId, tmpRuId].flagErr[4] = false;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(4);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("데이터 광접속 상태 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region OPT LD 알람 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpRuInfo.optLd == '1')
                                    {
                                        if (!ruErr[tmpMuId, tmpRuId].flagErr[5])
                                        {
                                            ruErr[tmpMuId, tmpRuId].cntErr[5]++;
                                            ruErr[tmpMuId, tmpRuId].flagErr[5] = true;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(5);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("OPT LD 알람 Error");
                                        }
                                    }
                                    else
                                    {
                                        if (ruErr[tmpMuId, tmpRuId].flagErr[5])
                                        {
                                            ruErr[tmpMuId, tmpRuId].flagErr[5] = false;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(5);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("OPT LD 알람 Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region XMTR PLL LOCK 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpRuInfo.xmtrPllLock == '1')
                                    {
                                        if (!ruErr[tmpMuId, tmpRuId].flagErr[6])
                                        {
                                            ruErr[tmpMuId, tmpRuId].cntErr[6]++;
                                            ruErr[tmpMuId, tmpRuId].flagErr[6] = true;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(6);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("MAIN PA FAULT");
                                        }
                                    }
                                    else
                                    {
                                        if (ruErr[tmpMuId, tmpRuId].flagErr[6])
                                        {
                                            ruErr[tmpMuId, tmpRuId].flagErr[6] = false;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(6);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("MAIN PA FAULT 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region RCVR PLL LOCK 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    if (tmpRuInfo.rcvrpllLock == '1')
                                    {
                                        if (!ruErr[tmpMuId, tmpRuId].flagErr[7])
                                        {
                                            ruErr[tmpMuId, tmpRuId].cntErr[7]++;
                                            ruErr[tmpMuId, tmpRuId].flagErr[7] = true;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(7);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("STBY PA FAULT");
                                        }
                                    }
                                    else
                                    {
                                        if (ruErr[tmpMuId, tmpRuId].flagErr[7])
                                        {
                                            ruErr[tmpMuId, tmpRuId].flagErr[7] = false;

                                            ruErrResult[tmpMuId, tmpRuId].errCode.Add(7);
                                            ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                            ruErrResult[tmpMuId, tmpRuId].errContent.Add("STBY PA FAULT 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    switch (clsCommon.nmsGUIUser)
                                    {
                                        case "경춘선":
                                            #region FM 재방송 장치 Power 장애 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpRuInfo.fm_Power == '1')
                                            {
                                                if (!ruErr[tmpMuId, tmpRuId].flagErr[8])
                                                {
                                                    ruErr[tmpMuId, tmpRuId].cntErr[8]++;
                                                    ruErr[tmpMuId, tmpRuId].flagErr[8] = true;

                                                    ruErrResult[tmpMuId, tmpRuId].errCode.Add(8);
                                                    ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                                    ruErrResult[tmpMuId, tmpRuId].errContent.Add("FM 재방송 장치 POWER 장애 상태");
                                                }
                                            }
                                            else
                                            {
                                                if (ruErr[tmpMuId, tmpRuId].flagErr[8])
                                                {
                                                    ruErr[tmpMuId, tmpRuId].flagErr[8] = false;

                                                    ruErrResult[tmpMuId, tmpRuId].errCode.Add(8);
                                                    ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                                    ruErrResult[tmpMuId, tmpRuId].errContent.Add("FM 재방송 장치 POWER 장애 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region FM 재방송 장치 Rf 장애 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpRuInfo.fm_Rf == '1')
                                            {
                                                if (!ruErr[tmpMuId, tmpRuId].flagErr[9])
                                                {
                                                    ruErr[tmpMuId, tmpRuId].cntErr[9]++;
                                                    ruErr[tmpMuId, tmpRuId].flagErr[9] = true;

                                                    ruErrResult[tmpMuId, tmpRuId].errCode.Add(9);
                                                    ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                                    ruErrResult[tmpMuId, tmpRuId].errContent.Add("FM 재방송 장치 RF 장애 상태");
                                                }
                                            }
                                            else
                                            {
                                                if (ruErr[tmpMuId, tmpRuId].flagErr[9])
                                                {
                                                    ruErr[tmpMuId, tmpRuId].flagErr[9] = false;

                                                    ruErrResult[tmpMuId, tmpRuId].errCode.Add(9);
                                                    ruErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuInfo.datetime);
                                                    ruErrResult[tmpMuId, tmpRuId].errContent.Add("FM 재방송 장치 RF 장애 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion
                                            break;
                                    }
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion

                            SetListViewItemClear(lvRUErrorStAllDiaplay);

                            for (i = 0; i < stationList.Count; i++)
                            {
                                for (j = 0; j < 4; j++)
                                {
                                    if (clsCommon.muruName[i].ruName[j].ruName == "") continue;

                                    string[] tmpData = new string[14];

                                    tmpData[0] = (cntIndex + 1).ToString();
                                    try
                                    {
                                        tmpData[1] = (i + 1).ToString() + "(" + stationList[i] + ")";
                                    }
                                    catch
                                    {
                                        tmpData[1] = (i + 1).ToString();
                                    }

                                    try
                                    {
                                        tmpData[2] = (j + 1).ToString() + "(" + clsCommon.muruName[i].ruName[j].ruName + ")";
                                    }
                                    catch
                                    {
                                        tmpData[2] = (j + 1).ToString();
                                    }

                                    for (int k = 0; k < 11; k++)
                                        tmpData[k + 3] = ruErr[i, j].cntErr[k].ToString();

                                    ListViewItem tmpLV = new ListViewItem(tmpData);
                                    SetListViewItemInster(lvRUErrorStAllDiaplay, cntIndex++, tmpLV);
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion
                            break;

                        case 2:     //BDA 장애이력
                            #region BDA 장애이력 검색 처리
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            //BDA별 장애이력 저장할 변수 초기화
                            for (i = 0; i < stationList.Count; i++)
                            {
                                for (j = 0; j < 4; j++)
                                {
                                    for (int k = 0; k < 4; k++)
                                    {
                                        bdaErrResult[i, j, k].errCode.Clear();
                                        bdaErrResult[i, j, k].errDateTime.Clear();
                                        bdaErrResult[i, j, k].errContent.Clear();

                                        for (int l = 0; l < 13; l++)
                                        {
                                            bdaErr[i, j, k].cntErr[l] = 0;
                                            bdaErr[i, j, k].flagErr[l] = false;
                                        }
                                    }
                                }
                            }

                            bool flagBdaSearch = true;
                            ListView tmpBDAErrorStAllDisplay = new ListView();

                            searchResultList = new ArrayList[tmpTimeSpan.Days + 1];     //날자수만큼 검색 결과를 저장할 변수

                            switch (clsCommon.nmsGUIUser)
                            {
                                case "경춘선":
                                    tmpBDAErrorStAllDisplay = lvBDAErrorStAllDiaplay;

                                    #region BDA의 장애 상태 읽어와 정리하기
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    //Database 검색
                                    //날자별로 DataBase 파일에 접속하여 검색
                                    for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                                    {
                                        searchResultList[i] = new ArrayList();

                                        DateTime tmpDate = startDateTime.AddDays(i);

                                        string tmpPath = clsCommon.DataBasePath + tmpDate.Year.ToString("0000") + @"\";
                                        string dbFile = "NMS_" + tmpDate.Year.ToString("0000") + tmpDate.Month.ToString("00") + tmpDate.Day.ToString("00") + ".FDB";

                                        if (System.IO.File.Exists(tmpPath + dbFile))
                                        {
                                            if (searchDBMS != null)
                                            {
                                                searchDBMS.Dispose();
                                                searchDBMS = null;
                                            }

                                            searchDBMS = new nmsDBMS();
                                            searchDBMS.DBConnect(tmpPath + dbFile);

                                            searchResultList[i] = searchDBMS.BdaErrorStFind(startDateTime, stopDateTime);
                                        }
                                    }

                                    for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                                    {
                                        for (j = 0; j < searchResultList[i].Count; j++)
                                        {
                                            BdaInfo tmpBdaInfo = (BdaInfo)searchResultList[i][j];

                                            int tmpMuId = tmpBdaInfo.mu_id - 1;
                                            int tmpRuId = tmpBdaInfo.ru_id - 1;
                                            int tmpBdaId = tmpBdaInfo.bda_id - 1;

                                            #region FM 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.fm == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[0])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[0]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[0] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(0);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("FM Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[0])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[0] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(0);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("FM Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region VHF 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.vhf == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[1])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[1]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[1] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(1);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("VHF Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[1])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[1] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(1);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("VHF Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region DMB 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.dmb == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[2])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[2]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[2] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(2);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("DMB Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[2])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[2] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(2);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("DMB Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region 방호 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.protection == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[3])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[3]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[3] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(3);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("방호 Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[3])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[3] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(3);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("방호 Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region TRS 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.trs == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[4])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[4]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[4] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(4);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("TRS Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[4])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[4] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(4);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("TRS Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region 12V 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.power12 == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[5])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[5]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[5] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(5);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("12V Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[5])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[5] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(5);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("12V Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region 24V 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.power24 == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[6])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[6]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[6] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(6);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("24V Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[6])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[6] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(6);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("24V Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region 220V 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.power220 == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[7])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[7]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[7] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(7);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("220V Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[7])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[7] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(7);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("220V Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region 통신 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.comm == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[8])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[8]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[8] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(8);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("통신 Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[8])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[8] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(8);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("통신 Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region UPS Bypass 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (clsCommon.nmsGUIUser != "경춘선")
                                            {
                                                if (tmpBdaInfo.upsBypass == '1')
                                                {
                                                    if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[9])
                                                    {
                                                        bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[9]++;
                                                        bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[9] = true;

                                                        bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(9);
                                                        bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                        bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UPS Bypass Error");
                                                    }
                                                }
                                                else
                                                {
                                                    if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[9])
                                                    {
                                                        bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[9] = false;

                                                        bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(9);
                                                        bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                        bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UPS Bypass Error 복구");
                                                    }
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region UPS AC 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.upsAC == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[10])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[10]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[10] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(10);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UPS AC Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[10])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[10] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(10);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UPS AC Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region UPS Fail 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.upsFail == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[11])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[11]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[11] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(11);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UPS Fail Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[11])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[11] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(11);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UPS Fail Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region UPS Battery 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            if (tmpBdaInfo.upsBattery == '1')
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[12])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[12]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[12] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(12);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UPS Battery Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[12])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[12] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(12);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UPS Battery Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion
                                    break;

                                case "중앙선":
                                    tmpBDAErrorStAllDisplay = lvsourcetelBDAErrorStAllDiaplay;

                                    #region BDA의 장애 상태 읽어와 정리하기
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    //Database 검색
                                    //날자별로 DataBase 파일에 접속하여 검색
                                    for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                                    {
                                        searchResultList[i] = new ArrayList();

                                        DateTime tmpDate = startDateTime.AddDays(i);

                                        string tmpPath = clsCommon.DataBasePath + tmpDate.Year.ToString("0000") + @"\";
                                        string dbFile = "NMS_" + tmpDate.Year.ToString("0000") + tmpDate.Month.ToString("00") + tmpDate.Day.ToString("00") + ".FDB";

                                        if (System.IO.File.Exists(tmpPath + dbFile))
                                        {
                                            if (searchDBMS != null)
                                            {
                                                searchDBMS.Dispose();
                                                searchDBMS = null;
                                            }

                                            searchDBMS = new nmsDBMS();
                                            searchDBMS.DBConnect(tmpPath + dbFile);

                                            searchResultList[i] = searchDBMS.sourcetelBdaErrorStFind(startDateTime, stopDateTime);
                                        }
                                    }

                                    for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                                    {
                                        for (j = 0; j < searchResultList[i].Count; j++)
                                        {
                                            BDA_St tmpBdaInfo = (BDA_St)searchResultList[i][j];

                                            int tmpMuId = tmpBdaInfo.mu_id - 1;
                                            int tmpRuId = tmpBdaInfo.ru_id - 1;
                                            int tmpBdaId = tmpBdaInfo.bda_id - 1;

                                            #region FM Alarm 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            errCount = 0;

                                            if (tmpBdaInfo.fmAlarm == 0)
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[errCount]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("FM Alarm Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("FM Alarm Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region VHF AMP 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            errCount++;

                                            if (tmpBdaInfo.vhfBypass == 1)
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[errCount]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("VHF AMP Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("VHF AMP Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region VHF AC Alarm 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            errCount++;

                                            if (tmpBdaInfo.vhfAcAlarm == 0)
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[errCount]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("VHF AC Alarm Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("VHF AC Alarm Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region VHF DC Alarm 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            errCount++;

                                            if (tmpBdaInfo.vhfDcAlarm == 0)
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[errCount]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("VHF DC Alarm Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("VHF DC Alarm Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region VHF Battery Alarm 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            errCount++;

                                            if (tmpBdaInfo.vhfBatteryAlarm == 0)
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[errCount]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("VHF Battery Alarm Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("VHF Battery Alarm Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region UHF AMP 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            errCount++;

                                            if (tmpBdaInfo.uhfBypass == 1)
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[errCount]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UHF AMP Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UHF AMP Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region UHF AC Alarm 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            errCount++;

                                            if (tmpBdaInfo.uhfAcAlarm == 0)
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[errCount]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UHF AC Alarm Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UHF AC Alarm Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region UHF DC Alarm 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            errCount++;

                                            if (tmpBdaInfo.uhfDcAlarm == 0)
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[errCount]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UHF DC Alarm Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UHF DC Alarm Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion

                                            #region UHF Battery Alarm 상태 이력 저장
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            errCount++;

                                            if (tmpBdaInfo.vhfBatteryAlarm == 0)
                                            {
                                                if (!bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].cntErr[errCount]++;
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = true;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UHF Battery Alarm Error");
                                                }
                                            }
                                            else
                                            {
                                                if (bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount])
                                                {
                                                    bdaErr[tmpMuId, tmpRuId, tmpBdaId].flagErr[errCount] = false;

                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errCode.Add(errCount);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errDateTime.Add(tmpBdaInfo.datetime);
                                                    bdaErrResult[tmpMuId, tmpRuId, tmpBdaId].errContent.Add("UHF Battery Alarm Error 복구");
                                                }
                                            }
                                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                            #endregion
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion
                                    break;

                                default:
                                    flagBdaSearch = false;
                                    break;
                            }


                            if (flagBdaSearch)
                            {
                                SetListViewItemClear(tmpBDAErrorStAllDisplay);

                                for (i = 0; i < stationList.Count; i++)
                                {
                                    for (j = 0; j < 4; j++)
                                    {
                                        for (int k = 0; k < 4; k++)
                                        {
                                            if (clsCommon.muruName[i].ruName[j].bdaName[k] == "") continue;

                                            string[] tmpData = new string[17];

                                            tmpData[0] = (cntIndex + 1).ToString();
                                            try
                                            {
                                                tmpData[1] = (i + 1).ToString() + "(" + stationList[i] + ")";
                                            }
                                            catch
                                            {
                                                tmpData[1] = (i + 1).ToString();
                                            }

                                            try
                                            {
                                                tmpData[2] = (j + 1).ToString() + "(" + clsCommon.muruName[i].ruName[j].ruName + ")";
                                            }
                                            catch
                                            {
                                                tmpData[2] = (j + 1).ToString();
                                            }

                                            try
                                            {
                                                tmpData[3] = (k + 1).ToString() + "(" + clsCommon.muruName[i].ruName[j].bdaName[k] + ")";
                                            }
                                            catch
                                            {
                                                tmpData[3] = (k + 1).ToString();
                                            }

                                            for (int l = 0; l < 13; l++)
                                                tmpData[l + 4] = bdaErr[i, j, k].cntErr[l].ToString();

                                            ListViewItem tmpLV = new ListViewItem(tmpData);
                                            SetListViewItemInster(tmpBDAErrorStAllDisplay, cntIndex++, tmpLV);
                                        }
                                    }
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion
                            break;

                        case 3:     //FM 모장치 장애이력
                            #region FM 모장치 장애이력 검색 처리
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            //MU의 FM 장애이력 저장할 변수 초기화
                            for (i = 0; i < muFmErr.Length; i++)
                            {
                                muFmErrResult[i].errCode.Clear();
                                muFmErrResult[i].errDateTime.Clear();
                                muFmErrResult[i].errContent.Clear();

                                for (j = 0; j < 5; j++)
                                {
                                    muFmErr[i].cntErr[j] = 0;
                                    muFmErr[i].flagErr[j] = false;
                                }
                            }

                            #region FM 모장치의 장애 상태 읽어와 정리하기
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            //Database 검색
                            searchResultList = new ArrayList[tmpTimeSpan.Days + 1];      //날자수만큼 검색 결과를 저장할 변수

                            //날자별로 DataBase 파일에 접속하여 검색
                            for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                            {
                                searchResultList[i] = new ArrayList();

                                DateTime tmpDate = startDateTime.AddDays(i);

                                string tmpPath = clsCommon.DataBasePath + tmpDate.Year.ToString("0000") + @"\";
                                string dbFile = "NMS_" + tmpDate.Year.ToString("0000") + tmpDate.Month.ToString("00") + tmpDate.Day.ToString("00") + ".FDB";

                                if (System.IO.File.Exists(tmpPath + dbFile))
                                {
                                    if (searchDBMS != null)
                                    {
                                        searchDBMS.Dispose();
                                        searchDBMS = null;
                                    }

                                    searchDBMS = new nmsDBMS();
                                    searchDBMS.DBConnect(tmpPath + dbFile);

                                    searchResultList[i] = searchDBMS.RuFmErrorStFind(startDateTime, stopDateTime, true);
                                }
                            }

                            for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                            {
                                for (j = 0; j < searchResultList[i].Count; j++)
                                {
                                    FM_Info tmpRuAFmInfo = (FM_Info)searchResultList[i][j];

                                    int tmpMuId = tmpRuAFmInfo.mu_id - 1;

                                    #region AC Input Fail 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    errCount = 0;

                                    if (tmpRuAFmInfo.acInputFail == 0)
                                    {
                                        if (!muFmErr[tmpMuId].flagErr[errCount])
                                        {
                                            muFmErr[tmpMuId].cntErr[errCount]++;
                                            muFmErr[tmpMuId].flagErr[errCount] = true;

                                            muFmErrResult[tmpMuId].errCode.Add(errCount);
                                            muFmErrResult[tmpMuId].errDateTime.Add(tmpRuAFmInfo.datetime);
                                            muFmErrResult[tmpMuId].errContent.Add("AC Input Fail");
                                        }
                                    }
                                    else
                                    {
                                        if (muFmErr[tmpMuId].flagErr[errCount])
                                        {
                                            muFmErr[tmpMuId].flagErr[errCount] = false;

                                            muFmErrResult[tmpMuId].errCode.Add(errCount);
                                            muFmErrResult[tmpMuId].errDateTime.Add(tmpRuAFmInfo.datetime);
                                            muFmErrResult[tmpMuId].errContent.Add("AC Input Fail 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region lnaFail 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    errCount++;

                                    if (tmpRuAFmInfo.lnaFail == 0)
                                    {
                                        if (!muFmErr[tmpMuId].flagErr[errCount])
                                        {
                                            muFmErr[tmpMuId].cntErr[errCount]++;
                                            muFmErr[tmpMuId].flagErr[errCount] = true;

                                            muFmErrResult[tmpMuId].errCode.Add(errCount);
                                            muFmErrResult[tmpMuId].errDateTime.Add(tmpRuAFmInfo.datetime);
                                            muFmErrResult[tmpMuId].errContent.Add("lna Fail");
                                        }
                                    }
                                    else
                                    {
                                        if (muFmErr[tmpMuId].flagErr[errCount])
                                        {
                                            muFmErr[tmpMuId].flagErr[errCount] = false;

                                            muFmErrResult[tmpMuId].errCode.Add(errCount);
                                            muFmErrResult[tmpMuId].errDateTime.Add(tmpRuAFmInfo.datetime);
                                            muFmErrResult[tmpMuId].errContent.Add("lna Fail 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region Dc Output Fail 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    errCount++;

                                    if (tmpRuAFmInfo.dcOutputFail == 0)
                                    {
                                        if (!muFmErr[tmpMuId].flagErr[errCount])
                                        {
                                            muFmErr[tmpMuId].cntErr[errCount]++;
                                            muFmErr[tmpMuId].flagErr[errCount] = true;

                                            muFmErrResult[tmpMuId].errCode.Add(errCount);
                                            muFmErrResult[tmpMuId].errDateTime.Add(tmpRuAFmInfo.datetime);
                                            muFmErrResult[tmpMuId].errContent.Add("Dc Output Fail");
                                        }
                                    }
                                    else
                                    {
                                        if (muFmErr[tmpMuId].flagErr[errCount])
                                        {
                                            muFmErr[tmpMuId].flagErr[errCount] = false;

                                            muFmErrResult[tmpMuId].errCode.Add(errCount);
                                            muFmErrResult[tmpMuId].errDateTime.Add(tmpRuAFmInfo.datetime);
                                            muFmErrResult[tmpMuId].errContent.Add("Dc Output Fail 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region LD Alarm 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    errCount++;

                                    if (tmpRuAFmInfo.ldAlarm == 0)
                                    {
                                        if (!muFmErr[tmpMuId].flagErr[errCount])
                                        {
                                            muFmErr[tmpMuId].cntErr[errCount]++;
                                            muFmErr[tmpMuId].flagErr[errCount] = true;

                                            muFmErrResult[tmpMuId].errCode.Add(errCount);
                                            muFmErrResult[tmpMuId].errDateTime.Add(tmpRuAFmInfo.datetime);
                                            muFmErrResult[tmpMuId].errContent.Add("LD Alarm Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muFmErr[tmpMuId].flagErr[errCount])
                                        {
                                            muFmErr[tmpMuId].flagErr[errCount] = false;

                                            muFmErrResult[tmpMuId].errCode.Add(errCount);
                                            muFmErrResult[tmpMuId].errDateTime.Add(tmpRuAFmInfo.datetime);
                                            muFmErrResult[tmpMuId].errContent.Add("LD Alarm Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region PD Alarm 상태 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    errCount++;

                                    if (tmpRuAFmInfo.pdAlarm == 0)
                                    {
                                        if (!muFmErr[tmpMuId].flagErr[errCount])
                                        {
                                            muFmErr[tmpMuId].cntErr[errCount]++;
                                            muFmErr[tmpMuId].flagErr[errCount] = true;

                                            muFmErrResult[tmpMuId].errCode.Add(errCount);
                                            muFmErrResult[tmpMuId].errDateTime.Add(tmpRuAFmInfo.datetime);
                                            muFmErrResult[tmpMuId].errContent.Add("PD Alarm Error");
                                        }
                                    }
                                    else
                                    {
                                        if (muFmErr[tmpMuId].flagErr[errCount])
                                        {
                                            muFmErr[tmpMuId].flagErr[errCount] = false;

                                            muFmErrResult[tmpMuId].errCode.Add(errCount);
                                            muFmErrResult[tmpMuId].errDateTime.Add(tmpRuAFmInfo.datetime);
                                            muFmErrResult[tmpMuId].errContent.Add("PD Alarm Error 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion

                            SetListViewItemClear(lvsourcetelFMErrorStAllDiaplay);

                            for (i = 0; i < muFmErr.Length; i++)
                            {
                                string[] tmpData = new string[30];

                                tmpData[0] = (i + 1).ToString();
                                try
                                {
                                    tmpData[1] = (i + 1).ToString() + "(" + stationList[i] + ")";
                                }
                                catch
                                {
                                    tmpData[1] = (i + 1).ToString();
                                }

                                tmpData[2] = "0";
                                for (j = 0; j <= 5; j++)
                                    tmpData[j + 3] = muFmErr[i].cntErr[j].ToString();

                                ListViewItem tmpLV = new ListViewItem(tmpData);
                                SetListViewItemInster(lvsourcetelFMErrorStAllDiaplay, i, tmpLV);
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion
                            break;

                        case 4:     //FM 자장치 장애이력
                            #region FM 자장치 장애이력 검색 처리
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            //RU의 FM 장애이력 저장할 변수 초기화
                            for (i = 0; i < stationList.Count; i++)
                            {
                                for (j = 0; j < 4; j++)
                                {
                                    ruFmErrResult[i, j].errCode.Clear();
                                    ruFmErrResult[i, j].errDateTime.Clear();
                                    ruFmErrResult[i, j].errContent.Clear();

                                    for (int k = 0; k < 4; k++)
                                    {
                                        ruFmErr[i, j].cntErr[k] = 0;
                                        ruFmErr[i, j].flagErr[k] = false;
                                    }
                                }
                            }

                            #region FM 자장치의 장애 상태 읽어와 정리하기
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            //Database 검색
                            searchResultList = new ArrayList[tmpTimeSpan.Days + 1];      //날자수만큼 검색 결과를 저장할 변수

                            //날자별로 DataBase 파일에 접속하여 검색
                            for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                            {
                                searchResultList[i] = new ArrayList();

                                DateTime tmpDate = startDateTime.AddDays(i);

                                string tmpPath = clsCommon.DataBasePath + tmpDate.Year.ToString("0000") + @"\";
                                string dbFile = "NMS_" + tmpDate.Year.ToString("0000") + tmpDate.Month.ToString("00") + tmpDate.Day.ToString("00") + ".FDB";

                                if (System.IO.File.Exists(tmpPath + dbFile))
                                {
                                    if (searchDBMS != null)
                                    {
                                        searchDBMS.Dispose();
                                        searchDBMS = null;
                                    }

                                    searchDBMS = new nmsDBMS();
                                    searchDBMS.DBConnect(tmpPath + dbFile);

                                    searchResultList[i] = searchDBMS.RuFmErrorStFind(startDateTime, stopDateTime, false);                                    
                                }
                            }

                            for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                            {
                                for (j = 0; j < searchResultList[i].Count; j++)
                                {
                                    FM_Info tmpRuFmInfo = (FM_Info)searchResultList[i][j];

                                    int tmpMuId = tmpRuFmInfo.mu_id - 1;
                                    int tmpRuId = tmpRuFmInfo.ru_id - 1;

                                    #region AC Input Fail 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    errCount = 0;

                                    if (tmpRuFmInfo.acInputFail == 0)
                                    {
                                        if (!ruFmErr[tmpMuId, tmpRuId].flagErr[errCount])
                                        {
                                            ruFmErr[tmpMuId, tmpRuId].cntErr[errCount]++;
                                            ruFmErr[tmpMuId, tmpRuId].flagErr[errCount] = true;

                                            ruFmErrResult[tmpMuId, tmpRuId].errCode.Add(errCount);
                                            ruFmErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuFmInfo.datetime);
                                            ruFmErrResult[tmpMuId, tmpRuId].errContent.Add("AC Input Fail");
                                        }
                                    }
                                    else
                                    {
                                        if (ruFmErr[tmpMuId, tmpRuId].flagErr[errCount])
                                        {
                                            ruFmErr[tmpMuId, tmpRuId].flagErr[errCount] = false;

                                            ruFmErrResult[tmpMuId, tmpRuId].errCode.Add(errCount);
                                            ruFmErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuFmInfo.datetime);
                                            ruFmErrResult[tmpMuId, tmpRuId].errContent.Add("AC Input Fail 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region Dc Output Fail 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    errCount++;

                                    if (tmpRuFmInfo.dcOutputFail == 0)
                                    {
                                        if (!ruFmErr[tmpMuId, tmpRuId].flagErr[errCount])
                                        {
                                            ruFmErr[tmpMuId, tmpRuId].cntErr[errCount]++;
                                            ruFmErr[tmpMuId, tmpRuId].flagErr[errCount] = true;

                                            ruFmErrResult[tmpMuId, tmpRuId].errCode.Add(errCount);
                                            ruFmErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuFmInfo.datetime);
                                            ruFmErrResult[tmpMuId, tmpRuId].errContent.Add("Dc Output Fail");
                                        }
                                    }
                                    else
                                    {
                                        if (ruFmErr[tmpMuId, tmpRuId].flagErr[errCount])
                                        {
                                            ruFmErr[tmpMuId, tmpRuId].flagErr[errCount] = false;

                                            ruFmErrResult[tmpMuId, tmpRuId].errCode.Add(errCount);
                                            ruFmErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuFmInfo.datetime);
                                            ruFmErrResult[tmpMuId, tmpRuId].errContent.Add("Dc Output Fail 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region LD Alarm 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    errCount++;

                                    if (tmpRuFmInfo.ldAlarm == 0)
                                    {
                                        if (!ruFmErr[tmpMuId, tmpRuId].flagErr[errCount])
                                        {
                                            ruFmErr[tmpMuId, tmpRuId].cntErr[errCount]++;
                                            ruFmErr[tmpMuId, tmpRuId].flagErr[errCount] = true;

                                            ruFmErrResult[tmpMuId, tmpRuId].errCode.Add(errCount);
                                            ruFmErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuFmInfo.datetime);
                                            ruFmErrResult[tmpMuId, tmpRuId].errContent.Add("LD Alarm");
                                        }
                                    }
                                    else
                                    {
                                        if (ruFmErr[tmpMuId, tmpRuId].flagErr[errCount])
                                        {
                                            ruFmErr[tmpMuId, tmpRuId].flagErr[errCount] = false;

                                            ruFmErrResult[tmpMuId, tmpRuId].errCode.Add(errCount);
                                            ruFmErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuFmInfo.datetime);
                                            ruFmErrResult[tmpMuId, tmpRuId].errContent.Add("LD Alarm 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion

                                    #region PD Alarm 이력 저장
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    errCount++;

                                    if (tmpRuFmInfo.pdAlarm == 0)
                                    {
                                        if (!ruFmErr[tmpMuId, tmpRuId].flagErr[errCount])
                                        {
                                            ruFmErr[tmpMuId, tmpRuId].cntErr[errCount]++;
                                            ruFmErr[tmpMuId, tmpRuId].flagErr[errCount] = true;

                                            ruFmErrResult[tmpMuId, tmpRuId].errCode.Add(errCount);
                                            ruFmErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuFmInfo.datetime);
                                            ruFmErrResult[tmpMuId, tmpRuId].errContent.Add("PD Alarm");
                                        }
                                    }
                                    else
                                    {
                                        if (ruFmErr[tmpMuId, tmpRuId].flagErr[errCount])
                                        {
                                            ruFmErr[tmpMuId, tmpRuId].flagErr[errCount] = false;

                                            ruFmErrResult[tmpMuId, tmpRuId].errCode.Add(errCount);
                                            ruFmErrResult[tmpMuId, tmpRuId].errDateTime.Add(tmpRuFmInfo.datetime);
                                            ruFmErrResult[tmpMuId, tmpRuId].errContent.Add("PD Alarm 복구");
                                        }
                                    }
                                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                    #endregion
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion


                            SetListViewItemClear(lvsourcetelFMChildErrorStAllDiaplay);

                            for (i = 0; i < stationList.Count; i++)
                            {
                                for (j = 0; j < 4; j++)
                                {
                                    if (clsCommon.muruName[i].ruName[j].ruName == "") continue;

                                    string[] tmpData = new string[14];

                                    tmpData[0] = (cntIndex + 1).ToString();
                                    try
                                    {
                                        tmpData[1] = (i + 1).ToString() + "(" + stationList[i] + ")";
                                    }
                                    catch
                                    {
                                        tmpData[1] = (i + 1).ToString();
                                    }

                                    try
                                    {
                                        tmpData[2] = (j + 1).ToString() + "(" + clsCommon.muruName[i].ruName[j].ruName + ")";
                                    }
                                    catch
                                    {
                                        tmpData[2] = (j + 1).ToString();
                                    }

                                    for (int k = 0; k <= 4; k++)
                                        tmpData[k + 3] = ruFmErr[i, j].cntErr[k].ToString();

                                    ListViewItem tmpLV = new ListViewItem(tmpData);
                                    SetListViewItemInster(lvsourcetelFMChildErrorStAllDiaplay, cntIndex++, tmpLV);
                                }
                            }
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion
                            break;
                    }
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case 2:     //운용내역
                    #region 운용내역 검색 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    SetListViewItemClear(lvOperationReport);

                    string strSearchWord = tbSearchWord.Text;   //검색어

                    tmpResultList = fbDBMS_StatusListInfo.Find(startDateTime, stopDateTime, strSearchWord);

                    for (i = 0; i < tmpResultList.Count; i++)
                    {
                        statusListInfo tmpStatusList = (statusListInfo)tmpResultList[i];

                        string[] tmpData = new string[4];

                        tmpData[0] = (i + 1).ToString();
                        tmpData[1] = tmpStatusList.datetime.ToShortDateString();
                        tmpData[2] = tmpStatusList.datetime.ToLongTimeString();
                        tmpData[3] = tmpStatusList.content;

                        ListViewItem tmpLV = new ListViewItem(tmpData);
                        SetListViewItemInster(lvOperationReport, i, tmpLV);
                    }
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case 3:     //주장치 관련
                    if (!flagAllSearchVisible) return;

                    #region 주장치 관련 이력조회
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    {
                        string tmpPath = clsCommon.DataBasePath + startDateTime.Year.ToString("0000") + @"\";
                        string dbFile = "NMS_" + startDateTime.Year.ToString("0000") + startDateTime.Month.ToString("00") + startDateTime.Day.ToString("00") + ".FDB";

                        if (System.IO.File.Exists(tmpPath + dbFile))
                        {
                            if (searchDBMS != null)
                            {
                                searchDBMS.Dispose();
                                searchDBMS = null;
                            }

                            searchDBMS = new nmsDBMS();
                            searchDBMS.DBConnect(tmpPath + dbFile);
                        }

                        switch (tcCCESearch.SelectedIndex)
                        {
                            case 0:     //CCP
                                ds = searchDBMS.CcpAllFind();
                                dgvCcpStDisplay.DataSource = ds.Tables[0];
                                break;

                            case 1:     //Console I/F
                                ds = searchDBMS.ConsoleAllFind();
                                dgvConsoleStDisplay.DataSource = ds.Tables[0];
                                break;

                            case 2:     //Broad I/F
                                ds = searchDBMS.BroadAllFind();
                                dgvBroadStDisplay.DataSource = ds.Tables[0];
                                break;

                            case 3:     //Base I/F
                                ds = searchDBMS.BaseAllFind();
                                dgvBaseStDisplay.DataSource = ds.Tables[0];
                                break;
                        }
                    }
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case 4:     //NMS 관련
                    if (!flagAllSearchVisible) return;

                    #region NMS 관련 이력조회
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    {
                        string tmpPath = clsCommon.DataBasePath + startDateTime.Year.ToString("0000") + @"\";
                        string dbFile = "NMS_" + startDateTime.Year.ToString("0000") + startDateTime.Month.ToString("00") + startDateTime.Day.ToString("00") + ".FDB";

                        if (System.IO.File.Exists(tmpPath + dbFile))
                        {
                            if (searchDBMS != null)
                            {
                                searchDBMS.Dispose();
                                searchDBMS = null;
                            }

                            searchDBMS = new nmsDBMS();
                            searchDBMS.DBConnect(tmpPath + dbFile);
                        }

                        switch (tcNMSSearch.SelectedIndex)
                        {
                            case 0:     //MU
                                ds = searchDBMS.MuAllFind();
                                dgvMuStDisplay.DataSource = ds.Tables[0];
                                break;

                            case 1:     //UPS
                                ds = searchDBMS.UpsAllFind();
                                dgvUpsStDisplay.DataSource = ds.Tables[0];
                                break;

                            case 2:     //RU
                                ds = searchDBMS.RuAllFind();
                                dgvRuStDisplay.DataSource = ds.Tables[0];
                                break;

                            case 3:     //BDA
                                switch (clsCommon.nmsGUIUser)
                                {
                                    case "경춘선":
                                        ds = searchDBMS.BdaAllFind();
                                        dgvBDAStDisplay.DataSource = ds.Tables[0];
                                        break;

                                    case "중앙선":
                                        ds = searchDBMS.sourcetelBdaAllFind();
                                        dgvBDAStDisplay.DataSource = ds.Tables[0];
                                        break;
                                }
                                break;

                            case 4:     //FM 모장치
                                ds = searchDBMS.MuFmAllFind();
                                dgvFmStDisplay.DataSource = ds.Tables[0];
                                break;

                            case 5:     //FM 자장치
                                ds = searchDBMS.RuFmAllFind();
                                dgvFmChildStDisplay.DataSource = ds.Tables[0];
                                break;
                        }
                    }
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case 5:     //기타 검색
                    int cntOtherIndex = 0;

                    //Database 검색
                    searchResultList = new ArrayList[tmpTimeSpan.Days + 1];      //날자수만큼 검색 결과를 저장할 변수

                    //날자별로 DataBase 파일에 접속하여 검색
                    for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                    {
                        searchResultList[i] = new ArrayList();

                        DateTime tmpDate = startDateTime.AddDays(i);

                        string tmpPath = clsCommon.DataBasePath + tmpDate.Year.ToString("0000") + @"\";
                        string dbFile = "NMS_" + tmpDate.Year.ToString("0000") + tmpDate.Month.ToString("00") + tmpDate.Day.ToString("00") + ".FDB";

                        if (System.IO.File.Exists(tmpPath + dbFile))
                        {
                            if (searchDBMS != null)
                            {
                                searchDBMS.Dispose();
                                searchDBMS = null;
                            }

                            searchDBMS = new nmsDBMS();
                            searchDBMS.DBConnect(tmpPath + dbFile);

                            searchResultList[i] = searchDBMS.BdaFind(startDateTime, stopDateTime.AddDays(1), cbSearchStation.SelectedIndex, cbSearchRU.SelectedIndex - 1, cbSearchBDA.SelectedIndex - 1);
                        }
                    }

                    for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                    {
                        for (j = 0; j < searchResultList[i].Count; j++)
                        {
                            BdaInfo tmpStatusList = (BdaInfo)searchResultList[i][j];

                            string[] tmpData = new string[8];

                            tmpData[0] = (cntOtherIndex + 1).ToString();
                            tmpData[1] = tmpStatusList.datetime.ToShortDateString();
                            tmpData[2] = tmpStatusList.datetime.ToLongTimeString();
                            tmpData[3] = tmpStatusList.fmValue.ToString();
                            tmpData[4] = tmpStatusList.vhfValue.ToString();
                            tmpData[5] = tmpStatusList.dmbValue.ToString();
                            tmpData[6] = tmpStatusList.protectionValue.ToString();
                            tmpData[7] = tmpStatusList.trsValue.ToString();

                            ListViewItem tmpLV = new ListViewItem(tmpData);
                            SetListViewItemInster(lvOtherSearchBDAResult, cntOtherIndex++, tmpLV);
                        }
                    }
                    break;
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e)
        {
            #region NMS Data 삭제
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            switch (tcNMSSearch.SelectedIndex)
            {
                case 0:     //MU
                    fbDBMS_NMS.MuDelete();
                    break;

                case 1:     //UPS
                    fbDBMS_NMS.UpsDelete();
                    break;

                case 2:     //RU
                    fbDBMS_NMS.RuDelete();
                    break;

                case 3:     //BDA
                    fbDBMS_NMS.BdaDelete();
                    break;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
        }

        private void btCCEDataDelete_Click(object sender, EventArgs e)
        {
            #region 주장치 Data 삭제
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            switch (tcCCESearch.SelectedIndex)
            {
                case 0:     //CCP
                    fbDBMS_NMS.CCPDelete();
                    break;

                case 1:     //Console I/F
                    fbDBMS_NMS.ConsoleDelete();
                    break;

                case 2:     //Broad I/F
                    fbDBMS_NMS.BroadDelete();
                    break;

                case 3:     //Base I/F
                    fbDBMS_NMS.BaseDelete();
                    break;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
        }

        #region 통신/장애 이력 조회 화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void lvTxRxErxStAllDiaplay_DoubleClick(object sender, EventArgs e)
        {
            SetdataGridViewClear(dgvTxRxErxStDetailDiaplay);

            int index = lvTxRxErxStAllDiaplay.SelectedItems[0].Index;

            try
            {
                SetText(lblTxRxErxStDetailDiaplay, "통신 상세 내역( " + stationList[index] + " )");
            }
            catch
            {
                SetText(lblTxRxErxStDetailDiaplay, "통신 상세 내역()");
            }

            for (int i = 0; i < muTxRxErxResult[index].codeTxRxErx.Count; i++)
            {
                try
                {
                    SetdataGridViewMuTxRxErxStValue(dgvTxRxErxStDetailDiaplay, i, muTxRxErxResult[index].contentTxRxErx[i], muTxRxErxResult[index].chTxRxErx[i],
                        muTxRxErxResult[index].startTime[i].ToString("yyyy-MM-dd HH:mm:ss"), muTxRxErxResult[index].stopTime[i].ToString("yyyy-MM-dd HH:mm:ss"));
                }
                catch
                {
                }
            }
        }

        private void lvErrorStAllDiaplay_DoubleClick(object sender, EventArgs e)
        {
            SetdataGridViewClear(dgvErrorStDetailDiaplay);

            int index = lvMUErrorStAllDiaplay.SelectedItems[0].Index;

            try
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역( " + stationList[index] + "의 MU )");
            }
            catch
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역()");
            }

            for (int i = 0; i < muErrResult[index].errCode.Count; i++)
                SetdataGridViewMuErrorStValue(dgvErrorStDetailDiaplay, i, muErrResult[index].errDateTime[i].ToString("yyyy-MM-dd HH:mm:ss"), muErrResult[index].errContent[i]);

            dgvErrorStDetailDiaplay.Sort(dgvErrorStDetailDiaplay.Columns[1], ListSortDirection.Ascending);

            for (int i = 0; i < muErrResult[index].errCode.Count; i++)
                SetdataGridViewMuErrorStIndex(dgvErrorStDetailDiaplay, i, muErrResult[index].errDateTime[i].ToString(), muErrResult[index].errContent[i]);
        }

        private void lvRUErrorStAllDiaplay_DoubleClick(object sender, EventArgs e)
        {
            SetdataGridViewClear(dgvErrorStDetailDiaplay);

            string[] tmpStr = null;

            tmpStr = lvRUErrorStAllDiaplay.SelectedItems[0].SubItems[1].Text.Split(new char[] { '(' });
            int muID = Convert.ToByte(tmpStr[0]) - 1;

            tmpStr = lvRUErrorStAllDiaplay.SelectedItems[0].SubItems[2].Text.Split(new char[] { '(' });
            int ruID = Convert.ToByte(tmpStr[0]) - 1;

            try
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역( " + stationList[muID] + " - " + clsCommon.muruName[muID].ruName[ruID].ruName + " )");
            }
            catch
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역()");
            }

            for (int i = 0; i < ruErrResult[muID, ruID].errCode.Count; i++)
                SetdataGridViewMuErrorStValue(dgvErrorStDetailDiaplay, i, ruErrResult[muID, ruID].errDateTime[i].ToString("yyyy-MM-dd HH:mm:ss"), ruErrResult[muID, ruID].errContent[i]);

            dgvErrorStDetailDiaplay.Sort(dgvErrorStDetailDiaplay.Columns[1], ListSortDirection.Ascending);

            for (int i = 0; i < ruErrResult[muID, ruID].errCode.Count; i++)
                SetdataGridViewMuErrorStIndex(dgvErrorStDetailDiaplay, i, ruErrResult[muID, ruID].errDateTime[i].ToString(), ruErrResult[muID, ruID].errContent[i]);
        }

        private void lvBDAErrorStAllDiaplay_DoubleClick(object sender, EventArgs e)
        {
            SetdataGridViewClear(dgvErrorStDetailDiaplay);

            string[] tmpStr = null;

            tmpStr = lvBDAErrorStAllDiaplay.SelectedItems[0].SubItems[1].Text.Split(new char[] { '(' });
            int muID = Convert.ToByte(tmpStr[0]) - 1;

            tmpStr = lvBDAErrorStAllDiaplay.SelectedItems[0].SubItems[2].Text.Split(new char[] { '(' });
            int ruID = Convert.ToByte(tmpStr[0]) - 1;

            tmpStr = lvBDAErrorStAllDiaplay.SelectedItems[0].SubItems[3].Text.Split(new char[] { '(' });
            int bdaID = Convert.ToByte(tmpStr[0]) - 1;

            try
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역( " + stationList[muID] + " - " + clsCommon.muruName[muID].ruName[ruID].ruName + " - " + clsCommon.muruName[muID].ruName[ruID].bdaName[bdaID] + " )");
            }
            catch
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역()");
            }

            for (int i = 0; i < bdaErrResult[muID, ruID, bdaID].errCode.Count; i++)
                SetdataGridViewMuErrorStValue(dgvErrorStDetailDiaplay, i, bdaErrResult[muID, ruID, bdaID].errDateTime[i].ToString("yyyy-MM-dd HH:mm:ss"), bdaErrResult[muID, ruID, bdaID].errContent[i]);

            dgvErrorStDetailDiaplay.Sort(dgvErrorStDetailDiaplay.Columns[1], ListSortDirection.Ascending);

            for (int i = 0; i < bdaErrResult[muID, ruID, bdaID].errCode.Count; i++)
                SetdataGridViewMuErrorStIndex(dgvErrorStDetailDiaplay, i, bdaErrResult[muID, ruID, bdaID].errDateTime[i].ToString(), bdaErrResult[muID, ruID, bdaID].errContent[i]);
        }

        private void lvSourcetelBDAErrorStAllDiaplay_DoubleClick(object sender, EventArgs e)
        {
            SetdataGridViewClear(dgvErrorStDetailDiaplay);

            string[] tmpStr = null;

            tmpStr = lvsourcetelBDAErrorStAllDiaplay.SelectedItems[0].SubItems[1].Text.Split(new char[] { '(' });
            int muID = Convert.ToByte(tmpStr[0]) - 1;

            tmpStr = lvsourcetelBDAErrorStAllDiaplay.SelectedItems[0].SubItems[2].Text.Split(new char[] { '(' });
            int ruID = Convert.ToByte(tmpStr[0]) - 1;

            tmpStr = lvsourcetelBDAErrorStAllDiaplay.SelectedItems[0].SubItems[3].Text.Split(new char[] { '(' });
            int bdaID = Convert.ToByte(tmpStr[0]) - 1;

            try
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역( " + stationList[muID] + " - " + clsCommon.muruName[muID].ruName[ruID].ruName + " - " + clsCommon.muruName[muID].ruName[ruID].bdaName[bdaID] + " )");
            }
            catch
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역()");
            }

            for (int i = 0; i < bdaErrResult[muID, ruID, bdaID].errCode.Count; i++)
                SetdataGridViewMuErrorStValue(dgvErrorStDetailDiaplay, i, bdaErrResult[muID, ruID, bdaID].errDateTime[i].ToString("yyyy-MM-dd HH:mm:ss"), bdaErrResult[muID, ruID, bdaID].errContent[i]);

            dgvErrorStDetailDiaplay.Sort(dgvErrorStDetailDiaplay.Columns[1], ListSortDirection.Ascending);

            for (int i = 0; i < bdaErrResult[muID, ruID, bdaID].errCode.Count; i++)
                SetdataGridViewMuErrorStIndex(dgvErrorStDetailDiaplay, i, bdaErrResult[muID, ruID, bdaID].errDateTime[i].ToString(), bdaErrResult[muID, ruID, bdaID].errContent[i]);
        }

        private void lvSourcetelMuFMErrorStAllDiaplay_DoubleClick(object sender, EventArgs e)
        {

            SetdataGridViewClear(dgvErrorStDetailDiaplay);

            int index = lvsourcetelFMErrorStAllDiaplay.SelectedItems[0].Index;

            try
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역( " + stationList[index] + "의 FM 모장치 )");
            }
            catch
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역(FM 모장치)");
            }

            for (int i = 0; i < muFmErrResult[index].errCode.Count; i++)
                SetdataGridViewMuErrorStValue(dgvErrorStDetailDiaplay, i, muFmErrResult[index].errDateTime[i].ToString("yyyy-MM-dd HH:mm:ss"), muFmErrResult[index].errContent[i]);

            dgvErrorStDetailDiaplay.Sort(dgvErrorStDetailDiaplay.Columns[1], ListSortDirection.Ascending);

            for (int i = 0; i < muFmErrResult[index].errCode.Count; i++)
                SetdataGridViewMuErrorStIndex(dgvErrorStDetailDiaplay, i, muFmErrResult[index].errDateTime[i].ToString(), muFmErrResult[index].errContent[i]);
        }

        private void lvSourcetelRuFMErrorStAllDiaplay_DoubleClick(object sender, EventArgs e)
        {
            SetdataGridViewClear(dgvErrorStDetailDiaplay);

            string[] tmpStr = null;

            tmpStr = lvsourcetelFMChildErrorStAllDiaplay.SelectedItems[0].SubItems[1].Text.Split(new char[] { '(' });
            int muID = Convert.ToByte(tmpStr[0]) - 1;

            tmpStr = lvsourcetelFMChildErrorStAllDiaplay.SelectedItems[0].SubItems[2].Text.Split(new char[] { '(' });
            int ruID = Convert.ToByte(tmpStr[0]) - 1;

            try
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역( " + stationList[muID] + " - " + clsCommon.muruName[muID].ruName[ruID].ruName + "의 FM 자장치 )");
            }
            catch
            {
                SetText(lblErrorStDetailDiaplay, "장애 상세 내역( FM 자장치 )");
            }

            for (int i = 0; i < ruFmErrResult[muID, ruID].errCode.Count; i++)
                SetdataGridViewMuErrorStValue(dgvErrorStDetailDiaplay, i, ruFmErrResult[muID, ruID].errDateTime[i].ToString("yyyy-MM-dd HH:mm:ss"), ruFmErrResult[muID, ruID].errContent[i]);

            dgvErrorStDetailDiaplay.Sort(dgvErrorStDetailDiaplay.Columns[1], ListSortDirection.Ascending);

            for (int i = 0; i < ruFmErrResult[muID, ruID].errCode.Count; i++)
                SetdataGridViewMuErrorStIndex(dgvErrorStDetailDiaplay, i, ruFmErrResult[muID, ruID].errDateTime[i].ToString(), ruFmErrResult[muID, ruID].errContent[i]);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private void btExcelSave_Click(object sender, EventArgs e)
        {
            #region 검색내용 엑셀 파일로 저장
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ListView tmpListView = null;
            string tmpStr = string.Empty;

            switch (tcMainSearch.SelectedIndex)
            {
                case 0:     //통신이력 검색내용 엑셀 파일로 저장
                    tmpStr = "<< 통 신 내 역 >>";
                    tmpListView = lvTxRxErxStAllDiaplay;
                    break;

                case 1:     //장애이력
                    #region 장애이력 검색 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    switch (tcErrorSearch.SelectedIndex)
                    {
                        case 0:     //MU 장애이력 검색내용 엑셀 파일로 저장
                            tmpStr = "<< MU 장애 이력 >>";
                            tmpListView = lvMUErrorStAllDiaplay;
                            break;

                        case 1:      //RU 장애이력 검색내용 엑셀 파일로 저장
                            tmpStr = "<< RU 장애 이력 >>";
                            tmpListView = lvRUErrorStAllDiaplay;
                            break;

                        case 2:     //BDA 장애이력 검색내용 엑셀 파일로 저장
                            tmpStr = "<< BDA 장애 이력 >>";

                            switch (clsCommon.nmsGUIUser)
                            {
                                case "경춘선":
                                    tmpListView = lvBDAErrorStAllDiaplay;
                                    break;

                                case "중앙선":
                                    tmpListView = lvsourcetelBDAErrorStAllDiaplay;
                                    break;

                                default:
                                    break;
                            }
                            break;

                        case 3:     //MU의 FM 모장치 장애이력 검색내용 엑셀 파일로 저장
                            tmpStr = "<< FM 모장치 장애 이력 >>";
                            tmpListView = lvsourcetelFMErrorStAllDiaplay;
                            break;

                        case 4:     //RU의 FM 자장치 장애이력 검색내용 엑셀 파일로 저장
                            tmpStr = "<< FM 자장치 장애 이력 >>";
                            tmpListView = lvsourcetelFMChildErrorStAllDiaplay;
                            break;
                    }
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case 2:     //운용내역 검색내용 엑셀 파일로 저장
                    tmpStr = "<< 운 용 내 역 >>";
                    tmpListView = lvOperationReport;
                    break;

                case 3:     //주장치 관련
                    break;

                case 4:     //NMS 관련
                    break;

                case 5:     //기타 검색
                    tmpStr = "<< BDA Value 내역 >>";
                    tmpListView = lvOtherSearchBDAResult;
                    break;
            }

            #region 검색내용 엑셀 파일로 저장
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            if (tmpListView == null) return;

            int i = 0;
            int j = 0;

            string tmpFileName = null;

            FileStream fs = null;
            StreamWriter fw = null;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                tmpFileName = saveFileDialog.FileName;

                fs = new FileStream(tmpFileName, FileMode.Create);
                fw = new StreamWriter(fs, System.Text.Encoding.Default);

                fw.BaseStream.Seek(0, SeekOrigin.End);

                try
                {
                    fw.WriteLine(tmpStr);

                    tmpStr = "검색날자 : " + dTPStart.Value.ToString("yyyy-MM-dd") + "부터 " + dTPStop.Value.ToString("yyyy-MM-dd") + "까지";
                    fw.WriteLine(tmpStr);

                    fw.WriteLine("");

                    tmpStr = "";
                    for (i = 0; i < tmpListView.Columns.Count; i++)
                        tmpStr += tmpListView.Columns[i].Text + ",";

                    fw.WriteLine(tmpStr);

                    for (i = 0; i < tmpListView.Items.Count; i++)
                    {
                        ListViewItem tmpListViewItem = tmpListView.Items[i];

                        tmpStr = "";
                        for (j = 0; j < tmpListView.Columns.Count; j++)
                            tmpStr += tmpListViewItem.SubItems[j].Text + ",";

                        fw.WriteLine(tmpStr);
                    }
                }
                catch
                {
                }

                fw.Flush();

                fw.Close();
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
        }

        private void btDetailExcelSave_Click(object sender, EventArgs e)
        {
            #region 상세 검색내용 엑셀 파일로 저장
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DataGridView tmpDGV = null;
            string tmpStr = string.Empty;

            switch (tcMainSearch.SelectedIndex)
            {
                case 0:     //통신이력
                    tmpStr = lblTxRxErxStDetailDiaplay.Text;
                    tmpDGV = dgvTxRxErxStDetailDiaplay;
                    break;

                case 1:     //장애이력
                    tmpStr = lblErrorStDetailDiaplay.Text;
                    tmpDGV = dgvErrorStDetailDiaplay;
                    break;

                case 2:     //운용내역
                    break;

                case 3:     //주장치 관련
                    break;

                case 4:     //NMS 관련
                    break;

                case 5:     //기타 검색
                    break;
            }

            #region 엑셀 파일로 저장
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            if (tmpDGV == null) return;

            int i = 0;
            int j = 0;

            string tmpFileName = null;

            FileStream fs = null;
            StreamWriter fw = null;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                tmpFileName = saveFileDialog.FileName;

                fs = new FileStream(tmpFileName, FileMode.Create);
                fw = new StreamWriter(fs, System.Text.Encoding.Default);

                fw.BaseStream.Seek(0, SeekOrigin.End);

                try
                {
                    fw.WriteLine(tmpStr);

                    tmpStr = "검색날자 : " + dTPStart.Value.ToString("yyyy-MM-dd") + "부터 " + dTPStop.Value.ToString("yyyy-MM-dd") + "까지";
                    fw.WriteLine(tmpStr);

                    fw.WriteLine("");

                    tmpStr = "";
                    for (i = 0; i < tmpDGV.ColumnCount; i++)
                        tmpStr += tmpDGV.Columns[i].HeaderText + ",";

                    fw.WriteLine(tmpStr);

                    for (i = 0; i < tmpDGV.RowCount; i++)
                    {
                        tmpStr = "";
                        for (j = 0; j < tmpDGV.ColumnCount; j++)
                            tmpStr += tmpDGV.Rows[i].Cells[j].Value.ToString()  + ",";

                        fw.WriteLine(tmpStr);
                    }
                }
                catch
                {
                }

                fw.Flush();

                fw.Close();
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
        }

        #region 기타 검색 화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void tcOtherSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcOtherSearch.SelectedIndex)
            {
                case 0:     //MU
                case 1:     //UPS
                    SetEnable(gbSearchStation, true);
                    SetEnable(gbSearchRU, false);
                    SetEnable(gbSearchBDA, false);
                    break;

                case 2:     //RU
                    SetEnable(gbSearchStation, true);
                    SetEnable(gbSearchRU, true);
                    SetEnable(gbSearchBDA, false);
                    break;

                case 3:     //BDA
                    SetEnable(gbSearchStation, true);
                    SetEnable(gbSearchRU, true);
                    SetEnable(gbSearchBDA, true);
                    break;
            }
        }

        private void cbSearchStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;

            cbSearchRU.Items.Clear();
            cbSearchRU.Items.Add("선택 안함");

            for (i = 0; i < 4; i++)
                cbSearchRU.Items.Add(clsCommon.muruName[cbSearchStation.SelectedIndex].ruName[i].ruName);

            cbSearchRU.SelectedIndex = 0;
        }

        private void cbSearchRU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;

            cbSearchBDA.Items.Clear();
            cbSearchBDA.Items.Add("선택 안함");

            if (cbSearchRU.SelectedIndex != 0)
            {
                for (i = 0; i < 4; i++)
                    cbSearchBDA.Items.Add(clsCommon.muruName[cbSearchStation.SelectedIndex].ruName[cbSearchRU.SelectedIndex - 1].bdaName[i]);
            }

            cbSearchBDA.SelectedIndex = 0;
        }

        private void cbSearchBDA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 고장내역으로 장애검색하는 화면
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void btSearchChange_Click(object sender, EventArgs e)
        {
            if (ucErrorSearch.Visible) SetVisible(ucErrorSearch, false);
            else SetVisible(ucErrorSearch, true);
        }

        private void ucErrorSearch_searchClick(int muID, int ruID, int bdaID, int kind, int errKind, string searchWord, DateTime startDateTime, DateTime stopDateTime)
        {
            int i = 0, j = 0;

            ArrayList tmpResultList = new ArrayList();  //검색결과를 저장할 배열

            if (kind == 4)
            {   //운용내역 검색
                ucErrorSearch.ListViewClear();

                string strSearchWord = searchWord;   //검색어

                tmpResultList = fbDBMS_StatusListInfo.Find(startDateTime, stopDateTime, strSearchWord);

                for (i = 0; i < tmpResultList.Count; i++)
                {
                    statusListInfo tmpStatusList = (statusListInfo)tmpResultList[i];

                    string[] tmpData = new string[4];

                    tmpData[0] = (i + 1).ToString();
                    tmpData[1] = tmpStatusList.datetime.ToShortDateString();
                    tmpData[2] = tmpStatusList.datetime.ToLongTimeString();
                    tmpData[3] = tmpStatusList.content;

                    ListViewItem tmpLV = new ListViewItem(tmpData);
                    ucErrorSearch.ListViewInsert(i, tmpLV);
                }
            }
            else
            {   //장애내역 검색
                DataSet ds = new DataSet();

                TimeSpan tmpTimeSpan = stopDateTime - startDateTime;

                //장비별 장애이력 저장할 변수 초기화
                for (i = 0; i < muErr.Length; i++)
                {
                    muErrResult[i].errCode.Clear();
                    muErrResult[i].errDateTime.Clear();
                    muErrResult[i].errContent.Clear();

                    for (j = 0; j < 28; j++)
                    {
                        muErr[i].cntErr[j] = 0;
                        muErr[i].flagErr[j] = false;
                    }
                }

                DataSet[] searchResultDS = new DataSet[tmpTimeSpan.Days + 1];   //날자수 만큼 검색 결과를 저장할 변수

                //날자별로 DataBase 파일에 접속하여 검색
                for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                {
                    searchResultDS[i] = new DataSet();

                    DateTime tmpDate = startDateTime.AddDays(i);

                    string tmpPath = clsCommon.DataBasePath + tmpDate.Year.ToString("0000") + @"\";
                    string dbFile = "NMS_" + tmpDate.Year.ToString("0000") + tmpDate.Month.ToString("00") + tmpDate.Day.ToString("00") + ".FDB";

                    if (System.IO.File.Exists(tmpPath + dbFile))
                    {
                        if (searchDBMS != null)
                        {
                            searchDBMS.Dispose();
                            searchDBMS = null;
                        }

                        searchDBMS = new nmsDBMS();
                        searchDBMS.DBConnect(tmpPath + dbFile);

                        switch (kind)
                        {
                            case 0:     //MU 장애내역
                                switch (errKind)
                                {
                                    case 22:
                                    case 23:
                                    case 24:
                                    case 25:
                                        searchResultDS[i] = searchDBMS.UPSIndividualErrorFind(startDateTime, stopDateTime, clsCommon.errContent[kind].errName[errKind], muID);
                                        break;

                                    default:
                                        searchResultDS[i] = searchDBMS.MuIndividualErrorFind(startDateTime, stopDateTime, clsCommon.errContent[kind].errName[errKind], muID);
                                        break;
                                }
                                break;

                            case 1:     //RU 장애내역
                                searchResultDS[i] = searchDBMS.RuIndividualErrorFind(startDateTime, stopDateTime, clsCommon.errContent[kind].errName[errKind], muID, ruID);
                                break;

                            case 2:     //BDA 장애내역
                                switch (clsCommon.nmsGUIUser)
                                {
                                    case "경춘선":
                                        searchResultDS[i] = searchDBMS.BDAIndividualErrorFind(startDateTime, stopDateTime, clsCommon.errContent[kind].errName[errKind], muID, ruID, bdaID);
                                        break;

                                    case "중앙선":
                                        searchResultDS[i] = searchDBMS.SourcetelBDAIndividualErrorFind(startDateTime, stopDateTime, clsCommon.errContent[kind].errName[errKind], muID, ruID, bdaID);
                                        break;

                                    default:                                        
                                        break;
                                }
                                break;

                            case 3:     //FM 장애내역
                                bool flagRuA = false;
                                if (ruID == 0) flagRuA = true;
                                    
                                searchResultDS[i] = searchDBMS.FMIndividualErrorFind(startDateTime, stopDateTime, clsCommon.errContent[kind].errName[errKind], muID, ruID, flagRuA);
                                break;
                        }
                    }
                }

                for (i = 0; i < tmpTimeSpan.Days + 1; i++)
                {
                    if (searchResultDS[i].Tables.Count == 0) continue;

                    for (j = 0; j < searchResultDS[i].Tables[0].Rows.Count; j++)
                    {
                        int tmpIndex = 0;

                        switch (kind)
                        {
                            case 0: tmpIndex = 2; break;    //MU 장애내역
                            case 1: tmpIndex = 3; break;    //RU 장애내역
                            case 2: tmpIndex = 4; break;    //BDA 장애내역
                            case 3: tmpIndex = 3; break;    //FM 장애내역
                        }

                        object tmpOB = searchResultDS[i].Tables[0].Rows[j][tmpIndex];

                        if ((string)(tmpOB) == "1")
                        {
                            if (!muErr[0].flagErr[0])
                            {
                                muErr[0].cntErr[0]++;
                                muErr[0].flagErr[0] = true;

                                muErrResult[0].errCode.Add(0);
                                muErrResult[0].errDateTime.Add((DateTime)(searchResultDS[i].Tables[0].Rows[i][0]));
                                muErrResult[0].errContent.Add(clsCommon.errContent[kind].errContent[errKind] + " 장애");
                            }
                        }
                        else
                        {
                            if (muErr[0].flagErr[0])
                            {
                                muErr[0].flagErr[0] = false;

                                muErrResult[0].errCode.Add(0);
                                muErrResult[0].errDateTime.Add((DateTime)(searchResultDS[i].Tables[0].Rows[i][0]));
                                muErrResult[0].errContent.Add(clsCommon.errContent[kind].errContent[errKind] + " 장애 복구");
                            }
                        }
                    }
                }

                ucErrorSearch.ListViewClear();

                for (i = 0; i < muErrResult[0].errCode.Count; i++)
                {
                    SetdataGridViewMuErrorStValue(dgvErrorStDetailDiaplay, i, muErrResult[0].errDateTime[i].ToString("yyyy-MM-dd HH:mm:ss"), muErrResult[0].errContent[i]);

                    string[] tmpData = new string[4];

                    tmpData[0] = (i + 1).ToString();
                    tmpData[1] = muErrResult[0].errDateTime[i].ToString("yyyy-MM-dd");
                    tmpData[2] = muErrResult[0].errDateTime[i].ToString("HH:mm:ss");
                    tmpData[3] = muErrResult[0].errContent[i];

                    ListViewItem tmpLV = new ListViewItem(tmpData);

                    ucErrorSearch.ListViewInsert(i, tmpLV);
                }
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 회선 시험 화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void btLineTestMode_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag);
            btLineTestMode_Click(index);
        }

        private void btLineTestMode_Click(int index)
        {
            //시험중이므로 모드변경 금지
            if (lineTestMode != 0) return;

            int i = 0;

            for (i = 0; i < 3; i++)
                SetColor(btLineTestMode[i], colorBase);

            SetColor(btLineTestMode[index], colorSelect);

            lineTestReserveMode = (byte)(index + 1);    //선택 Mode
        }

        private void btLineTest_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag);

            if (rbLineTestCCE1.Checked) lineTestCceID = 0;
            else lineTestCceID = 1;

            lineTestMuID = (byte)(cbLineTestStationList.SelectedIndex + 1);

            string tmpStr = cbLineTestStationList.Text + " - ";

            //선택 모드에 따라 동작
            switch (lineTestReserveMode)
            {
                case 1:     //송신
                    if (index != 0) return;

                    tmpStr += "송신회선시험을 ";
                    break;

                case 2:     //수신
                case 3:     //감청
                    if (index == 0) return;

                    if (lineTestReserveMode == 2) tmpStr += "수신회선시험을 ";
                    else tmpStr += "감청회선시험을 ";


                    break;
            }

            lineTestMode = lineTestReserveMode;

            if (clsCommon.flagLineTest)
            {   //회선 시험 중지
                clsCommon.flagLineTest = false;
                SetColor(btLineTest[index], colorBase);

                SetVisible(pbLineTestTone[lineTestReserveMode - 1], false);

                lineTestMode = 0;   //중지 모드

                tmpStr += "중지하였습니다.";
            }
            else
            {   //회선 시험 시작
                clsCommon.flagLineTest = true;
                SetColor(btLineTest[index], colorSelect);

                SetVisible(pbLineTestTone[lineTestReserveMode - 1], true);

                tmpStr += "시작하였습니다.";
            }

            SetText(lblLineTestValue1, "");
            SetText(lblLineTestValue2, "");

            //1. NMS주장치에 Data 송신
            nmsMainMachine.EditData_CTL_LineTest(lineTestMuID, 0, clsCommon.HexaConvert(lineTestMode));
            //2. CCE Test Panel에 Data 송신
            cceTestPanel[lineTestCceID].EditData_LineTest(clsCommon.HexaConvert(lineTestMode), (byte)(lineTestMuID - 1));

            if (lineTestMode != 0) lineTestingUnit = lineTestMuID;
            else lineTestingUnit = 0;

            cceTestPanel[0].EditData_MU_ChPttSt(muChPtt, lineTestingUnit);
            cceTestPanel[1].EditData_MU_ChPttSt(muChPtt, lineTestingUnit);

            AddStatus(tmpStr);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private void SetMuRuNameApply()
        {
            for (int i = 0; i < 4; i++)
            {
                ruSt1[i].SetStationName(clsCommon.muruName[clsCommon.presentMUID - 1].ruName[i].ruName);
                ruSt2[i].SetStationName(clsCommon.muruName[clsCommon.presentMUID - 1].ruName[i].ruName);
            }
        }

        private void SetRcNameApply()
        {   //CCE/RC 이름 적용
            for (int i = 1; i < 4; i++)
            {
                if (clsCommon.muruName[clsCommon.presentMUID - 1].rcName[i] == "")
                    clsCommon.muruName[clsCommon.presentMUID - 1].rcName[i] = "RC " + i.ToString();

                SetText(gbAfGainRc[i], clsCommon.muruName[clsCommon.presentMUID - 1].rcName[i]);
            }

            MUSt.RCNameSet(clsCommon.muruName[clsCommon.presentMUID - 1].rcName);
        }

        #region 설정화면 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void btTimeSet_Click(object sender, EventArgs e)
        {
            cceTestPanel[0].EditData_TimeSet();
            cceTestPanel[1].EditData_TimeSet();

            AddStatus("시간을 동기화 합니다.");
        }

        #region MU/RU 이름 설정 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private int lbMuRuNameSelectedIndex = 0;

        private void tbMuRuName_TextChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((TextBox)sender).Tag);

            if (index == 0)  //MU Name
                clsCommon.muruName[lbMuRuNameSelectedIndex].muName = ((TextBox)sender).Text;
            else            //RU Name(1~4)
                clsCommon.muruName[lbMuRuNameSelectedIndex].ruName[index - 1].ruName = ((TextBox)sender).Text;
        }

        private void chkMUFm_CheckedChanged(object sender, EventArgs e)
        {
            clsCommon.muruFmExist[lbMuRuNameSelectedIndex].flagMu = chkMUFm.Checked;
        }

        private void chkRUFm_CheckedChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((CheckBox)sender).Tag);

            clsCommon.muruFmExist[lbMuRuNameSelectedIndex].flagRu[index] = chkRuFm[index].Checked;
        }

        private void tbMuRcName_TextChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((TextBox)sender).Tag);
            clsCommon.muruName[lbMuRuNameSelectedIndex].rcName[index] = ((TextBox)sender).Text;
        }

        private void lbMuRuName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;

            lbMuRuNameSelectedIndex = lbMuRuName.SelectedIndex;

            SetText(tbMuName, clsCommon.muruName[lbMuRuNameSelectedIndex].muName);

            for (i = 0; i < 4; i++)
            {
                SetText(tbRuName[i], clsCommon.muruName[lbMuRuNameSelectedIndex].ruName[i].ruName);
                SetText(tbRcName[i], clsCommon.muruName[lbMuRuNameSelectedIndex].rcName[i]);
            }

            try
            {
                SetChecked(chkMUFm, clsCommon.muruFmExist[lbMuRuNameSelectedIndex].flagMu);

                for (i = 0; i < 4; i++)
                    SetChecked(chkRuFm[i], clsCommon.muruFmExist[lbMuRuNameSelectedIndex].flagRu[i]);
            }
            catch
            {
            }
        }

        private void btMuRuNameSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("RU이름 및 역사이름을 저장하시겠습니까?",
                "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            int i = 0;
            int j = 0;

            StreamWriter fw = File.CreateText(clsCommon.DefaultPath + clsCommon.nmsGUIUser + "_MuRuName.txt");

            try
            {
                fw.WriteLine(thisVer);      //버젼 저장

                for (i = 0; i < muruNowData.Length; i++)
                {
                    fw.WriteLine(clsCommon.muruName[i].muName);

                    for (j = 0; j < 4; j++) fw.WriteLine(clsCommon.muruName[i].ruName[j].ruName);
                    for (j = 0; j < 4; j++) fw.WriteLine(clsCommon.muruName[i].rcName[j]);
                }

                //FM 장치가 있는지의 여부
                for (i = 0; i < muruNowData.Length; i++)
                {
                    fw.WriteLine(clsCommon.muruFmExist[i].flagMu);


                    for (j = 0; j < 4; j++)
                        fw.WriteLine(clsCommon.muruFmExist[i].flagRu[j]);
                }

                AddStatus("MU/RU 이름을 저장하였습니다.");
            }
            catch
            {
                AddStatus("MU/RU 이름을 저장하는데 문제가 발생하였습니다. 확인후 다시 시도하시기 바랍니다.");
            }

            fw.Close();
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA 이름 설정 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private int bdaNameSetMuSelectedIndex = 0;
        private int bdaNameSetRuSelectedIndex = 0;

        //BDA 이름 설정 관련
        private void cbSetupBDANameMU_SelectedIndexChanged(object sender, EventArgs e)
        {
            bdaNameSetMuSelectedIndex = cbSetupBDANameMU.SelectedIndex;

            cbSetupBDANameRU.Items.Clear();
            cbSetupBDANameRU.Items.Add("선택 안함");
            cbSetupBDANameRU.SelectedIndex = 0;

            if (bdaNameSetMuSelectedIndex < 1) return;

            for (int i = 0; i < 4; i++)
                cbSetupBDANameRU.Items.Add(clsCommon.muruName[bdaNameSetMuSelectedIndex - 1].ruName[i].ruName);
        }

        private void cbSetupBDANameRU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;

            bdaNameSetRuSelectedIndex = cbSetupBDANameRU.SelectedIndex;

            if (bdaNameSetRuSelectedIndex < 1)
            {
                for (i = 0; i < 4; i++)
                    SetText(tbBdaName[i], "");

                return;
            }

            for (i = 0; i < 4; i++)
                SetText(tbBdaName[i], clsCommon.muruName[bdaNameSetMuSelectedIndex - 1].ruName[bdaNameSetRuSelectedIndex - 1].bdaName[i]);
        }

        private void tbBDAName_TextChanged(object sender, EventArgs e)
        {
            if (bdaNameSetRuSelectedIndex < 1) return;

            int index = Convert.ToInt32(((TextBox)sender).Tag);
            clsCommon.muruName[bdaNameSetMuSelectedIndex - 1].ruName[bdaNameSetRuSelectedIndex - 1].bdaName[index] = ((TextBox)sender).Text;
        }

        private void btBdaNameSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BDA이름을 저장하시겠습니까?",
                "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            StreamWriter fw = File.CreateText(clsCommon.DefaultPath + clsCommon.nmsGUIUser + "_BdaName.txt");

            try
            {
                fw.WriteLine(thisVer);      //버젼 저장

                for (int i = 0; i < muruNowData.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 4; k++)
                            fw.WriteLine(clsCommon.muruName[i].ruName[j].bdaName[k]);
                    }
                }

                AddStatus("BDA 이름을 저장하였습니다.");
            }
            catch
            {
                AddStatus("BDA 이름을 저장하는데 문제가 발생하였습니다. 확인후 다시 시도하시기 바랍니다.");
            }

            fw.Close();
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 기타 설정 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void btOpenDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                SetText(tbBellFile, openFileDialog.FileName);
        }

        private void cbBellPlay_CheckedChanged(object sender, EventArgs e)
        {
            flagSound = cbBellPlay.Checked;

            if (flagSound) SetColor(btMenu8, colorBase);        //경보
            else SetColor(btMenu8, colorSelect);                //경보해제
        }

        private void btBellPlay_Click(object sender, EventArgs e)
        {
            BellSoundPlay(tbBellFile.Text);
        }

        private void btSetupSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("이 설정을 저장(변경)하면 시스템에 심각한 장애가 발생할수 있습니다. 그래도 설정값을 변경 하시겠습니까?",
                "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            try
            {
                clsCommon.nmsGUIUser = cbUser.Text;   //사용처                 

                //NMS 정보
                nmsIP = tbNMSIP.Text;
                nmsPort = Convert.ToInt16(tbNMSPort.Text);

                //경보 관련 정보
                flagSound = cbBellPlay.Checked;     //경보음 재생 유무
                bellPlayCycle = Convert.ToInt32(tbBellPlayCycle.Text);  //경보음 재생 주기
                bellFile = tbBellFile.Text;    //경보음 파일

                //CCE Test Panel 정보
                for (int i = 0; i < 2; i++)
                {
                    cceIP[i] = tbCCEIP[i].Text;
                    ccePort[i] = Convert.ToInt32(tbCCEPort[i].Text);
                }

                bdaInitCycle = Convert.ToInt32(tbBDAInitCycle.Text);    //BDA 초기화 주기
            }
            catch
            {
            }

            StreamWriter fw = File.CreateText(clsCommon.DefaultPath + "setup.txt");

            try
            {
                fw.WriteLine(thisVer);      //버젼 저장

                fw.WriteLine(clsCommon.nmsGUIUser);   //사용처

                //NMS 정보
                fw.WriteLine(nmsIP);                //카메라 IP
                fw.WriteLine(nmsPort.ToString());   //카메라 Port

                //경보 관련 정보
                fw.WriteLine(flagSound);                    //경보음 재생 유무
                fw.WriteLine(bellPlayCycle.ToString());     //경보음 재생 주기
                fw.WriteLine(bellFile);                     //경보음 파일

                //CCE Test Panel 정보
                for (int i = 0; i < 2; i++)
                {
                    fw.WriteLine(cceIP[i]);
                    fw.WriteLine(ccePort[i].ToString());
                }

                fw.WriteLine(bdaInitCycle.ToString());     //BDA 초기화 주기

                AddStatus("기타 설정을 저장하였습니다.");
            }
            catch
            {
                AddStatus("기타 설정을 저장하는데 문제가 발생하였습니다. 확인후 다시 시도하시기 바랍니다.");
            }

            fw.Close();

            SetApply();     //저장된 정보 적용

            MessageBox.Show("설정이 변경되었습니다. 프로그램을 다시 실행해 주시기 바랍니다.", "경고", MessageBoxButtons.OK);
        }

        #region 설정 정보 적용
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void SetInput()
        {
            SetText(cbUser, clsCommon.nmsGUIUser);    //사용처

            //NMS 주장치 정보
            SetText(tbNMSIP, nmsIP);
            SetText(tbNMSPort, nmsPort.ToString());

            SetChecked(cbBellPlay, flagSound);                  //경보 재생 유무
            SetText(tbBellPlayCycle, bellPlayCycle.ToString()); //경보재생주기
            SetText(tbBellFile, bellFile);                      //경보음 파일

            //CCE Test Panel 정보
            for (int i = 0; i < 2; i++)
            {
                SetText(tbCCEIP[i], cceIP[i]);
                SetText(tbCCEPort[i], ccePort[i].ToString());
            }

            SetText(tbBDAInitCycle, bdaInitCycle.ToString());   //BDA 초기화 주기

            if (flagSound) SetColor(btMenu8, colorBase);    //경보
            else SetColor(btMenu8, colorSelect);            //경보해제

            SetApply();
        }

        private void SetApply()
        {
            //NMS 주장치에 접속
            nmsMainMachine.SetNetwordInfomation(nmsIP, nmsPort);    //IP, Port번호 설정

            tmrBell.Stop();
            tmrBell.Interval = bellPlayCycle;
            tmrBell.Start();
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region A/S용 설정 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void panel_ASSet_DoubleClick(object sender, EventArgs e)
        {
            bool flagAction = !gbRUBDASet.Visible;
            
            SetVisible(gbRUSelect, flagAction);
            SetVisible(gbBDASelect, flagAction);

            SetVisible(gbRUBDASet, flagAction);
            SetVisible(gbRUBDAFreqSet, flagAction);
            SetVisible(gbRUBDARfSet, flagAction);
        }

        private void cbSetupMU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmpMuID = cbSetupMU.SelectedIndex;
            
            cbSetupRU.Items.Clear();
            cbSetupRU.Items.Add("선택 안함");
            cbSetupRU.SelectedIndex = 0;

            if (tmpMuID < 1) return;

            for (int i = 0; i < 4; i++)
                cbSetupRU.Items.Add(clsCommon.muruName[tmpMuID - 1].ruName[i].ruName);

            cbSetupBDA.Items.Clear();
            cbSetupBDA.Items.Add("선택 안함");
            cbSetupBDA.SelectedIndex = 0;
        }

        private void cbSetupRU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmpRuID = cbSetupRU.SelectedIndex;

            cbSetupBDA.Items.Clear();
            cbSetupBDA.Items.Add("선택 안함");
            cbSetupBDA.SelectedIndex = 0;

            if (tmpRuID < 1) return;

            for (int i = 0; i < 4; i++)
                cbSetupBDA.Items.Add(clsCommon.muruName[cbSetupMU.SelectedIndex - 1].ruName[tmpRuID - 1].bdaName[i]);
        }

        private void btAfGainInquiry_Click(object sender, EventArgs e)
        {
            if (btAfGainInquiry.BackColor != colorBase)
            {
                SetColor(btAfGainInquiry, colorBase);
                return;
            }

            if (cbSetupMU.SelectedIndex < 1)
            {
                MessageBox.Show("AF Gain값을 조회할 MU(역사)를 선택해주시기 바랍니다.");
                return;
            }

            byte tmpMuID = (byte)cbSetupMU.SelectedIndex;

            SetColor(btAfGainInquiry, Color.Yellow);
            nmsMainMachine.EditData_AfGainInquiry(tmpMuID);

            string tmpStr = stationList[tmpMuID - 1] + "의 MU";

            AddStatus(tmpStr + " : AFGain값을 요청하였습니다.");
        }

        private void btAfGainSet_Click(object sender, EventArgs e)
        {   //AF Gain값 설정
            if (cbSetupMU.SelectedIndex < 1)
            {
                MessageBox.Show("AF Gain값을 설정할 MU(역사)를 선택해주시기 바랍니다.");
                return;
            }

            if (MessageBox.Show("AFGain 값을 설정하시겠습니까?",
                "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            int index = Convert.ToInt32(((Button)sender).Tag);
            byte muIndex = (byte)cbSetupMU.SelectedIndex;
            
            List<TextBox> tmpAfGain = new List<TextBox>();
            switch (index)
            {
                case 0: tmpAfGain = tbCCEAfGain; break;
                case 1: tmpAfGain = tbRC1AfGain; break;
                case 2: tmpAfGain = tbRC2AfGain; break;
                case 3: tmpAfGain = tbRC3AfGain; break;
            }

            int[] afGainValue = new int[3];

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    afGainValue[i] = Convert.ToInt32(tmpAfGain[i].Text);
                }
                catch
                {
                    afGainValue[i] = 0;
                }
            }

            nmsMainMachine.EditData_CTL_AFValueSet(muIndex, 0, (byte)index, afGainValue);

            string tmpStr = stationList[muIndex - 1] + "의 MU";

            tmpStr += " : " + clsCommon.muruName[muIndex - 1].rcName[index];

            tmpStr += "의 Gain 값을 (";

            tmpStr += "TX : " + afGainValue[0].ToString() + ", ";
            tmpStr += "RX : " + afGainValue[1].ToString() + ", ";
            tmpStr += "Mon : " + afGainValue[2].ToString();

            AddStatus(tmpStr + " ) 설정하였습니다.");
        }

        private void btBDAInitInquiry_Click(object sender, EventArgs e)
        {
            if (btBDAInitInquiry.BackColor != colorBase)
            {
                SetColor(btBDAInitInquiry, colorBase);
                return;
            }

            int tmpMuID = cbSetupMU.SelectedIndex;
            int tmpRuID = cbSetupRU.SelectedIndex;

            if (tmpMuID < 1 || tmpRuID < 1)
            {
                MessageBox.Show("BDA 설정 초기값을 조회할 MU/RU를 선택해주시기 바랍니다.");
                return;
            }

            string tmpStr = stationList[tmpMuID - 1] + "의 RU(" + clsCommon.muruName[tmpMuID - 1].ruName[tmpRuID - 1].ruName + ") : BDA 설정 초기값을 조회하였습니다";

            SetColor(btBDAInitInquiry, Color.Yellow);
            nmsMainMachine.EditData_BDA_InitInquiry((byte)tmpMuID, (byte)tmpRuID);  //BDA 초기 설정값 요청

            AddStatus(tmpStr);
        }

        private void btBDAInitSet_Click(object sender, EventArgs e)
        {
            int tmpMuID = cbSetupMU.SelectedIndex;
            int tmpRuID = cbSetupRU.SelectedIndex;

            if (tmpMuID < 1 || tmpRuID < 1)
            {
                MessageBox.Show("BDA 설정 초기값을 조회할 MU/RU를 선택해주시기 바랍니다.");
                return;
            }

            if (MessageBox.Show("BDA 설정 초기값을 설정하시겠습니까?",
                "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            string tmpStr = stationList[tmpMuID - 1] + "의 RU(" + clsCommon.muruName[tmpMuID - 1].ruName[tmpRuID - 1].ruName + ") : BDA 설정 초기값을 설정하였습니다";

            BDAInitSet((byte)tmpMuID, (byte)tmpRuID);

            AddStatus(tmpStr);
        }

        private void btBdaRfInquiry_Click(object sender, EventArgs e)
        {   //BDA RF 설정값 조회
            if (btBdaRfInquiry.BackColor != colorBase)
            {
                SetColor(btBdaRfInquiry, colorBase);
                return;
            }

            int tmpMuID = cbSetupMU.SelectedIndex;
            int tmpRuID = cbSetupRU.SelectedIndex;
            int tmpBdaID = cbSetupBDA.SelectedIndex;

            if (tmpMuID < 1 || tmpRuID < 1 || tmpBdaID < 1)
            {
                MessageBox.Show("BDA RF 설정값을 조회할 MU/RU/BDA를 선택해주시기 바랍니다.");
                return;
            }

            SetColor(btBdaRfInquiry, Color.Yellow);
            nmsMainMachine.EditData_BDA_RfValueInquiry((byte)tmpMuID, (byte)tmpRuID, (byte)tmpBdaID);
        }

        private void btBdaRfSet_Click(object sender, EventArgs e)
        {   //BDA RF값 설정
            int tmpMuID = cbSetupMU.SelectedIndex;
            int tmpRuID = cbSetupRU.SelectedIndex;
            int tmpBdaID = cbSetupBDA.SelectedIndex;

            if (tmpMuID < 1 || tmpRuID < 1 || tmpBdaID < 1)
            {
                MessageBox.Show("BDA RF값을 설정할 MU/RU/BDA를 선택해주시기 바랍니다.");
                return;
            }

            byte tmpRfValue = 0;
            try
            {
                tmpRfValue = Convert.ToByte(tbBdaRf.Text);
            }
            catch
            {
            }

            nmsMainMachine.EditData_BDA_RfValueSet((byte)tmpMuID, (byte)tmpRuID, (byte)tmpBdaID, tmpRfValue);
        }

        private void btBdaFreqSet_Click(object sender, EventArgs e)
        {   //BDA 주파수 변경
            int tmpMuID = cbSetupMU.SelectedIndex;
            int tmpRuID = cbSetupRU.SelectedIndex;

            if (tmpMuID < 1 || tmpRuID < 1)
            {
                MessageBox.Show("BDA 주파수를 변경할 MU/RU를 선택해주시기 바랍니다.");
                return;
            }

            if (MessageBox.Show("BDA 주파수를 변경하시겠습니까?",
                "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            int tmpNowFreq = cbBdaNowFreq.SelectedIndex;
            int tmpChangeFreq = cbBdaChangeFreq.SelectedIndex;

            if (tmpNowFreq < 1 || tmpChangeFreq < 1)
            {
                MessageBox.Show("현재 주파수 또는 변경할 주파수를 선택해주시기 바랍니다.");
                return;
            }

            nmsMainMachine.EditData_BDA_FreqSet((byte)tmpMuID, (byte)tmpRuID, (byte)(tmpNowFreq - 1), (byte)(tmpChangeFreq - 1));
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 경보음 재생 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public void BellSoundPlay(string soundFileName)
        {
            //재생을 시작한다.
            System.Media.SoundPlayer sndPlay = new System.Media.SoundPlayer(soundFileName);
            sndPlay.Play();
        }

        private void tmrBell_Tick(object sender, EventArgs e)
        {
            tmrBell.Stop();

            if (flagSound)
            {
                for (int i = 0; i < stationList.Count; i++)
                {
                    if (clsCommon.nmsGUIUser == "전라선")
                    {
                        if (clsCommon.flagStationAlarm[i])  //알람설정이 되어 있는경우만 소리를 낸다.
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                for (int k = 0; k < 5; k++)
                                {
                                    if (clsCommon.flagMuRuBdaError[i, j, k])
                                    {
                                        BellSoundPlay(bellFile);
                                        tmrBell.Start();
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                if (clsCommon.flagMuRuBdaError[i, j, k])
                                {
                                    BellSoundPlay(bellFile);
                                    tmrBell.Start();
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            tmrBell.Start();
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region NMS주장치와의 통신 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region NMS주장치와의 접속관련 이벤트
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void nmsMainMachine_nms_SocketConnected()
        {   //소켓 Connect 이벤트
            SetColor(lbl_Connected1, Color.Lime);
            AddStatus("NMS주장치에 접속하였습니다.");

            if (clsCommon.nmsGUIUser == "경춘선")
            {
                //모든 BDA의 정보를 조회한다.
                for (int i = 0; i < muruNowData.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (clsCommon.muruName[i].ruName[j].bdaName[k] != "")
                                nmsMainMachine.EditData_BDA_StInquiry((byte)(i + 1), (byte)(j + 1), (byte)(k + 1));
                        }
                    }
                }
            }
        }

        void nmsMainMachine_nms_SocketCloseed()
        {
            SetColor(lbl_Connected1, Color.Blue);
            AddStatus("NMS주장치와의 접속이 끊겼습니다.");
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region NMS주장치와의 Data 송수신 관련 이벤트(Data 보기, 송/수신 표시, 폴링)
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void nmsMainMachine_nms_receiveData(byte[] dataBuf, int lng)
        {
            for (int i = 0; i < 2; i++)
                cceTestPanel[i].SendData(dataBuf, lng);            
        }
        
        void nmsMainMachine_nms_SendReceiveDataView(bool flagSend, string strData)
        {   //송/수신 Data 보기
            if (flagSend) frmDG.SetTxData(clsCommon.NMS, strData);
            else frmDG.SetRxData(clsCommon.NMS, strData);
        }

        void nmsMainMachine_nms_DataSendReceive(bool flagSend)
        {   //Data 송/수신 표시
            if (flagSend)
            {
                if (lbl_TX1.BackColor == Color.Lime) SetColor(lbl_TX1, Color.Blue);
                else SetColor(lbl_TX1, Color.Lime);
            }
            else
            {
                if (lbl_RX1.BackColor == Color.Lime) SetColor(lbl_RX1, Color.Blue);
                else SetColor(lbl_RX1, Color.Lime);
            }
        }

        void nmsMainMachine_nms_Polling(bool flag)
        {
            if (flag) SetColor(lbl_Connected1, Color.Lime);
            else SetColor(lbl_Connected1, Color.Red);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region NMS주장치의 상태 보고 관련 이벤트
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void nmsMainMachine_nms_AfGain(byte muID, AFGain[] afGain)
        {
            for (int i = 0; i < 4; i++)
            {
                if (afGain[i].gainTx >= 0x80) afGain[i].gainTx = (afGain[i].gainTx - 0x80) * -1;
                if (afGain[i].gainRx >= 0x80) afGain[i].gainRx = (afGain[i].gainRx - 0x80) * -1;
                if (afGain[i].gainMon >= 0x80) afGain[i].gainMon = (afGain[i].gainMon - 0x80) * -1;
            }

            SetText(lblCCEAfGain1, afGain[0].gainTx.ToString() + " dB");
            SetText(lblCCEAfGain2, afGain[0].gainRx.ToString() + " dB");
            SetText(lblCCEAfGain3, afGain[0].gainMon.ToString() + " dB");

            SetText(lblRC1AfGain1, afGain[1].gainTx.ToString() + " dB");
            SetText(lblRC1AfGain2, afGain[1].gainRx.ToString() + " dB");
            SetText(lblRC1AfGain3, afGain[1].gainMon.ToString() + " dB");

            SetText(lblRC2AfGain1, afGain[2].gainTx.ToString() + " dB");
            SetText(lblRC2AfGain2, afGain[2].gainRx.ToString() + " dB");
            SetText(lblRC2AfGain3, afGain[2].gainMon.ToString() + " dB");

            SetText(lblRC3AfGain1, afGain[3].gainTx.ToString() + " dB");
            SetText(lblRC3AfGain2, afGain[3].gainRx.ToString() + " dB");
            SetText(lblRC3AfGain3, afGain[3].gainMon.ToString() + " dB");

			for (int i = 0; i < 4; i++)
				muruNowData[muID].afGain[i] = afGain[i].Clone();

            SetColor(btAfGainInquiry, colorSelect);

            //AddStatus(stationList[muID - 1] + "의 MU에서 AF Gain값을 보고하였습니다.");
        }

        void nmsMainMachine_nms_MuStReport(byte muID, MUData muData)
        {
            int i = 0;

            if (!clsCommon.muruComSt[muID - 1].flagMuFirst)
                clsCommon.muruComSt[muID - 1].flagMuFirst = true;

            clsCommon.muruComSt[muID - 1].cntMu = 0;
            if (!clsCommon.muruComSt[muID - 1].flagMu)
            {
                clsCommon.muruComSt[muID - 1].flagMu = true;

                //현재 MU화면을 보고 있으면 활성화 시킴.(통신 불량에서 정상으로 돌아온경우..)
                if (muID == clsCommon.presentMUID) MuStInit(true);

                SetColorMuButton(muID, 1);
            }

            //2012년 04월 12일
            if (clsCommon.nmsGUIUser == "경춘선")
            {
                //주 통신 감시 상태가 정상일경우 이고
                if (muData.optMonSt[0] == 0)
                {   //PTT를 잡았을 경우
                    if (muData.otherSt2[2] == 1)
                    {
                        //이전 값과 현재값이 같을경우
                        if (muruNowData[muID].muData.rfValue[0] == muData.rfValue[0])
                        {   //RF 출력값을 보고 18W 이상이거나 7W 이하이면 Error 처리한다.
                            if ((muData.rfValue[0] > 180) || (muData.rfValue[0] < 70))
                                muData.optMonSt[0] = 1;
                        }
                    }
                }

                //2012년 04월 16일
                //for (int i = 0; i < 2; i++)
                //{
                //    if (muData.rfValue[i] != 0)
                //        muData.rfValue[i] = (byte)(muData.rfValue[i] - 20);
                //}
            }

            //PTT가 잡히지 않으면 출력값은 0이다.
            if (muData.otherSt2[2] == 0) muData.rfValue[0] = 0;
            if (muData.otherSt2[4] == 0) muData.rfValue[1] = 0;

            //회선시험중...
            if (clsCommon.flagLineTest)
            {   //모드시 송신 Line...
                if (lineTestMode == 1)
                {   //시험중인 역사
                    if (muID == lineTestMuID)
                    {   //레벨 측정값 표시
                        int tmpValue = muData.revelValue;
                        if (tmpValue >= 0x80) tmpValue = (tmpValue - 0x80) * -1;
                        SetText(lblLineTestValue1, tmpValue.ToString());
                    }
                }
            }

            bool flagMuChPtt = false;

            //CCE Test Panel로 채널/PTT 상태 Data 송신
            if (muData.otherSt1[1] == 0)
            {   //주장치 사용
                //PTT 사용여부
                if (muData.otherSt2[2] == 0)
                {
                    if (muChPtt[muID - 1].flagPtt)
                    {
                        muChPtt[muID - 1].flagPtt = false;
                        flagMuChPtt = true;
                    }
                }
                else
                {
                    if (!muChPtt[muID - 1].flagPtt)
                    {
                        muChPtt[muID - 1].flagPtt = true;
                        flagMuChPtt = true;
                    }
                }

                //채널 상태
                if (muChPtt[muID - 1].ch != muData.chInfo[0])
                {
                    muChPtt[muID - 1].ch = muData.chInfo[0];
                    flagMuChPtt = true;
                }
            }
            else
            {   //예비장치 사용
                //PTT 사용여부
                if (muData.otherSt2[4] == 0)
                {
                    if (muChPtt[muID - 1].flagPtt)
                    {
                        muChPtt[muID - 1].flagPtt = false;
                        flagMuChPtt = true;
                    }
                }
                else
                {
                    if (!muChPtt[muID - 1].flagPtt)
                    {
                        muChPtt[muID - 1].flagPtt = true;
                        flagMuChPtt = true;
                    }
                }

                //채널 상태
                if (muChPtt[muID - 1].ch != muData.chInfo[1])
                {
                    muChPtt[muID - 1].ch = muData.chInfo[2];
                    flagMuChPtt = true;
                }
            }

            if (flagMuChPtt)
            {
                cceTestPanel[0].EditData_MU_ChPttSt(muChPtt, lineTestingUnit);
                cceTestPanel[1].EditData_MU_ChPttSt(muChPtt, lineTestingUnit);
            }

            //주/예비/감청 통신 Error Check
            for (i = 0; i < 3; i++)
            {
                if (muData.optMonSt[i] == 0)    //정상
                {
                    commErrCheck[muID].cntCommErr[i] = 0;
                    commErrCheck[muID].flagCommErr[i] = false;
                }
                else    //이상
                {
                    if (commErrCheck[muID].cntCommErr[i] < 60)
                        muData.optMonSt[i] = 0;     //일단 정상처리(1분간 유지되면 이상 처리)
                    else
                        commErrCheck[muID].cntCommErr[i] = 61;

                    commErrCheck[muID].flagCommErr[i] = true;
                }
            }

            //OPT CPU Error는 RU가 있는곳만 처리하고 RU가 없는곳은 정상처리한다.
            bool flagRuExist = false;
            for (i = 0; i < 4; i++)
            {
                if (clsCommon.muruName[muID - 1].ruName[i].ruName != "")
                {
                    flagRuExist = true;
                    break;
                }
            }
            if (!flagRuExist) muData.optOtherSt[6] = 0;

            if (nmsMuStDataChange(muID, muData))
            {   //변경된 Data 있음
                mrurDataChange[muID].cntMuDataChange = 6;
            }
            else
            {   //변경된 Data 없음
                mrurDataChange[muID].cntMuDataChange++;
            }

            muruNowData[muID].muData = muData.Clone();

            if (mrurDataChange[muID].cntMuDataChange > 5)
            {
                mrurDataChange[muID].cntMuDataChange = 0;
                nmsMUSt_DBSave(muID);   //변경된것 DB에 저장
            }
            
            //현재 보고있는 MU화면의 정보를 화면에 표시한다.
            if (muID == clsCommon.presentMUID) nmsMUSt_Display(muID);     //MU 상태 적용

            nmsMUError_Display(muID);   //전체화면의 stationSt 컨트롤에 주예비 상태 및 장애 표시
        }

        void nmsMainMachine_nms_RuStReport(byte muID, byte ruID, RUDetailData ruData)
        {
            if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagRuFirst)
                clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagRuFirst = true;

            clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].cntRu = 0;
            if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagRu)
            {
                clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagRu = true;

                //현재 RU화면을 보고 있으면 활성화 시킴.(통신 불량에서 정상으로 돌아온경우..)
                if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID)) RuStInit(true);

                try
                {
                    SetColorRuButton(muID, ruID, 1);
                }
                catch
                {
                }
            }

            //2012년 04월 16일
            //if (clsCommon.nmsGUIUser == "경춘선")
            //{
            //    if (ruData.rfValue > 20)
            //        ruData.rfValue = (byte)(ruData.rfValue - 20);
            //}

            if (nmsRuStDataChange(muID, ruID, ruData))
            {   //변경된 Data 있음
                mrurDataChange[muID].cntRuDataChange[ruID - 1] = 6;
            }
            else
            {   //변경된 Data 없음
                mrurDataChange[muID].cntRuDataChange[ruID - 1]++;
            }

            muruNowData[muID].ruData[ruID].ruData = ruData.Clone();

            if (mrurDataChange[muID].cntRuDataChange[ruID - 1] > 5)
            {
                mrurDataChange[muID].cntRuDataChange[ruID - 1] = 0;
                nmsRUSt_DBSave(muID, ruID);     //DB에 저장
            }

            //현재 보고있는 RU화면의 정보를 화면에 표시한다.
            if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID)) nmsRUSt_Display(muID, ruID);    //RU 상태 적용

            nmsRUError_Display(muID, ruID);  //RuSt 컨트롤에 주예비 상태 및 장애 표시
        }

        void nmsMainMachine_nms_UpsStReport(byte muID, UPSData upsData)
        {
            if (clsCommon.nmsGUIUser == "중앙선") return;

            if (!clsCommon.muruComSt[muID - 1].flagUpsFirst)
                clsCommon.muruComSt[muID - 1].flagUpsFirst = true;

            clsCommon.muruComSt[muID - 1].cntUps = 0;
            if (!clsCommon.muruComSt[muID - 1].flagUps)
            {
                clsCommon.muruComSt[muID - 1].flagUps = true;

                //현재 MU화면을 보고 있으면 활성화 시킴.(통신 불량에서 정상으로 돌아온경우..)
                if (muID == clsCommon.presentMUID) MuUpsStInit(true);
            }

            muruNowData[muID].upsData = upsData.Clone();

            nmsUPSSt_DBSave(muID);  //DB에 저장

            //현재 보고있는 MU화면의 정보가 변경되면 화면에 표시한다.
            if (muID == clsCommon.presentMUID) nmsUPSSt_Display(muID);

            nmsUPSError_Display(muID);   //전체화면의 stationSt 컨트롤에 주예비 상태 및 장애 표시
        }

        void nmsMainMachine_nms_FmStReport(byte muID, byte ruID, byte[] fmData)
        {
            bool flagChange = false;
            
            if (ruID == 0)
            {
                if (!clsCommon.muruFmExist[muID - 1].flagMu) return;

                if (!clsCommon.muruComSt[muID - 1].flagFmFirst)
                    clsCommon.muruComSt[muID - 1].flagFmFirst = true;

                clsCommon.muruComSt[muID - 1].cntFm = 0;
                if (!clsCommon.muruComSt[muID - 1].flagFm)
                {
                    clsCommon.muruComSt[muID - 1].flagFm = true;

                    //현재 MU화면을 보고 있으면 활성화 시킴.(통신 불량에서 정상으로 돌아온경우..)
                    if (muID == clsCommon.presentMUID) MuFmStInit(true);
                }

                if (fmData[0] != muruNowData[muID].fmData.otherSt[0]) flagChange = true;
                if (fmData[1] != muruNowData[muID].fmData.otherSt[1]) flagChange = true;

                if (flagChange)
                {
                    muruNowData[muID].fmData.otherSt[0] = fmData[0];
                    muruNowData[muID].fmData.otherSt[1] = fmData[1];

                    nmsMUSt_DBSave(muID);       //DB에 저장
                }

                nmsMUError_Display(muID);
            }
            else
            {
                if (!clsCommon.muruFmExist[muID - 1].flagRu[ruID - 1]) return;

                if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFmFirst)
                    clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFmFirst = true;

                clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].cntFm = 0;
                if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFm)
                {
                    clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFm = true;

                    //현재 RU화면을 보고 있으면 활성화 시킴.(통신 불량에서 정상으로 돌아온경우..)
                    if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID)) RuFmStInit(true);
                }

                if (fmData[0] != muruNowData[muID].ruData[ruID].fmData.otherSt[0]) flagChange = true;
                if (fmData[1] != muruNowData[muID].ruData[ruID].fmData.otherSt[1]) flagChange = true;

                if (flagChange)
                {
                    muruNowData[muID].ruData[ruID].fmData.otherSt[0] = fmData[0];
                    muruNowData[muID].ruData[ruID].fmData.otherSt[1] = fmData[1];

                    nmsRUSt_DBSave(muID, ruID);     //DB에 저장
                }

                nmsRUError_Display(muID, ruID);
            }

            //현재 보고있는 화면의 정보가 변경되면 화면에 표시한다.
            if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID)) nmsFMSt_Display(muID, ruID);
        }

        void nmsMainMachine_nms_SourcetelFmStReport(byte muID, byte ruID, FM_Info tmpFmInfo)
        {
            if (ruID == 0)
            {   //FM 모장치
                if (!clsCommon.muruComSt[muID - 1].flagFmFirst)
                    clsCommon.muruComSt[muID - 1].flagFmFirst = true;

                clsCommon.muruComSt[muID - 1].cntFm = 0;
                if (!clsCommon.muruComSt[muID - 1].flagFm)
                {
                    clsCommon.muruComSt[muID - 1].flagFm = true;

                    //현재 MU 화면을 보고 있으면 활성화 시킴.(통신 불량에서 정상으로 돌아온경우..)
                    if (muID == clsCommon.presentMUID) MuFmStInit(true);

                    AddStatus(stationList[muID - 1] + "의 FM 모장치와 통신이 복구되었습니다.");
                }

                muruNowData[muID].fmInfo = tmpFmInfo.Clone();

                nmsMuFmSt_DBSave(muID);   //DB에 저장

                nmsMUError_Display(muID);       //전체화면에 MU 및 FM 장애 표시
            }
            else
            {   //FM 자장치
                if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFmFirst)
                    clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFmFirst = true;

                clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].cntFm = 0;
                if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFm)
                {
                    clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFm = true;

                    //현재 RU화면을 보고 있으면 활성화 시킴.(통신 불량에서 정상으로 돌아온경우..)
                    if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID)) RuFmStInit(true);

                    string tmpStr = stationList[muID - 1] + " - " + clsCommon.muruName[muID - 1].ruName[ruID - 1].ruName;
                    AddStatus(tmpStr + "의 FM 자장치와 통신이 복구되었습니다.");
                }

                muruNowData[muID].ruData[ruID].fmInfo = tmpFmInfo.Clone();

                nmsRuFmSt_DBSave(muID, ruID);   //DB에 저장

                nmsRUError_Display(muID, ruID);		//전체화면에 RU 및 FM 장애 표시
            }

            //현재 보고있는 화면의 정보가 변경되면 화면에 표시한다.
            if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID)) nmsSourcetelFMSt_Display(muID, ruID);
        }

        void nmsMainMachine_nms_BDAInitRequest(byte muID, byte ruID)
        {   //BDA 초기화 요청
            BDAInitSet(muID, ruID); //BDA에 초기값을 설정한다.
        }

        void nmsMainMachine_nms_BDAInitReport(byte muID, byte ruID, BDAInit SetData)
        {   //BDA 초기 설정값 보고
            //BDA 초기 설정값을 표시한다.
            int i = 0;

            for (i = 0; i < 4; i++)
                SetChecked(chkBDAEnable[i], SetData.flagBDAEnable[i]);

            for (i = 0; i < 5; i++)
                SetEnable(rbBDAFreq[i], false);

            SetEnable(rbBDAFreq[SetData.bdaFreqCode], true);
            SetRdButChecked(rbBDAFreq[SetData.bdaFreqCode], true);

            SetChecked(chkBDAPollEnable, SetData.flagBDAPollEnable);

            SetText(tbBDAPollTime, SetData.pollTime.ToString());

            SetColor(btBDAInitInquiry, colorSelect);
        }

        void nmsMainMachine_nms_BDAStReport(byte muID, byte ruID, byte bdaID, BDA_St tmpBdaSt)
        {   //BDA 상태 보고
            if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBdaFirst[bdaID - 1])
                clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBdaFirst[bdaID - 1] = true;

            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    #region 경춘선 BDA 상태 표시
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].cntBda[bdaID - 1] = 0;
                    if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[bdaID - 1])
                    {
                        clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[bdaID - 1] = true;

                        //현재 RU화면을 보고 있으면 활성화 시킴.(통신 불량에서 정상으로 돌아온경우..)
                        if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID)) BdaStInit(true, (byte)(bdaID - 1));

                        btBdaSetColor(muID, ruID, bdaID, colorSelect);

                        string tmpStr = stationList[muID - 1] + " - " + clsCommon.muruName[muID - 1].ruName[ruID - 1].ruName + " - " + clsCommon.muruName[muID - 1].ruName[ruID - 1].bdaName[bdaID - 1];
                        AddStatus(tmpStr + "의 BDA와 통신이 복구되었습니다.");
                    }

                    /*
                    //현재 보고있는 RU화면의 BDA 정보를 원래대로 표시한다.
                    if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID))
                    {   //단, 원래대로 표시를 원할경우만..
                        if (flagBdaOriginalValue)
                        {
                        }
                        else
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                //1 ~ 23 => 24, 24 ~ 29 => 24 ~ 29, 30 ~ 98 => 29, 99 => 30
                                if (tmpBdaSt.ampDBM[i] == 0) tmpBdaSt.ampDBM[i] = 23;
                                else if (tmpBdaSt.ampDBM[i] > 0 && tmpBdaSt.ampDBM[i] < 24) tmpBdaSt.ampDBM[i] = 24;
                                else if (tmpBdaSt.ampDBM[i] > 29 && tmpBdaSt.ampDBM[i] < 99) tmpBdaSt.ampDBM[i] = 29;
                                else if (tmpBdaSt.ampDBM[i] == 99) tmpBdaSt.ampDBM[i] = 30;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            //1 ~ 23 => 24, 24 ~ 29 => 24 ~ 29, 30 ~ 98 => 29, 99 => 30
                            if (tmpBdaSt.ampDBM[i] == 0) tmpBdaSt.ampDBM[i] = 23;
                            else if (tmpBdaSt.ampDBM[i] > 0 && tmpBdaSt.ampDBM[i] < 24) tmpBdaSt.ampDBM[i] = 24;
                            else if (tmpBdaSt.ampDBM[i] > 29 && tmpBdaSt.ampDBM[i] < 99) tmpBdaSt.ampDBM[i] = 29;
                            else if (tmpBdaSt.ampDBM[i] == 99) tmpBdaSt.ampDBM[i] = 30;
                        }
                    }
                    */

                    //BDA 상태를 분석하여 DB에 저장하고 화면에 표시한다.
                    //변경된 Data 확인
                    if (nmsRuBDAStDataChange(muID, ruID, bdaID, tmpBdaSt))
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            if (tmpBdaSt.bdaAMPSt[i] == 0)
                            {   //정상
                                tmpBdaSt.bdaAmpErrTime[i] = DateTime.Now;
                            }
                            else
                            {   //Error
                                //정상에서 Error로 변경되었을 경우...
                                if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[i] != tmpBdaSt.bdaAMPSt[i])
                                    tmpBdaSt.bdaAmpErrTime[i] = DateTime.Now;
                                else    //Error상태이면 이전에 Error가 발생했던 시간을 넣어준다.
                                    tmpBdaSt.bdaAmpErrTime[i] = muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAmpErrTime[i];
                            }

                            if (tmpBdaSt.bdaUpsSt[i] == 0)
                            {   //정상
                                tmpBdaSt.bdaUpsErrTime[i] = DateTime.Now;
                            }
                            else
                            {   //Error
                                //정상에서 Error로 변경되었을 경우...
                                if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsSt[i] != tmpBdaSt.bdaUpsSt[i])
                                    tmpBdaSt.bdaUpsErrTime[i] = DateTime.Now;
                                else    //Error상태이면 이전에 Error가 발생했던 시간을 넣어준다.
                                    tmpBdaSt.bdaUpsErrTime[i] = muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsErrTime[i];
                            }
                        }

                        muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1] = tmpBdaSt.Clone();
                        nmsBDASt_DBSave(muID, ruID, bdaID);     //DB에 저장
                    }

                    //현재 보고있는 RU화면의 BDA 정보를 화면에 표시한다.
                    if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID))
                    {
                        bdaSt[bdaID - 1].btBDAInquiry_ColorSet();   //조회 버튼에 색을 입힌다.
                        nmsRUBDASt_Display(muID, ruID, bdaID);
                    }

                    nmsBDAError_Display(muID, ruID, bdaID);  //BDA 버튼 컨트롤에 장애 표시
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case "중앙선":
                    #region 중앙선 BDA 상태 표시
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].cntBda[bdaID - 1] = 0;
                    if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[bdaID - 1])
                    {
                        clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[bdaID - 1] = true;

                        //현재 RU화면을 보고 있으면 활성화 시킴.(통신 불량에서 정상으로 돌아온경우..)
                        if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID)) BdaStInit(true, (byte)(bdaID - 1));

                        string tmpStr = stationList[muID - 1] + " - " + clsCommon.muruName[muID - 1].ruName[ruID - 1].ruName + " - " + clsCommon.muruName[muID - 1].ruName[ruID - 1].bdaName[bdaID - 1];
                        AddStatus("BDA(" + tmpStr + ")와 통신이 복구되었습니다.");
                    }

                    //BDA 상태를 분석하여 DB에 저장하고 화면에 표시한다.
                    muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1] = tmpBdaSt.Clone();
                    nmsBDASt_DBSave(muID, ruID, bdaID);     //DB에 저장

                    //현재 보고있는 RU화면의 BDA 정보를 화면에 표시한다.
                    if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID))
                        nmsRUBDASt_Display(muID, ruID, bdaID);

                    nmsBDAError_Display(muID, ruID, bdaID);  //BDA 장애 여부 확인
                    nmsRUError_Display(muID, ruID);
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                default:
                    break;
            }
        }

        void nmsMainMachine_nms_BDALoopTest(byte muID, byte ruID, byte bdaID)
        {   //Loop Test 응답
            //현재 보고있는 RU화면의 정보가 변경되면 화면에 표시한다.
            if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID))
                bdaSt[bdaID - 1].btLoopTest_ColorSet();     //Loop Test 버튼에 색을 입힌다.
        }

        void nmsMainMachine_nms_BDARfValueReport(byte muID, byte ruID, byte bdaID, byte rfValue)
        {
            SetColor(btBdaRfInquiry, colorSelect);
            SetText(lblBdaRf, rfValue.ToString());
        }

        void nmsMainMachine_nms_BDACommStReport(byte muID, byte ruID, byte[] bdaCommSt)
        {
            for (byte i = 0; i < 4; i++)
            {
                if (bdaCommSt[i] == 1) clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[i] = false;
                else clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[i] = true;

                if (clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[i] != clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagOldBda[i])
                {
                    //현재 RU화면을 보고 있으면 통신 상태를 나타낸다.
                    if ((muID == clsCommon.presentMUID) && (ruID == clsCommon.presentRUID))
                        BdaStInit(clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[i], i);

                    clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagOldBda[i] = clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[i];
                }
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private bool nmsMuStDataChange(byte muID, MUData muData)
        {            
            int i = 0;

            //if (muData.dcValue != muruNowData[muID].muData.dcValue) return true;

            for (i = 0; i < 2; i++)
            {
                //if (muData.rfValue[i] != muruNowData[muID].muData.rfValue[i]) return true;
                if (muData.rfValueInquiry[i] != muruNowData[muID].muData.rfValueInquiry[i]) return true;
            }

            for (i = 0; i < 3; i++)
            {
                //if (muData.rxRssiValue[i] != muruNowData[muID].muData.rxRssiValue[i]) return true;
                if (muData.chInfo[i] != muruNowData[muID].muData.chInfo[i]) return true;

                if (muData.pllLockErrorSt[i] != muruNowData[muID].muData.pllLockErrorSt[i]) return true;
            }

            for (i = 0; i < 8; i++)
            {
                if (muData.otherSt1[i] != muruNowData[muID].muData.otherSt1[i]) return true;
                if (muData.otherSt2[i] != muruNowData[muID].muData.otherSt2[i]) return true;

                if (muData.optMonSt[i] != muruNowData[muID].muData.optMonSt[i]) return true;
                if (muData.optOtherSt[i] != muruNowData[muID].muData.optOtherSt[i]) return true;

                if (muData.optAlarmSt[i] != muruNowData[muID].muData.optAlarmSt[i]) return true;
            }

            //if (muData.optDcValue != muruNowData[muID].muData.optDcValue) return true;

            if (muData.chReturn != muruNowData[muID].muData.chReturn) return true;

            return false;
        }

        private bool nmsRuStDataChange(byte muID, byte ruID, RUDetailData ruData)
        {
            int i = 0;

            //if (ruData.dcValue != muruNowData[muID].ruData[ruID].ruData.dcValue) return true;
            //if (ruData.rfValue != muruNowData[muID].ruData[ruID].ruData.rfValue) return true;
            if (ruData.rfValueInquiry != muruNowData[muID].ruData[ruID].ruData.rfValueInquiry) return true;
            //if (ruData.rxRssiValue != muruNowData[muID].ruData[ruID].ruData.rxRssiValue) return true;

            for (i = 0; i < 8; i++)
            {
                if (ruData.otherSt1[i] != muruNowData[muID].ruData[ruID].ruData.otherSt1[i]) return true;
                if (ruData.otherSt2[i] != muruNowData[muID].ruData[ruID].ruData.otherSt2[i]) return true;
            }

            return false;
        }

        private bool nmsRuBDAStDataChange(byte muID, byte ruID, byte bdaID, BDA_St bdaData)
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    int i = 0;

                    for (i = 0; i < 8; i++)
                    {
                        if (bdaData.bdaAMPSt[i] != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[i]) return true;
                        if (bdaData.bdaUpsSt[i] != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsSt[i]) return true;
                    }

                    for (i = 0; i < 5; i++)
                    {
                        if (bdaData.ampDBM[i] != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].ampDBM[i]) return true;
                    }
                    break;

                default:
                    if (bdaData.fmTemperature != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].fmTemperature) return true;
                    if (bdaData.fmTssi != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].fmTssi) return true;
                    if (bdaData.fmAlarm != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].fmAlarm) return true;

                    if (bdaData.vhfAcAlarm != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].vhfAcAlarm) return true;
                    if (bdaData.vhfDcAlarm != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].vhfDcAlarm) return true;
                    if (bdaData.vhfBatteryAlarm != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].vhfBatteryAlarm) return true;

                    if (bdaData.uhfAcAlarm != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].uhfAcAlarm) return true;
                    if (bdaData.uhfDcAlarm != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].uhfDcAlarm) return true;
                    if (bdaData.uhfBatteryAlarm != muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].uhfBatteryAlarm) return true;
                    break;
            }

            return false;
        }

        #region DataBase 저장 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void nmsMUSt_DBSave(byte muID)
        {
            MuInfo tmpMuInfo = new MuInfo();

            tmpMuInfo.mu_id = muID;

            tmpMuInfo.autoManual = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[0]);
            tmpMuInfo.mainStby = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[1]);
            tmpMuInfo.wideNarrow = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[2]);
            tmpMuInfo.ac = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[3]);
            tmpMuInfo.dc = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[4]);
            tmpMuInfo.trxUnit = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[5]);

            //CCE PTT
            if (muruNowData[muID].muData.otherSt1[6] == 0)
            {
                tmpMuInfo.cce1Ptt = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[6]);
                tmpMuInfo.cce2Ptt = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[6]);
            }
            else
            {
                int i = 0;
                bool flag1 = false;
                bool flag2 = false;

                //구로 주장치 검사
                for (i = 0; i < 30; i++)
                {
                    //PTT ON
                    if (baseSt[0, i].otherSt[1] == 1)
                    {
                        tmpMuInfo.cce1Ptt = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[6]);
                        break;
                    }
                }

                if (i >= 30) flag1 = true;

                //대전 주장치 검사
                for (i = 0; i < 30; i++)
                {
                    //PTT ON
                    if (baseSt[1, i].otherSt[1] == 1)
                    {
                        tmpMuInfo.cce2Ptt = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[6]);
                        break;
                    }
                }

                if (i >= 30) flag2 = true;

                if (flag1 &&  flag2) tmpMuInfo.cce1Ptt = '1';
            }

            tmpMuInfo.rc1Ptt = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt1[7]);

            tmpMuInfo.rc2Ptt = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt2[0]);
            tmpMuInfo.rc3Ptt = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt2[1]);
            tmpMuInfo.mainPtt = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt2[2]);
            tmpMuInfo.mainBusy = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt2[3]);
            tmpMuInfo.stbyPtt = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt2[4]);
            tmpMuInfo.stbyBusy = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt2[5]);
            tmpMuInfo.monBusy = (char)clsCommon.HexaConvert(muruNowData[muID].muData.otherSt2[6]);

            tmpMuInfo.dcValue = (float)(muruNowData[muID].muData.dcValue / 10.0);

            tmpMuInfo.mainRf = (float)(muruNowData[muID].muData.rfValue[0] / 10.0);
            tmpMuInfo.mainRssi = (short)(muruNowData[muID].muData.rxRssiValue[0] * -1);
            tmpMuInfo.stbyRf = (float)(muruNowData[muID].muData.rfValue[1] / 10.0);
            tmpMuInfo.stbyRssi = (short)(muruNowData[muID].muData.rxRssiValue[1] * -1);
            tmpMuInfo.monRssi = (short)(muruNowData[muID].muData.rxRssiValue[2] * -1);
            tmpMuInfo.mainRfSet = muruNowData[muID].muData.rfValueInquiry[0];
            tmpMuInfo.stbyRfSet = muruNowData[muID].muData.rfValueInquiry[1];

            tmpMuInfo.mainCh = (char)clsCommon.HexaConvert(muruNowData[muID].muData.chInfo[0]);
            tmpMuInfo.stbyCh = (char)clsCommon.HexaConvert(muruNowData[muID].muData.chInfo[1]);
            tmpMuInfo.monCh = (char)clsCommon.HexaConvert(muruNowData[muID].muData.chInfo[2]);

            tmpMuInfo.mainComm = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optMonSt[0]);
            tmpMuInfo.stbyComm = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optMonSt[1]);
            tmpMuInfo.monComm = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optMonSt[2]);

            tmpMuInfo.chReturn = muruNowData[muID].muData.chReturn;

            tmpMuInfo.mainPllLock = (char)clsCommon.HexaConvert(muruNowData[muID].muData.pllLockErrorSt[0]);
            tmpMuInfo.stbyPllLock = (char)clsCommon.HexaConvert(muruNowData[muID].muData.pllLockErrorSt[1]);
            tmpMuInfo.monPllLock = (char)clsCommon.HexaConvert(muruNowData[muID].muData.pllLockErrorSt[2]);

            tmpMuInfo.optDc = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optOtherSt[0]);
            tmpMuInfo.optModOpen= (char)clsCommon.HexaConvert(muruNowData[muID].muData.optOtherSt[1]);
            tmpMuInfo.optCcePtt = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optOtherSt[2]);
            tmpMuInfo.muTrxCpu = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optOtherSt[5]);
            tmpMuInfo.muOptCpu = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optOtherSt[6]);
            tmpMuInfo.MuUps = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optOtherSt[7]);

            tmpMuInfo.optDcValue = (float)(muruNowData[muID].muData.optDcValue / 10.0);

            tmpMuInfo.opt1Ld = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optAlarmSt[0]);
            tmpMuInfo.opt2Ld = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optAlarmSt[1]);
            tmpMuInfo.opt3Ld = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optAlarmSt[2]);
            tmpMuInfo.opt4Ld = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optAlarmSt[3]);
            tmpMuInfo.opt1Pd = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optAlarmSt[4]);
            tmpMuInfo.opt2Pd = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optAlarmSt[5]);
            tmpMuInfo.opt3Pd = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optAlarmSt[6]);
            tmpMuInfo.opt4Pd = (char)clsCommon.HexaConvert(muruNowData[muID].muData.optAlarmSt[7]);

            fbDBMS_NMS.MuInsert(tmpMuInfo, muruNowData[muID].fmData); //DB에 저장
        }

        private void nmsUPSSt_DBSave(byte muID)
        {
            UpsInfo tmpUpsInfo = new UpsInfo();

            tmpUpsInfo.mu_id = muID;

            tmpUpsInfo.inputVoltage = (float)(Convert.ToDouble(muruNowData[muID].upsData.inVoltage));
            tmpUpsInfo.faultVoltage = (float)(Convert.ToDouble(muruNowData[muID].upsData.faultVoltage));
            tmpUpsInfo.outVoltage = (float)(Convert.ToDouble(muruNowData[muID].upsData.outVoltage));
            tmpUpsInfo.batteryVoltage = (float)(Convert.ToDouble(muruNowData[muID].upsData.batteryVoltage));
            tmpUpsInfo.currentPercent = Convert.ToInt16(muruNowData[muID].upsData.currentPercent);
            tmpUpsInfo.frequency = (float)(Convert.ToDouble(muruNowData[muID].upsData.frequency));
            tmpUpsInfo.temperature = (float)(Convert.ToDouble(muruNowData[muID].upsData.temperature));

            tmpUpsInfo.upsFailed = (char)clsCommon.HexaConvert(muruNowData[muID].upsData.otherSt[4]);
            tmpUpsInfo.batteryLow = (char)clsCommon.HexaConvert(muruNowData[muID].upsData.otherSt[6]);
            tmpUpsInfo.bypass = (char)clsCommon.HexaConvert(muruNowData[muID].upsData.otherSt[5]);
            tmpUpsInfo.utilityFail = (char)clsCommon.HexaConvert(muruNowData[muID].upsData.otherSt[7]);

            fbDBMS_NMS.UpsInsert(tmpUpsInfo);   //DB에 저장
        }

        private void nmsRUSt_DBSave(byte muID, byte ruID)
        {
            RuInfo tmpRuInfo = new RuInfo();

            tmpRuInfo.mu_id = muID;
            tmpRuInfo.ru_id = ruID;

            tmpRuInfo.autoManual = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt1[0]);
            tmpRuInfo.mainStby = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt1[1]);
            tmpRuInfo.wideNarrow = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt1[2]);
            tmpRuInfo.ac = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt1[3]);
            tmpRuInfo.dc = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt1[4]);
            tmpRuInfo.modOpen = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt1[5]);
            tmpRuInfo.ptt = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt1[6]);
            tmpRuInfo.localRemote = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt1[7]);

            tmpRuInfo.ruCpu = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt2[0]);
            tmpRuInfo.data = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt2[1]);
            tmpRuInfo.optLd = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt2[3]);
            tmpRuInfo.optPd = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt2[4]);
            tmpRuInfo.xmtrPllLock = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt2[5]);
            tmpRuInfo.rcvrpllLock = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].ruData.otherSt2[6]);

            tmpRuInfo.dcValue = (float)(muruNowData[muID].ruData[ruID].ruData.dcValue / 10.0);

            tmpRuInfo.rf = (float)(muruNowData[muID].ruData[ruID].ruData.rfValue / 10.0);
            tmpRuInfo.rfSet = muruNowData[muID].ruData[ruID].ruData.rfValueInquiry;
            tmpRuInfo.rssi = (short)(muruNowData[muID].ruData[ruID].ruData.rxRssiValue * -1);

            fbDBMS_NMS.RuInsert(tmpRuInfo, muruNowData[muID].ruData[ruID].fmData); //DB에 저장
        }

        private void nmsMuFmSt_DBSave(byte muID)
        {
            FM_Info tmpFmInfo = muruNowData[muID].fmInfo.Clone();
            tmpFmInfo.mu_id = muID;
            fbDBMS_NMS.MuFmInsert(tmpFmInfo);	//DB에 저장
        }

        private void nmsRuFmSt_DBSave(byte muID, byte ruID)
        {
            FM_Info tmpFmInfo = null;

            tmpFmInfo = muruNowData[muID].ruData[ruID].fmInfo.Clone();

            tmpFmInfo.mu_id = muID;
            tmpFmInfo.ru_id = ruID;

            fbDBMS_NMS.RuFmInsert(tmpFmInfo);	//DB에 저장
        }

        private void nmsBDASt_DBSave(byte muID, byte ruID, byte bdaID)
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    BdaInfo tmpBdaInfo = new BdaInfo();

                    tmpBdaInfo.mu_id = muID;
                    tmpBdaInfo.ru_id = ruID;
                    tmpBdaInfo.bda_id = bdaID;

                    tmpBdaInfo.power12 = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[5]);
                    tmpBdaInfo.power24 = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[6]);
                    tmpBdaInfo.power220 = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[7]);
                    tmpBdaInfo.comm = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsSt[7]);

                    tmpBdaInfo.fm = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[0]);
                    tmpBdaInfo.vhf = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[1]);
                    tmpBdaInfo.dmb = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[2]);
                    tmpBdaInfo.protection = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[3]);
                    tmpBdaInfo.trs = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[4]);

                    tmpBdaInfo.upsBypass = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsSt[2]);
                    tmpBdaInfo.upsAC = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsSt[3]);

                    if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsSt[4] == 1 || muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsSt[6] == 1) tmpBdaInfo.upsFail = '1';
                    else tmpBdaInfo.upsFail = '0';

                    tmpBdaInfo.upsBattery = (char)clsCommon.HexaConvert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsSt[5]);

                    tmpBdaInfo.fmValue = (Int16)muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].ampDBM[0];
                    tmpBdaInfo.vhfValue = (Int16)muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].ampDBM[1];
                    tmpBdaInfo.dmbValue = (Int16)muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].ampDBM[2];
                    tmpBdaInfo.protectionValue = (Int16)muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].ampDBM[3];
                    tmpBdaInfo.trsValue = (Int16)muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].ampDBM[4];

                    fbDBMS_NMS.BdaInsert(tmpBdaInfo);       //DB에 저장
                    break;

                default:
                    muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].mu_id = muID;
                    muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].ru_id = ruID;
                    muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bda_id = bdaID;

                    fbDBMS_NMS.sourcetelBdaInsert(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1]);
                    break;
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion


        private void nmsMuComSt_Display(int muID)
        {
            if (clsCommon.muruComSt[muID - 1].flagMuFirst)
            {
                if (clsCommon.nmsGUIUser != "전라선")
                {
                    if (clsCommon.muruComSt[muID - 1].flagMu) StationSt[muID - 1].SetErrorDisplay(0);     //통신 Error 복구
                    else StationSt[muID - 1].SetCommErrorDisplay();  //통신 Error
                }
            }
        }

        private void nmsRuComSt_Display(int muID)
        {            
            for (int i = 0; i < 4; i++)
            {
                if (clsCommon.muruComSt[muID - 1].ruBdaCommSt[i].flagRuFirst)
                {
                    if (clsCommon.muruName[muID - 1].ruName[i].ruName == "")
                    {
                        ruSt1[i].SetMainSpareChange(2);
                        ruSt2[i].SetMainSpareChange(2);
                        SetEnable(ruSt1[i], false);
                        SetEnable(ruSt2[i], false);
                    }
                    else
                    {
                        SetEnable(ruSt1[i], true);
                        SetEnable(ruSt2[i], true);

                        if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[i].flagRu)
                        {
                            ruSt1[i].SetCommErrorDisplay();
                            ruSt2[i].SetCommErrorDisplay();
                        }
                        else
                        {
                            ruSt1[i].SetMainSpareChange(muruNowData[clsCommon.presentMUID].ruData[i + 1].ruData.otherSt1[1]);
                            ruSt2[i].SetMainSpareChange(muruNowData[clsCommon.presentMUID].ruData[i + 1].ruData.otherSt1[1]);

                            nmsRUError_Display((byte)muID, (byte)(i + 1));
                        }
                    }
                }
                else
                {
                    if (clsCommon.muruName[muID - 1].ruName[i].ruName == "")
                    {
                        ruSt1[i].SetMainSpareChange(2);
                        ruSt2[i].SetMainSpareChange(2);
                        SetEnable(ruSt1[i], false);
                        SetEnable(ruSt2[i], false);
                    }
                    else
                    {
                        ruSt1[i].SetMainSpareChange(2);
                        ruSt2[i].SetMainSpareChange(2);
                        SetEnable(ruSt1[i], true);
                        SetEnable(ruSt2[i], true);
                    }
                }
            }
        }



        #region BDA 관련

        private void nmsBdaComSt_Display(int muID, int ruID, int bdaID)
        {
            if (clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBdaFirst[bdaID])
            {
                switch (clsCommon.nmsGUIUser)
                {
                    case "경춘선":
                        if (clsCommon.muruName[muID - 1].ruName[ruID - 1].bdaName[bdaID] == "")
                            bdaSt[bdaID].BdaStInit(false);
                        else
                            bdaSt[bdaID].BdaStInit(clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[bdaID]);
                        break;

                    default:
                        if (clsCommon.muruName[muID - 1].ruName[ruID - 1].bdaName[bdaID] == "")
                            RUSt.BDAInit((byte)bdaID, false);
                        else
                            RUSt.BDAInit((byte)bdaID, clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[bdaID]);
                        break;
                }
            }
        }

        private void btBdaSetColor(byte muID, byte ruID, byte bdaID, Color color)
        {
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    string[] tmpInfo = btMuBda[i].Tag.ToString().Split(new char[] { ',' });

                    byte tmpMuID = Convert.ToByte(tmpInfo[0]);
                    byte tmpRuID = Convert.ToByte(tmpInfo[1]);
                    byte tmpBdaID = Convert.ToByte(tmpInfo[2]);

                    if ((tmpMuID == muID) && (tmpRuID == ruID) && (bdaID == tmpBdaID))
                    {
                        SetColor(btMuBda[i], color);
                        break;
                    }
                }
            }
            catch
            {
            }
        }

        #endregion
        


        private void nmsMUError_Display(byte muID)
        {   //전체화면에 주예비 상태 및 장애 표시
            int tmpResult = 0;
            int i = 0;

            if (clsCommon.nmsGUIUser != "전라선")
            {
                //주 예비 상태 표시
                StationSt[muID - 1].SetMainSpareChange(muruNowData[muID].muData.otherSt1[1]);
            }

            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    #region 경춘선
                    //MU의 장애 표시
                    tmpResult =
                        //MU의 장애 상태 분석
                        muruNowData[muID].muData.otherSt1[3] +      //AC 전원
                        muruNowData[muID].muData.otherSt1[4] +      //DC 전원
                        muruNowData[muID].muData.otherSt1[5] +      //ModOpen(Monitor unit - TRX unit)

                        muruNowData[muID].muData.optMonSt[0] +      //주 통신감시(Main Transceiver)
                        muruNowData[muID].muData.optMonSt[2] +      //감청통신감시(Monitor Receiver)
                        muruNowData[muID].muData.optOtherSt[5] +      //MU TRX CPU
                        muruNowData[muID].muData.optOtherSt[6] +      //MU OPT CPU
                        muruNowData[muID].muData.optOtherSt[7] +      //MU UPS

                        muruNowData[muID].muData.optOtherSt[0] +    //OPT DC 전원
                        muruNowData[muID].muData.optOtherSt[1];     //OPT ModOpen

                    for (i = 0; i < 4; i++)
                    {
                        if (clsCommon.muruName[muID - 1].ruName[i].ruName != "")
                        {
                            tmpResult += muruNowData[muID].muData.optAlarmSt[i] +       //OPT 1 ~ 4 LD
                                         muruNowData[muID].muData.optAlarmSt[i + 4];    //OPT 1 ~ 4 PD
                        }
                    }

                    tmpResult +=
                        muruNowData[muID].muData.pllLockErrorSt[0] +    //주 PLL LOCK 장애
                        muruNowData[muID].muData.pllLockErrorSt[1] +    //예비 PLL LOCK 장애
                        muruNowData[muID].muData.pllLockErrorSt[2] +    //감청 PLL LOCK 장애

                        muruNowData[muID].upsData.otherSt[4] +      //입력전원(UPS Failed)
                        //muruNowData[muID].upsData.otherSt[5] +      //Bypass
                        muruNowData[muID].upsData.otherSt[6] +      //Battery Low
                        muruNowData[muID].upsData.otherSt[7];       //Utility Fail

                    //Auto인데 Stby이면 장애
                    if ((muruNowData[muID].muData.otherSt1[0] == 0) && (muruNowData[muID].muData.otherSt1[1] == 1))
                        tmpResult++;

                    //FM 장치의 장애 상태를 분석한다.
                    tmpResult +=
                        muruNowData[muID].fmData.otherSt[0] +   //FM Power 장애
                        muruNowData[muID].fmData.otherSt[1];    //FM RF 장애
                    break;
                    #endregion

                case "전라선":

                    #region 전라선

                    if (clsCommon.flagSpare[muID - 1])     //주/예비가 다 있는것
                    {
                        //MU의 장애 표시
                        tmpResult =
                            //MU의 장애 상태 분석
                            muruNowData[muID].muData.otherSt1[3] +      //AC 전원
                            muruNowData[muID].muData.otherSt1[4] +      //DC 전원
                            muruNowData[muID].muData.otherSt1[5] +      //ModOpen(Monitor unit - TRX unit)

                            muruNowData[muID].muData.optMonSt[0] +      //주 통신감시(Main Transceiver)
                            muruNowData[muID].muData.optMonSt[2] +      //감청통신감시(Monitor Receiver)
                            muruNowData[muID].muData.optOtherSt[5] +      //MU TRX CPU
                            muruNowData[muID].muData.optOtherSt[6] +      //MU OPT CPU
                            muruNowData[muID].muData.optOtherSt[7] +      //MU UPS

                            muruNowData[muID].muData.optOtherSt[0] +    //OPT DC 전원
                            muruNowData[muID].muData.optOtherSt[1];     //OPT ModOpen

                        for (i = 0; i < 4; i++)
                        {
                            if (clsCommon.muruName[muID - 1].ruName[i].ruName != "")
                            {
                                tmpResult += muruNowData[muID].muData.optAlarmSt[i] +       //OPT 1 ~ 4 LD
                                             muruNowData[muID].muData.optAlarmSt[i + 4];    //OPT 1 ~ 4 PD
                            }
                        }

                        tmpResult +=
                            muruNowData[muID].muData.pllLockErrorSt[0] +    //주 PLL LOCK 장애
                            muruNowData[muID].muData.pllLockErrorSt[1] +    //예비 PLL LOCK 장애
                            muruNowData[muID].muData.pllLockErrorSt[2] +    //감청 PLL LOCK 장애

                            muruNowData[muID].upsData.otherSt[4] +      //입력전원(UPS Failed)
                            muruNowData[muID].upsData.otherSt[5] +      //Bypass
                            muruNowData[muID].upsData.otherSt[6] +      //Battery Low
                            muruNowData[muID].upsData.otherSt[7];       //Utility Fail

                        tmpResult += muruNowData[muID].muData.optMonSt[1];      //예비통신감시(Stby Transceiver)

                        //Auto인데 Stby이면 장애
                        if ((muruNowData[muID].muData.otherSt1[0] == 0) && (muruNowData[muID].muData.otherSt1[1] == 1))
                            tmpResult++;
                    }
                    else    //주만 있고 예비 없는것
                    {
                        //MU의 장애 표시
                        tmpResult =
                            //MU의 장애 상태 분석
                            muruNowData[muID].muData.otherSt1[3] +      //AC 전원
                            muruNowData[muID].muData.otherSt1[4] +      //DC 전원
                            muruNowData[muID].muData.otherSt1[5] +      //ModOpen(Monitor unit - TRX unit)

                            muruNowData[muID].muData.optMonSt[0] +      //주 통신감시(Main Transceiver)
                            muruNowData[muID].muData.optMonSt[2] +      //감청통신감시(Monitor Receiver)
                            muruNowData[muID].muData.optOtherSt[5] +      //MU TRX CPU
                            muruNowData[muID].muData.optOtherSt[6] +      //MU OPT CPU
                            muruNowData[muID].muData.optOtherSt[7] +      //MU UPS

                            muruNowData[muID].muData.optOtherSt[0] +    //OPT DC 전원
                            muruNowData[muID].muData.optOtherSt[1];     //OPT ModOpen

                        for (i = 0; i < 4; i++)
                        {
                            if (clsCommon.muruName[muID - 1].ruName[i].ruName != "")
                            {
                                tmpResult += muruNowData[muID].muData.optAlarmSt[i] +       //OPT 1 ~ 4 LD
                                             muruNowData[muID].muData.optAlarmSt[i + 4];    //OPT 1 ~ 4 PD
                            }
                        }

                        tmpResult +=
                            muruNowData[muID].muData.pllLockErrorSt[0] +    //주 PLL LOCK 장애
                            ////muruNowData[muID].muData.pllLockErrorSt[1] +    //예비 PLL LOCK 장애
                            muruNowData[muID].muData.pllLockErrorSt[2] +    //감청 PLL LOCK 장애

                            muruNowData[muID].upsData.otherSt[4] +      //입력전원(UPS Failed)
                            muruNowData[muID].upsData.otherSt[5] +      //Bypass
                            muruNowData[muID].upsData.otherSt[6] +      //Battery Low
                            muruNowData[muID].upsData.otherSt[7];       //Utility Fail

                        //tmpResult += muruNowData[muID].muData.optMonSt[1];      //예비통신감시(Stby Transceiver)

                        //Auto인데 Stby이면 장애
                        //if ((muruNowData[muID].muData.otherSt1[0] == 0) && (muruNowData[muID].muData.otherSt1[1] == 1))
                        //    tmpResult++;
                    }


                    break;
                    #endregion

                case "중앙선":

                    #region 중앙선 
                    //MU의 장애 표시
                    tmpResult =
                        //MU의 장애 상태 분석
                        muruNowData[muID].muData.otherSt1[3] +      //AC 전원
                        muruNowData[muID].muData.otherSt1[4] +      //DC 전원
                        muruNowData[muID].muData.otherSt1[5] +      //ModOpen(Monitor unit - TRX unit)

                        muruNowData[muID].muData.optMonSt[0] +      //주 통신감시(Main Transceiver)
                        muruNowData[muID].muData.optMonSt[2] +      //감청통신감시(Monitor Receiver)
                        muruNowData[muID].muData.optOtherSt[5] +      //MU TRX CPU
                        muruNowData[muID].muData.optOtherSt[6] +      //MU OPT CPU
                        //muruNowData[muID].muData.optOtherSt[7] +      //MU UPS

                        muruNowData[muID].muData.optOtherSt[0] +    //OPT DC 전원
                        muruNowData[muID].muData.optOtherSt[1];     //OPT ModOpen

                    for (i = 0; i < 4; i++)
                    {
                        if (clsCommon.muruName[muID - 1].ruName[i].ruName != "")
                        {
                            tmpResult += muruNowData[muID].muData.optAlarmSt[i] +       //OPT 1 ~ 4 LD
                                         muruNowData[muID].muData.optAlarmSt[i + 4];    //OPT 1 ~ 4 PD
                        }
                    }

                    tmpResult +=
                        muruNowData[muID].muData.pllLockErrorSt[0] +    //주 PLL LOCK 장애
                        muruNowData[muID].muData.pllLockErrorSt[1] +    //예비 PLL LOCK 장애
                        muruNowData[muID].muData.pllLockErrorSt[2] +    //감청 PLL LOCK 장애

                        muruNowData[muID].upsData.otherSt[4] +      //입력전원(UPS Failed)
                        muruNowData[muID].upsData.otherSt[5] +      //Bypass
                        muruNowData[muID].upsData.otherSt[6] +      //Battery Low
                        muruNowData[muID].upsData.otherSt[7];       //Utility Fail

                    //Auto인데 Stby이면 장애
                    if ((muruNowData[muID].muData.otherSt1[0] == 0) && (muruNowData[muID].muData.otherSt1[1] == 1))
                        tmpResult++;

                    //FM Error 상태 체크
                    if (tmpResult == 0)
                    {
                        if (!nmsFmError_Display(muID, 0))
                            tmpResult++;
                    }
                    break;
                    #endregion
            }

            //MU통화권 전체화면의 MU버튼에 이상여부 표시
            //MU통화권화면의 MU상태에 RU의 상태를 반영하지 않는다.
            if (tmpResult == 0)
            {
                if (clsCommon.flagUPSError[muID - 1])
                    SetColorMuButton(muID, 2);
                else
                {
                    if (!clsCommon.muruComSt[muID - 1].flagMu) SetColor(btMuStation[muID - 1], colorBase);
                    else SetColor(btMuStation[muID - 1], colorSelect); 
                }
            }
            else
                SetColorMuButton(muID, 2);

            /*
            if (tmpResult == 0)
            {
                //RU의 장애 상태 분석
                for (i = 0; i < 4; i++)
                {
                    tmpResult +=
                        muruNowData[muID].ruData[i].ruData.otherSt1[3] +       //AC
                        muruNowData[muID].ruData[i].ruData.otherSt1[4] +       //DC
                        muruNowData[muID].ruData[i].ruData.otherSt1[5] +       //ModOpen

                        muruNowData[muID].ruData[i].ruData.otherSt2[0] +       //RU CPU
                        muruNowData[muID].ruData[i].ruData.otherSt2[1] +       //데이터 광접속
                        muruNowData[muID].ruData[i].ruData.otherSt2[3] +       //OPT LD 알람
                        muruNowData[muID].ruData[i].ruData.otherSt2[5] +       //XMTR PLL LOCK 장애
                        muruNowData[muID].ruData[i].ruData.otherSt2[6];        //RCVR PLL LOCK 장애
                }
            }
            */

            if (clsCommon.nmsGUIUser != "전라선")
                StationSt[muID - 1].SetErrorDisplay(tmpResult);

            //Error 상태 저장
            if (tmpResult == 0) clsCommon.flagMuRuBdaError[muID - 1, 0, 0] = false;
            else clsCommon.flagMuRuBdaError[muID - 1, 0, 0] = true;     //Error 발생
        }

        private void nmsRUError_Display(byte muID, byte ruID)
        {
            int i = 0;

            //주 예비 상태 표시
            //ruSt1[ruID - 1].SetMainSpareChange(muruNowData[muID].ruData[ruID].otherSt1[1]);
            //ruSt2[ruID - 1].SetMainSpareChange(muruNowData[muID].ruData[ruID].otherSt1[1]);

            //RU의 장애 표시
            int tmpResult =
                //RU의 장애 상태 분석
                muruNowData[muID].ruData[ruID].ruData.otherSt1[3] +       //AC
                muruNowData[muID].ruData[ruID].ruData.otherSt1[4] +       //DC
                muruNowData[muID].ruData[ruID].ruData.otherSt1[5] +       //ModOpen

                muruNowData[muID].ruData[ruID].ruData.otherSt2[0] +       //RU CPU
                muruNowData[muID].ruData[ruID].ruData.otherSt2[1] +       //데이터 광접속
                muruNowData[muID].ruData[ruID].ruData.otherSt2[3] +       //OPT LD 알람
                muruNowData[muID].ruData[ruID].ruData.otherSt2[5] +       //XMTR PLL LOCK 장애
                muruNowData[muID].ruData[ruID].ruData.otherSt2[6];        //RCVR PLL LOCK 장애

            //Auto인데 Stby이면 장애
            if ((muruNowData[muID].ruData[ruID].ruData.otherSt1[0] == 0) && (muruNowData[muID].ruData[ruID].ruData.otherSt1[1] == 1))
                tmpResult++;

            //경춘선의 경우 FM 장치의 장애 상태를 분석한다.
            if (clsCommon.nmsGUIUser == "경춘선")
            {
                tmpResult +=
                    muruNowData[muID].ruData[ruID].fmData.otherSt[0] +   //FM Power 장애
                    muruNowData[muID].ruData[ruID].fmData.otherSt[1];    //FM RF 장애
            }

            if (muID == clsCommon.presentMUID)
            {
                ruSt1[ruID - 1].SetErrorDisplay(tmpResult);
                ruSt2[ruID - 1].SetErrorDisplay(tmpResult);
            }

            //중앙선의 경우 소스텔의 FM 장치의 장애 상태를 분석한다.
            if (clsCommon.nmsGUIUser == "중앙선")
            {
                //FM Error 상태 체크
                if (tmpResult == 0)
                {
                    if (!nmsFmError_Display(muID, ruID))
                        tmpResult++;
                }
            }

            if (clsCommon.nmsGUIUser != "경춘선")
            {
                //BDA Error 상태 체크
                if (tmpResult == 0)
                {
                    for (i = 1; i < 4; i++)
                    {
                        if (clsCommon.flagMuRuBdaError[muID - 1, ruID, i])
                            tmpResult++;
                    }
                }
            }

            //MU통화권 전체화면의 RU버튼에 이상여부 표시
            if (tmpResult == 0)
            {
                if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagRu) SetColor(btRuStation[muID - 1, ruID - 1], colorBase);
                else SetColor(btRuStation[muID - 1, ruID - 1], colorSelect);
            }
            else
                SetColorRuButton(muID, ruID, 2);

            //Error 상태 저장
            if (tmpResult == 0) clsCommon.flagMuRuBdaError[muID - 1, ruID, 0] = false;
            else clsCommon.flagMuRuBdaError[muID - 1, ruID, 0] = true;     //Error 발생
        }

        private bool nmsFmError_Display(byte muID, byte ruID)
        {   //전체화면에 주예비 상태 및 장애 표시
            int tmpResult = 0;
                        
            if (ruID == 0)
            {   //MU FM의 장애 표시
                if (!clsCommon.muruComSt[muID - 1].flagFmFirst) return true;

                tmpResult =
                    //FM의 장애 상태 분석
                    muruNowData[muID].fmInfo.acInputFail +
                    muruNowData[muID].fmInfo.lnaFail +
                    muruNowData[muID].fmInfo.dcOutputFail +
                    //muruNowData[muID].fmInfo.overDisChange +
                    muruNowData[muID].fmInfo.ldAlarm +
                    muruNowData[muID].fmInfo.pdAlarm;
                    //muruNowData[muID].fmInfo.deviceFail;

                    if (tmpResult < 5) return false;
            }
            else
            {   //RU FM의 장애 표시
                if (!clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFmFirst) return true;

                tmpResult =
                    //FM의 장애 상태 분석
                    muruNowData[muID].ruData[ruID].fmInfo.acInputFail +
                    //muruNowData[muID].ruData[ruID].fmInfo.lnaFail +
                    muruNowData[muID].ruData[ruID].fmInfo.dcOutputFail +
                    //muruNowData[muID].ruData[ruID].fmInfo.overDisChange +
                    muruNowData[muID].ruData[ruID].fmInfo.ldAlarm +
                    muruNowData[muID].ruData[ruID].fmInfo.pdAlarm;
                    //muruNowData[muID].ruData[ruID].fmInfo.deviceFail;

                if (tmpResult < 4) return false;
            }

            return true;
        }

        private void nmsBDAError_Display(byte muID, byte ruID, byte bdaID)
        {   //BDA의 장애 표시
            int tmpResult = 0;

            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    int i = 0;

                    //BDA 상태 : 0~4-FM,역무,DMB,방호,TRS, 5-12V, 6-24V, 7-220V 상태
                    for (i = 0; i < 2; i++)
                    {
                        if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[i] == 1)
                        {   //Error시
                            //if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAmpErrTime[i].AddMinutes(30) < DateTime.Now)
                            //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                                tmpResult++;
                            //}
                        }
                    }
                    for (i = 5; i < 8; i++)
                    {
                        if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[i] == 1)
                        {   //Error시
                            //if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAmpErrTime[i].AddMinutes(30) < DateTime.Now)
                            //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                                tmpResult++;
                            //}
                        }
                    }

                    //BDA의 UPS 상태 : 3-UPS AC Off, 4-UPS Fail, 5-UPS Battery Low, 6-UPS Comm Fail, 7-AMP Comm Fail
                    for (i = 3; i < 7; i++)
                    {
                        if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsSt[i] == 1)
                        {   //Error시
                            //if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsErrTime[i].AddMinutes(30) < DateTime.Now)
                            //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                                tmpResult++;
                            //}
                        }
                    }

                    /*
                    for (i = 0; i < 8; i++)
                    {
                        tmpResult += muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaAMPSt[i];
                        //tmpResult += muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].bdaUpsSt[i];
                    }
                    */

                    //MU통화권 전체화면의 BDA버튼에 이상여부 표시
                    if (tmpResult == 0) btBdaSetColor(muID, ruID, bdaID, colorSelect);
                    else btBdaSetColor(muID, ruID, bdaID, colorError);
                    break;

                case "중앙선":
                    if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].fmAlarm == 0) tmpResult++;
                    if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].vhfBypass == 1) tmpResult++;
                    if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].vhfAcAlarm == 0) tmpResult++;
                    if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].vhfDcAlarm == 0) tmpResult++;
                    if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].vhfBatteryAlarm == 0) tmpResult++;
                    if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].uhfBypass == 1) tmpResult++;
                    if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].uhfAcAlarm == 0) tmpResult++;
                    if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].uhfDcAlarm == 0) tmpResult++;
                    if (muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1].uhfBatteryAlarm == 0) tmpResult++;
                    break;

                default:
                    break;
            }

            //Error 상태 저장
            if (tmpResult == 0) clsCommon.flagMuRuBdaError[muID - 1, ruID, bdaID] = false;
            else clsCommon.flagMuRuBdaError[muID - 1, ruID, bdaID] = true;     //Error 발생
        }

        private void nmsUPSError_Display(byte muID)
        {   //전체화면에 UPS 장애 표시
            int tmpResult = 0;

            //UPS의 장애 표시
            if (clsCommon.nmsGUIUser == "경춘선")
            {
                tmpResult =
                    //UPS의 장애 상태 분석
                    muruNowData[muID].upsData.otherSt[4] +      //UPS Fail
                    //muruNowData[muID].upsData.otherSt[5] +      //Bypass
                    muruNowData[muID].upsData.otherSt[6] +      //Battery Low
                    muruNowData[muID].upsData.otherSt[7];       //Utility Fail
            }
            else
            {
                tmpResult =
                    //UPS의 장애 상태 분석
                    muruNowData[muID].upsData.otherSt[4] +      //UPS Fail
                    muruNowData[muID].upsData.otherSt[5] +      //Bypass
                    muruNowData[muID].upsData.otherSt[6] +      //Battery Low
                    muruNowData[muID].upsData.otherSt[7];       //Utility Fail
            }

            if (clsCommon.nmsGUIUser != "전라선")
                StationSt[muID - 1].SetErrorDisplay(tmpResult);

            //MU통화권 전체화면의 MU버튼에 이상여부 표시
            if (tmpResult == 0)
            {
                if (clsCommon.flagMuRuBdaError[muID - 1, 0, 0])
                    SetColorMuButton(muID, 2);
                else
                {
                    if (!clsCommon.muruComSt[muID - 1].flagMu) SetColor(btMuStation[muID - 1], colorBase);
                    else SetColor(btMuStation[muID - 1], colorSelect); 
                }
            }
            else
                SetColorMuButton(muID, 2);

            //Error 상태 저장
            if (tmpResult == 0) clsCommon.flagUPSError[muID - 1] = false;
            else clsCommon.flagUPSError[muID - 1] = true;     //Error 발생
        }

        private void nmsMUSt_Display(byte muID)
        {
            for (int i = 0; i < 4; i++)
            {
                if (clsCommon.muruName[muID - 1].ruName[i].ruName != "")
                {
                    ruSt1[i].SetMainSpareChange(muruNowData[muID].ruData[i + 1].ruData.otherSt1[1]);

                    if (clsCommon.flagMuRuBdaError[muID - 1, i + 1, 0]) ruSt1[i].SetErrorDisplay(1);
                    else ruSt1[i].SetErrorDisplay(0);
                }
            }

            if (clsCommon.muruComSt[muID - 1].flagMuFirst)
                MUSt.nmsMUSt_Display(muID, muruNowData[muID].muData, baseSt, clsCommon.muruName[muID - 1].ruName);
            else    //Data가 한번도 수신되지 않은경우(처음 프로그램을 실행했을 경우..)
                MUSt.MuStInit(false);
        }

        private void nmsRUSt_Display(byte muID, byte ruID)
        {
            for (int i = 0; i < 4; i++)
            {
                if (clsCommon.muruName[muID - 1].ruName[i].ruName != "")
                {
                    ruSt2[i].SetMainSpareChange(muruNowData[muID].ruData[i + 1].ruData.otherSt1[1]);

                    if (clsCommon.flagMuRuBdaError[muID - 1, i + 1, 0]) ruSt2[i].SetErrorDisplay(1);
                    else ruSt2[i].SetErrorDisplay(0);
                }
            }

            if (clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagRuFirst)
                RUSt.nmsRUSt_Display(muruNowData[muID].ruData[ruID].ruData);
            else
                RUSt.RuStInit(false);

            //2012년 04월 12일 RXRSSI값을 BDA의 VHF RX에 표시한다.
            for (int i = 0; i < 4; i++)
            {
                if ((clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBdaFirst[i]) && (clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[i]))
                    bdaSt[i].nmsRUBDA_VHFRX_Display(muruNowData[muID].ruData[ruID].ruData.rxRssiValue * -1);
            }
        }

        private void nmsRUBDASt_Display(byte muID, byte ruID, byte bdaID)
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    if ((clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBdaFirst[bdaID - 1]) && (clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[bdaID - 1]))
                        bdaSt[bdaID - 1].nmsRUBDASt_Display(muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1]);
                    else
                        bdaSt[bdaID - 1].BdaStInit(false);
                    break;

                default:
                    if ((clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBdaFirst[bdaID - 1]) && (clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagBda[bdaID - 1]))
                        RUSt.nmsBDASt_Display((byte)(bdaID - 1), muruNowData[muID].ruData[ruID].bdaSt[bdaID - 1]);
                    else
                        RUSt.BDAInit((byte)(bdaID - 1), false);
                    break;
            }
        }

        private void nmsFMSt_Display(byte muID, byte ruID)
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    if (ruID == 0)
                    {
                        if ((clsCommon.muruComSt[muID - 1].flagFmFirst) && (clsCommon.muruComSt[muID - 1].flagFm))
                            MuFm.nmsFMSt_Display(muruNowData[muID].fmData);
                        else
                            MuFm.FmStInit(false);
                    }
                    else
                    {
                        if ((clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFmFirst) && (clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFm))
                            RuFm.nmsFMSt_Display(muruNowData[muID].ruData[ruID].fmData);
                        else
                            RuFm.FmStInit(false);
                    }
                    break;

                case "중앙선":
                    if (ruID == 0)
                    {
                        if ((clsCommon.muruComSt[muID - 1].flagFmFirst) && (clsCommon.muruComSt[muID - 1].flagFm))
                            MUSt.nmsFMSt_Display(muruNowData[muID].fmInfo);
                        else
                            MUSt.FmStInit(false);
                    }
                    else
                    {
                        if ((clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFmFirst) && (clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFm))
                            RUSt.nmsFMSt_Display(muruNowData[muID].ruData[ruID].fmInfo);
                        else
                            RUSt.FmStInit(false);
                    }
                    break;
            }
        }

        private void nmsSourcetelFMSt_Display(byte muID, byte ruID)
        {
            if (ruID == 0)
            {
                if (clsCommon.muruComSt[muID - 1].flagFmFirst)
                    MUSt.nmsFMSt_Display(muruNowData[muID].fmInfo);
                else    //Data가 한번도 수신되지 않은경우(처음 프로그램을 실행했을 경우..)
                    MUSt.FmStInit(false);
            }
            else
            {
                if (clsCommon.muruComSt[muID - 1].ruBdaCommSt[ruID - 1].flagFmFirst)
                    RUSt.nmsFMSt_Display(muruNowData[muID].ruData[ruID].fmInfo);
                else    //Data가 한번도 수신되지 않은경우(처음 프로그램을 실행했을 경우..)
                    RUSt.FmStInit(false);
            }
        }

        private void nmsUPSSt_Display(byte muID)
        {
            if ((clsCommon.muruComSt[muID - 1].flagUpsFirst) && (clsCommon.muruComSt[muID - 1].flagUps))
                MuUps.nmsUPSSt_Display(muruNowData[muID].upsData);
            else
                MuUps.UpsStInit(false);
        }


        #region CCE Test Panel과의 통신 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void frmMain_socket_Accepted(int MyID)
        {
            SetColor(lblConnected[MyID], Color.Lime);

            if (MyID == 1) AddStatus("구로 CCE Test Panel에서 접속하였습니다.");
            else AddStatus("대전 CCE Test Panel에서 접속하였습니다.");
        }

        void frmMain_socket_Closed(int MyID)
        {
            SetColor(lblConnected[MyID], Color.Blue);

            if (MyID == 1) AddStatus("구로 CCE Test Panel과의 접속이 끊겼습니다.");
            else AddStatus("대전 CCE Test Panel과의 접속이 끊겼습니다.");
        }

        void frmMain_dataSendReceive(int MyID, bool flagSend)
        {   //Data 송/수신 표시
            if (flagSend)
            {
                if (lblTX[MyID].BackColor == Color.Lime) SetColor(lblTX[MyID], Color.Blue);
                else SetColor(lblTX[MyID], Color.Lime);
            }
            else
            {
                if (lblRX[MyID].BackColor == Color.Lime) SetColor(lblRX[MyID], Color.Blue);
                else SetColor(lblRX[MyID], Color.Lime);
            }
        }

        void frmMain_sendReceiveDataView(int MyID, bool flagSend, string strData)
        {   //송/수신 Data 보기
            if (flagSend) frmDG.SetTxData(MyID, strData);
            else frmDG.SetRxData(MyID, strData);
        }

        void frmMain_mpu_CpuSt(int MyID, CpuSt tmpCpuSt)
        {
            int i = 0;

            clsCommon.cceComSt[MyID - 1].cntCCE = 0;
            if (!clsCommon.cceComSt[MyID - 1].flagCCE)
                clsCommon.cceComSt[MyID - 1].flagCCE = true;

            cpuSt[MyID - 1] = tmpCpuSt;

            //전체화면의 주장치 주 예비 상태 표시
            if (cpuSt[MyID - 1].mainStby == 0x31) MainMachineSt[MyID - 1].SetMainSpareChange(0);
            else MainMachineSt[MyID - 1].SetMainSpareChange(1);

            nmsCCEError_Display(MyID);  //전체화면에 주장치 장애 표시

            if (cceID != MyID - 1) return;  //현재 보고 있는 화면이 아니면 상태를 표시하지 않는다.

            if (cpuSt[MyID - 1].mainStby == 0x31)
            {   //Main
                SetColor(btMPU[0], colorSelect);
                SetColor(btMPU[1], colorBase);

                for (i = 0; i < 2; i++)
                {
                    //Main/Stby CPU Fault
                    if (cpuSt[MyID - 1].cpuSt[i] == 0) SetImage(pbMPU[i], NMS.Properties.Resources.st_Normal);
                    else SetImage(pbMPU[i], NMS.Properties.Resources.st_Error);
                }
            }
            else
            {   //Stby
                SetColor(btMPU[0], colorBase);
                SetColor(btMPU[1], colorSelect);

                //Main/Stby CPU Fault
                if (cpuSt[MyID - 1].cpuSt[0] == 0) SetImage(pbMPU[1], NMS.Properties.Resources.st_Normal);
                else SetImage(pbMPU[1], NMS.Properties.Resources.st_Error);
                if (cpuSt[MyID - 1].cpuSt[1] == 0) SetImage(pbMPU[0], NMS.Properties.Resources.st_Normal);
                else SetImage(pbMPU[0], NMS.Properties.Resources.st_Error);
            }

            for (i = 0; i < 2; i++)
            {
                //Main/Stby Power Fault
                if (cpuSt[MyID - 1].cpuSt[i + 2] == 0) SetColor(btPower[i], colorSelect);
                else SetColor(btPower[i], colorError);
            }
        }

        void frmMain_mpu_CcpConsoleBroadSt(int MyID, CcpSt[] tmpCcpSt, ConsoleSt[] tmpConsoleSt, BroadSt tmpBroadSt)
        {
            short i = 0;

            clsCommon.cceComSt[MyID - 1].cntCCE = 0;
            if (!clsCommon.cceComSt[MyID - 1].flagCCE)
                clsCommon.cceComSt[MyID - 1].flagCCE = true;

            for (i = 0; i < 9; i++)
            {
                if (useSt[MyID - 1].flagCCP[i])
                {
                    //CCP 상태 DB 저장
                    //ccpSt[MyID - 1, i] = tmpCcpSt[i];
                    ccpSt[MyID - 1, i].flagCommunicationFault = tmpCcpSt[i].flagCommunicationFault;
                    ccpSt[MyID - 1, i].flagPCCommFault = tmpCcpSt[i].flagPCCommFault;

                    /*
                    ccpStInfo tmpStInfo = new ccpStInfo();
                    tmpStInfo.cce_id = (byte)MyID;

                    tmpStInfo.ccp_id = i;

                    if (ccpSt[MyID - 1, i].flagCommunicationFault) tmpStInfo.comm = '1';
                    else tmpStInfo.comm = '0';

                    if (ccpSt[MyID - 1, i].flagPCCommFault) tmpStInfo.pcComm = '1';
                    else tmpStInfo.pcComm = '0';

                    fbDBMS_NMS.CCPInsert(tmpStInfo);
                    */
                }

                if (useSt[MyID - 1].flagConsole[i])
                {
                    //Console I/F DB 저장
                    //consoleSt[MyID - 1, i] = tmpConsoleSt[i];                        
                    consoleSt[MyID - 1, i].ch = tmpConsoleSt[i].ch;
                    for (int j = 0; j < 3; j++) consoleSt[MyID - 1, i].otherSt[j] = tmpConsoleSt[i].otherSt[j];

                    /*
                    consoleStInfo tmpStInfo = new consoleStInfo();
                    tmpStInfo.cce_id = (byte)MyID;

                    tmpStInfo.if_id = i;

                    tmpStInfo.ch = (char)(clsCommon.HexaConvert(consoleSt[MyID - 1, i].ch));
                    tmpStInfo.comm = (char)(clsCommon.HexaConvert(consoleSt[MyID - 1, i].otherSt[0]));
                    tmpStInfo.ptt = (char)(clsCommon.HexaConvert(consoleSt[MyID - 1, i].otherSt[1]));
                    tmpStInfo.broad = (char)(clsCommon.HexaConvert(consoleSt[MyID - 1, i].otherSt[2]));

                    fbDBMS_NMS.ConsoleIFInsert(tmpStInfo);
                    */
                }
            }

            if (useSt[MyID - 1].flagBroad)
            {
                //Broad I/F 상태 DB 저장
                //broadSt[MyID - 1] = tmpBroadSt;
                for (int j = 0; j < 6; j++) broadSt[MyID - 1].otherSt[j] = tmpBroadSt.otherSt[j];

                /*
                broadStInfo tmpStInfo = new broadStInfo();
                tmpStInfo.cce_id = (byte)MyID;

                tmpStInfo.enabel1 = (char)(clsCommon.HexaConvert(broadSt[MyID - 1].otherSt[0]));
                tmpStInfo.enabel2 = (char)(clsCommon.HexaConvert(broadSt[MyID - 1].otherSt[1]));
                tmpStInfo.enabel3 = (char)(clsCommon.HexaConvert(broadSt[MyID - 1].otherSt[2]));
                tmpStInfo.ptt1 = (char)(clsCommon.HexaConvert(broadSt[MyID - 1].otherSt[3]));
                tmpStInfo.ptt2 = (char)(clsCommon.HexaConvert(broadSt[MyID - 1].otherSt[4]));
                tmpStInfo.ptt3 = (char)(clsCommon.HexaConvert(broadSt[MyID - 1].otherSt[5]));

                fbDBMS_NMS.BroadIFInsert(tmpStInfo);
                */
            }

            nmsCCEError_Display(MyID);  //전체화면에 주장치 장애 표시

            if (cceID != MyID - 1) return;  //현재 보고 있는 화면이 아니면 상태를 표시하지 않는다.

            //현재 보고있는 화면에 따라 실시간 표시..
            switch (cceDepth)
            {
                case gbViewMain:
                    //CCP Communication Fault 상태 표시
                    for (i = 0; i < 9; i++)
                    {
                        if (useSt[cceID].flagCCP[i])
                        {
                            if (ccpSt[cceID, i].flagCommunicationFault)
                            {
                                if (ccpSt[cceID, i].flagPCCommFault) SetColor(btCCP[i], colorSelect);
                                else SetColor(btCCP[i], Color.Yellow);
                            }
                            else SetColor(btCCP[i], colorError);
                        }
                        else
                        {
                            SetColor(btCCP[i], colorBase);
                        }
                    }

                    //Console I/F Communication Fault 상태 표시
                    for (i = 0; i < 9; i++)
                    {
                        if (useSt[cceID].flagConsole[i])
                        {
                            if (consoleSt[cceID, i].otherSt[0] == 0) SetColor(btConsole[i], colorSelect);
                            else SetColor(btConsole[i], colorError);
                        }
                        else
                        {
                            SetColor(btConsole[i], colorBase);
                        }
                    }

                    //Broad I/F Communication Fault 상태 표시
                    if (useSt[cceID].flagBroad)
                    {
                        if (broadSt[cceID].otherSt[0] == 0) SetColor(btBroad, colorSelect);
                        else SetColor(btBroad, colorError);
                    }
                    else
                    {
                        SetColor(btBroad, colorBase);
                    }
                    break;

                case gbViewConsole:
                    ConsoleIFStView(selectedIndex);
                    break;

                case gbViewBroad:
                    BroadIFStView();
                    break;
            }
        }

        void frmMain_mpu_BaseSt(int MyID, BaseSt[] tmpBaseSt)
        {
            short i = 0;

            clsCommon.cceComSt[MyID - 1].cntCCE = 0;
            if (!clsCommon.cceComSt[MyID - 1].flagCCE)
                clsCommon.cceComSt[MyID - 1].flagCCE = true;

            for (i = 0; i < 30; i++)
            {
                if (useSt[MyID - 1].flagBase[i])
                {
                    //Base I/F 상태 DB 저장
                    //baseSt[MyID - 1, i] = tmpBaseSt[i];
                    baseSt[MyID - 1, i].ch = tmpBaseSt[i].ch;
                    for (int j = 0; j < 7; j++) baseSt[MyID - 1, i].otherSt[j] = tmpBaseSt[i].otherSt[j];

                    /*
                    baseStInfo tmpStInfo = new baseStInfo();
                    tmpStInfo.cce_id = (byte)MyID;

                    tmpStInfo.if_id = i;

                    tmpStInfo.ch = (char)(clsCommon.HexaConvert(baseSt[MyID - 1, i].ch));

                    tmpStInfo.comm = (char)(clsCommon.HexaConvert(baseSt[MyID - 1, i].otherSt[0]));
                    tmpStInfo.ptt = (char)(clsCommon.HexaConvert(baseSt[MyID - 1, i].otherSt[1]));
                    tmpStInfo.busy = (char)(clsCommon.HexaConvert(baseSt[MyID - 1, i].otherSt[2]));
                    tmpStInfo.eBusy = (char)(clsCommon.HexaConvert(baseSt[MyID - 1, i].otherSt[3]));
                    tmpStInfo.broad = (char)(clsCommon.HexaConvert(baseSt[MyID - 1, i].otherSt[4]));
                    tmpStInfo.faultTone1 = (char)(clsCommon.HexaConvert(baseSt[MyID - 1, i].otherSt[5]));
                    tmpStInfo.faultTone2 = (char)(clsCommon.HexaConvert(baseSt[MyID - 1, i].otherSt[6]));

                    fbDBMS_NMS.BaseIFInsert(tmpStInfo);
                    */
                }
            }

            nmsCCEError_Display(MyID);  //전체화면에 주장치 장애 표시

            if (cceID != MyID - 1) return;  //현재 보고 있는 화면이 아니면 상태를 표시하지 않는다.

            //현재 보고있는 화면에 따라 실시간 표시..
            switch (cceDepth)
            {
                case gbViewMain:
                    //Base I/F Communication Fault 상태 표시
                    for (i = 0; i < 30; i++)
                    {
                        if (useSt[cceID].flagBase[i])
                        {
                            if (baseSt[cceID, i].otherSt[0] == 0) SetColor(btBase[i], colorSelect);
                            else SetColor(btBase[i], colorError);
                        }
                        else
                        {
                            SetColor(btBase[i], colorBase);
                        }
                    }
                    break;

                case gbViewBase:
                    BaseIFStView(selectedIndex);
                    break;
            }
        }

        void frmMain_mpu_GainValue(int MyID, byte id, byte[] tmpGainValue)
        {
            int i = 0;

            clsCommon.cceComSt[MyID - 1].cntCCE = 0;
            if (!clsCommon.cceComSt[MyID - 1].flagCCE)
                clsCommon.cceComSt[MyID - 1].flagCCE = true;

            if ((id >= 0x30) && (id <= 0x38))
            {   //Console I/F ID
                for (i = 0; i < 8; i++)
                {
                    consoleSt[MyID - 1, id - clsCommon.ID_Console].gainValue[i] = tmpGainValue[i];

                    if (consoleSt[MyID - 1, id - clsCommon.ID_Console].gainValue[i] >= 0x80)
                        consoleSt[MyID - 1, id - clsCommon.ID_Console].gainValue[i] = (consoleSt[MyID - 1, id - clsCommon.ID_Console].gainValue[i] - 0x80) * -1;
                }

                if (cceID != MyID - 1) return;  //현재 보고 있는 화면이 아니면 상태를 표시하지 않는다.

                //현재 보고있는 화면에 따라 실시간 표시..
                if (cceDepth == gbViewConsole)
                {
                    if (selectedIndex == id - clsCommon.ID_Console)
                    {
                        for (i = 0; i < 8; i++)
                            SetText(lblConsoleGain[i], consoleSt[cceID, selectedIndex].gainValue[i].ToString());
                    }
                }
            }
            else if (id == 0x39)
            {   //Broad I/F ID
                for (i = 0; i < 4; i++)
                {
                    broadSt[MyID - 1].gainValue[i] = tmpGainValue[i];

                    if (broadSt[MyID - 1].gainValue[i] >= 0x80)
                        broadSt[MyID - 1].gainValue[i] = (broadSt[MyID - 1].gainValue[i] - 0x80) * -1;
                }

                if (cceID != MyID - 1) return;  //현재 보고 있는 화면이 아니면 상태를 표시하지 않는다.

                //현재 보고있는 화면에 따라 실시간 표시..
                if (cceDepth == gbViewBroad)
                {
                    for (i = 0; i < 4; i++)
                        SetText(lblBroadGain[i], broadSt[cceID].gainValue[i].ToString());
                }
            }
            else if ((id >= 0x00) && (id <= 0x1D))
            {   //Base I/F ID
                for (i = 0; i < 8; i++)
                {
                    baseSt[MyID - 1, id - clsCommon.ID_Base].gainValue[i] = tmpGainValue[i];

                    if (baseSt[MyID - 1, id - clsCommon.ID_Base].gainValue[i] >= 0x80)
                        baseSt[MyID - 1, id - clsCommon.ID_Base].gainValue[i] = (baseSt[MyID - 1, id - clsCommon.ID_Base].gainValue[i] - 0x80) * -1;
                }

                if (cceID != MyID - 1) return;  //현재 보고 있는 화면이 아니면 상태를 표시하지 않는다.

                //현재 보고있는 화면에 따라 실시간 표시..
                if (cceDepth == gbViewBase)
                {
                    if (selectedIndex == id - clsCommon.ID_Base)
                    {
                        for (i = 0; i < 8; i++)
                            SetText(lblBaseGain[i], baseSt[cceID, selectedIndex].gainValue[i].ToString());
                    }
                }
            }
        }

        void frmMain_mpu_BroadUnitSelectedSt(int MyID, byte[,] tmpUnitSelectedSt)
        {
            int i = 0;

            for (i = 0; i < 30; i++)
            {
                broadSt[MyID - 1].unitSelectedSt[0, i] = tmpUnitSelectedSt[0, i];
                broadSt[MyID - 1].unitSelectedSt[1, i] = tmpUnitSelectedSt[1, i];
                broadSt[MyID - 1].unitSelectedSt[2, i] = tmpUnitSelectedSt[2, i];
            }

            if (cceID != MyID - 1) return;  //현재 보고 있는 화면이 아니면 상태를 표시하지 않는다.

            //현재 보고있는 화면에 따라 실시간 표시..
            if (cceDepth == gbViewBroad)
            {
                //선택 기지국 표시
                for (i = 0; i < 30; i++)
                {
                    if (broadSt[cceID].unitSelectedSt[0, i] == 1) SetColor(lblBroadSelSt1[i], colorSelect);
                    else SetColor(lblBroadSelSt1[i], colorBase);

                    if (broadSt[cceID].unitSelectedSt[1, i] == 1) SetColor(lblBroadSelSt2[i], colorSelect);
                    else SetColor(lblBroadSelSt2[i], colorBase);

                    if (broadSt[cceID].unitSelectedSt[2, i] == 1) SetColor(lblBroadSelSt3[i], colorSelect);
                    else SetColor(lblBroadSelSt3[i], colorBase);
                }
            }
        }

        void frmMain_mpu_IfUseSt(int MyID, UseSt tmpUseSt)
        {
            useSt[MyID - 1] = tmpUseSt;

            if (cceID != MyID - 1) return;  //현재 보고 있는 화면이 아니면 상태를 표시하지 않는다.

            IFUseStView();
        }

        void frmMain_mpu_LineTestValue(int MyID, byte revelValue)
        {
            //회선시험중...
            if (clsCommon.flagLineTest)
            {   //모드시 송신 Line...
                if (lineTestMode == 2 || lineTestMode == 3)
                {   //시험중인 역사
                    //레벨 측정값 표시
                    int tmpValue = revelValue;
                    if (tmpValue >= 0x80) tmpValue = (tmpValue - 0x80) * -1;
                    SetText(lblLineTestValue2, tmpValue.ToString());
                }
            }            
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion


        /// <summary>
        /// 주장치 정보 표시
        /// </summary>
        /// <param name="MyID"></param>
        private void nmsCCEError_Display(int MyID)
        {   //전체화면에 주장치 장애 표시
            bool flagError = false;

            int i = 0;

            if (clsCommon.cceComSt[MyID - 1].flagCCE) CCEStInit(true);

            for (i = 0; i < 2; i++)
            {   //Main/Stby Power Fault                
                if (cpuSt[MyID - 1].cpuSt[i + 2] == 1) flagError = true;
            }

            for (i = 0; i < 9; i++)
            {
                if (useSt[MyID - 1].flagCCP[i])
                {
                    if (!ccpSt[MyID - 1, i].flagCommunicationFault) flagError = true;
                }
            }

            //Console I/F Communication Fault 상태 표시
            for (i = 0; i < 9; i++)
            {
                if (useSt[MyID - 1].flagConsole[i])
                {
                    if (consoleSt[MyID - 1, i].otherSt[0] == 1) flagError = true;
                }
            }

            //Broad I/F Communication Fault 상태 표시
            if (useSt[MyID - 1].flagBroad)
            {
                if (broadSt[MyID - 1].otherSt[0] == 1) flagError = true;
            }

            //Base I/F Communication Fault 상태 표시
            for (i = 0; i < 30; i++)
            {
                if (useSt[MyID - 1].flagBase[i])
                {
                    if (baseSt[MyID - 1, i].otherSt[0] == 1) flagError = true;
                }
            }

            if (flagError)
            {
                MainMachineSt[MyID - 1].SetErrorDisplay(1);
                SetColor(lblCCEErrSt[MyID - 1], colorError);
            }
            else
            {
                MainMachineSt[MyID - 1].SetErrorDisplay(0);
                SetColor(lblCCEErrSt[MyID - 1], colorSelect);
            }
        }



        #region 각 폼의 중복실행을 막기위한 메소드
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void frmDG_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < clsCommon.CNTMACHINE; i++)
                clsCommon.flagDebug[i] = false;

            frmDG = null;
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion


        private byte bdaInitSec = 0;

        private int bdaInitMin = 0;

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            tmrMain.Stop();

            int i = 0, j = 0;

            if (day != DateTime.Now.Day)
            {   //날자가 변경되면..
                day = DateTime.Now.Day;

                //1. 각 MU의 Gain값을 읽어온다.
                //for (i = 0; i < clsCommon.stationCount; i++)
                //    nmsMainMachine.EditData_AfGainInquiry((byte)(i + 1));

                //2. CCE_Test_Panel로 시간을 동기화 시킨다.
                for (i = 0; i < 2; i++)
                    cceTestPanel[i].EditData_TimeSet();

                //3. DB파일도 바꿔준다.
                NMSDB_Connect();

                //AddStatus("시간을 동기화 합니다.");
            }
            
            //주장치와의 통신상태를 점검하기 위햔 작업
            for (i = 0; i < 3; i++)
            {
                if (clsCommon.cceComSt[i].cntCCE++ > 30)
                {
                    clsCommon.cceComSt[i].cntCCE = 31;

                    if (clsCommon.cceComSt[i].flagCCE)
                    {
                        clsCommon.cceComSt[i].flagCCE = false;

                        //현재 보고있는 주장치화면이면 통신불량 상태로 비활성화 시킨다.
                        if (i == cceID) CCEStInit(false);
                        
                        //if (!clsCommon.cceComSt[MyID - 1].flagCCE)
                        //    clsCommon.cceComSt[MyID - 1].flagCCE = true;

                        MainMachineSt[i].SetCommErrorDisplay();
                        SetColor(lblCCEErrSt[i], colorBase);
                    }
                }
            }
            
            //각 기지국과의 통신상태를 점검하기 위한 작업
            for (i = 0; i < stationList.Count; i++)
            {
                //MU
                if (clsCommon.muruComSt[i].cntMu++ > 600)
                {
                    clsCommon.muruComSt[i].cntMu = 601;

                    if (clsCommon.muruComSt[i].flagMu)
                    {
                        clsCommon.muruComSt[i].flagMu = false;

                        //현재 보고있는 MU화면이 있으면 통신불량 상태로 비활성화 시킨다.
                        if (i + 1 == clsCommon.presentMUID) MuStInit(false);

                        if (clsCommon.nmsGUIUser != "전라선")
                            StationSt[i].SetCommErrorDisplay();

                        SetColorMuButton((byte)(i + 1), 0);
                    }
                }

                int cntFmTimeOut = 0;
                switch (clsCommon.nmsGUIUser)
                {
                    case "경춘선":
                        cntFmTimeOut = 600;
                        break;

                    case "중앙선":
                        cntFmTimeOut = 600;     //2012년 12월 05일 : 소스텔의 요청으로 FM이 통신 Error 시간을 3분에서 10분으로 늘임
                        break;
                }

                //MU FM
                if (clsCommon.muruComSt[i].cntFm++ > cntFmTimeOut)
                {
                    clsCommon.muruComSt[i].cntFm = cntFmTimeOut + 1;

                    if (clsCommon.muruComSt[i].flagFm)
                    {
                        clsCommon.muruComSt[i].flagFm = false;

                        //현재 보고있는 MU화면이 있으면 통신불량 상태로 비활성화 시킨다.
                        if (i + 1 == clsCommon.presentMUID) MuFmStInit(false);

                        //FM이 있으면 통신이 끊긴것을 로고에 남긴다.
                        if (clsCommon.muruFmExist[i].flagMu)
                            AddStatus(stationList[i] + "의 FM 모장치와 통신이 끊겼습니다.");
                    }
                }

                //MU UPS
                if (clsCommon.muruComSt[i].cntUps++ > 600)
                {
                    clsCommon.muruComSt[i].cntUps = 601;

                    if (clsCommon.muruComSt[i].flagUps)
                    {
                        clsCommon.muruComSt[i].flagUps = false;

                        //현재 보고있는 MU화면이 있으면 통신불량 상태로 비활성화 시킨다.
                        if (i + 1 == clsCommon.presentMUID) MuUpsStInit(false);
                    }
                }

                //RU
                for (j = 0; j < 4; j++)
                {
                    //RU
                    if (clsCommon.muruComSt[i].ruBdaCommSt[j].cntRu++ > 600)
                    {
                        clsCommon.muruComSt[i].ruBdaCommSt[j].cntRu = 601;

                        if (clsCommon.muruComSt[i].ruBdaCommSt[j].flagRu)
                        {
                            clsCommon.muruComSt[i].ruBdaCommSt[j].flagRu = false;

                            //현재 보고 있는 RU화면이 있으면 통신불량 상태로 비활성화 시킨다.
                            if ((i + 1 == clsCommon.presentMUID) && (j + 1 == clsCommon.presentRUID)) RuStInit(false);

                            //현재 보고있는 화면이면 상태를 표시한다.
                            if (i + 1 == clsCommon.presentMUID) nmsRuComSt_Display(i + 1);

                            try
                            {
                                SetColorRuButton((byte)(i + 1), (byte)(j + 1), 0);      //MU통화권 화면의 RU 버튼 Error 표시
                            }
                            catch
                            {
                            }
                        }
                    }

                    //RU FM
                    if (clsCommon.muruComSt[i].ruBdaCommSt[j].cntFm++ > cntFmTimeOut)
                    {
                        clsCommon.muruComSt[i].ruBdaCommSt[j].cntFm = cntFmTimeOut;

                        if (clsCommon.muruComSt[i].ruBdaCommSt[j].flagFm)
                        {
                            clsCommon.muruComSt[i].ruBdaCommSt[j].flagFm = false;

                            //현재 보고 있는 RU화면이 있으면 통신불량 상태로 비활성화 시킨다.
                            if ((i + 1 == clsCommon.presentMUID) && (j + 1 == clsCommon.presentRUID)) RuFmStInit(false);

                            string tmpStr = stationList[i] + " - " + clsCommon.muruName[i].ruName[j].ruName;
                            //FM이 있으면 통신이 끊긴것을 로고에 남긴다.
                            if (clsCommon.muruFmExist[i].flagRu[j])
                                AddStatus(tmpStr + "의 FM 자장치와 통신이 끊겼습니다.");
                        }
                    }

                    int cntBdaTimeOut = 0;
                    switch (clsCommon.nmsGUIUser)
                    {
                        case "경춘선":
                            //경춘선은 통신에러를 Check하기 때문에 NMS프로그램에서 별도로 통신 Check 하지 않는다.
                            cntBdaTimeOut = 1200;
                            break;

                        case "중앙선":
                            cntBdaTimeOut = 600;    //2012년 12월 05일 : 소스텔의 요청으로 BDA이 통신 Error 시간을 3분에서 10분으로 늘임

                            for (int k = 0; k < 4; k++)
                            {
                                if (clsCommon.muruComSt[i].ruBdaCommSt[j].cntBda[k]++ > cntBdaTimeOut)
                                {
                                    clsCommon.muruComSt[i].ruBdaCommSt[j].cntBda[k] = cntBdaTimeOut + 1;

                                    if (clsCommon.muruComSt[i].ruBdaCommSt[j].flagBda[k])
                                    {
                                        clsCommon.muruComSt[i].ruBdaCommSt[j].flagBda[k] = false;

                                        //현재 보고 있는 RU화면이 있으면 통신불량 상태로 비활성화 시킨다.
                                        if ((i + 1 == clsCommon.presentMUID) && (j + 1 == clsCommon.presentRUID)) BdaStInit(false, (byte)k);

                                        try
                                        {
                                            btBdaSetColor((byte)(i + 1), (byte)(j + 1), (byte)(k + 1), colorBase);    //MU통화권 화면의 BDA 버튼 Error 표시
                                        }
                                        catch
                                        {
                                        }

                                        //통신이 끊긴것을 로고에 남긴다.
                                        if (clsCommon.muruName[i].ruName[j].bdaName[k] != "")
                                        {                            
                                            //if (!clsCommon.muruComSt[i].ruBdaCommSt[j].flagBdaFirst[k])
                                            string tmpStr = stationList[i] + " - " + clsCommon.muruName[i].ruName[j].ruName + " - " + clsCommon.muruName[i].ruName[j].bdaName[k];;
                                            AddStatus("BDA(" + tmpStr + ")와 통신이 끊겼습니다.");
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }

                //각 기지국의 주/예비/감청 통신 Error Check
                for (j = 0; j < 3; j++)
                {
                    if (commErrCheck[i].flagCommErr[j])
                    {   //주/예비/감청통신이 이상인 경우
                        try
                        {
                            commErrCheck[i].cntCommErr[j]++;
                        }
                        catch
                        {
                        }
                    }
                }
            }

            //BDA 초기화 주기 시간 Check하여 BDA 초기화를 시킨다.
            if (bdaInitCycle > 0)
            {
                if (bdaInitSec++ >= 60)
                {
                    bdaInitSec = 0;

                    if (bdaInitMin++ >= bdaInitCycle)
                    {
                        bdaInitMin = 0;

                        //모든 BDA를 초기화 시킨다.
                        for (i = 0; i < muruNowData.Length; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                bool flagBDAExist = false;

                                for (int k = 0; k < 4; k++)
                                {
                                    if (clsCommon.muruName[i].ruName[j].bdaName[k] != "")
                                    {
                                        flagBDAExist = true;
                                        break;
                                    }
                                }

                                if (flagBDAExist)
                                    nmsMainMachine.EditData_BDA_FreqSet((byte)(i + 1), (byte)(j + 1), 0, 0);
                            }
                            AddStatus("BDA 전체를 초기화 시켰습니다.");
                        }
                    }
                }
            }


            #region 경춘선
            if (clsCommon.nmsGUIUser != "경춘선")
            {
                //RC 통화권 화면의 상태 표시
                if (gbRcRoute.Visible)
                {   //현재 RC 통화권 화면을 보고있으면 처리
                    if (panelRCAll.Visible)
                    {   //RC 전체화면을 보고있으면 RC통화권에 속해있는 MU/RU의 상태를 확인하여 표시
                        for (i = 0; i < 15; i++)
                        {
                            for (j = 0; j < cntRC; j++)
                            {
                                try
                                {
                                    //통신상태 확인
                                    bool flagCommSt = false;
                                    if (rcInfo[i].rcBtInfo[j].ruID == 0) flagCommSt = clsCommon.muruComSt[rcInfo[i].rcBtInfo[j].muID - 1].flagMu;
                                    else flagCommSt = clsCommon.muruComSt[rcInfo[i].rcBtInfo[j].muID - 1].ruBdaCommSt[rcInfo[i].rcBtInfo[j].ruID - 1].flagRu;

                                    if (!flagCommSt)
                                    {   //통신이상
                                        SetColor(btRcStation[i], colorError);
                                        break;
                                    }

                                    //MU Error 상태 확인
                                    if (clsCommon.flagMuRuBdaError[rcInfo[i].rcBtInfo[j].muID - 1, 0, 0])
                                    {
                                        SetColor(btRcStation[i], colorError);
                                        break;
                                    }
                                    //RU Error 상태 확인
                                    if (clsCommon.flagMuRuBdaError[rcInfo[i].rcBtInfo[j].muID - 1, rcInfo[i].rcBtInfo[j].ruID, 0])
                                    {
                                        SetColor(btRcStation[i], colorError);
                                        break;
                                    }
                                }
                                catch
                                {
                                }
                            }

                            if (j >= cntRC)    //RC 통화권 이상없음.
                                SetColor(btRcStation[i], colorSelect);
                        }
                    }
                    else
                    {   //RC 상세화면을 보고있으면 MU/RU의 상태 표시한다.
                        for (i = 0; i < cntRC; i++)
                        {
                            try
                            {
                                //통신상태 확인
                                bool flagCommSt = false;
                                if (rcInfo[rcStationIndex].rcBtInfo[i].ruID == 0) flagCommSt = clsCommon.muruComSt[rcInfo[rcStationIndex].rcBtInfo[i].muID - 1].flagMu;
                                else flagCommSt = clsCommon.muruComSt[rcInfo[rcStationIndex].rcBtInfo[i].muID - 1].ruBdaCommSt[rcInfo[rcStationIndex].rcBtInfo[i].ruID - 1].flagRu;

                                if (flagCommSt)
                                {   //통신상태 정상
                                    //Error 상태 확인
                                    if (clsCommon.flagMuRuBdaError[rcInfo[rcStationIndex].rcBtInfo[i].muID - 1, rcInfo[rcStationIndex].rcBtInfo[i].ruID, 0]) SetColor(btRc[i], colorError);
                                    else SetColor(btRc[i], colorSelect);
                                }
                                else
                                {   //통신이상
                                    SetColor(btRc[i], colorBase);
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            #endregion


            }

            tmrMain.Start();
        }
    }
}
