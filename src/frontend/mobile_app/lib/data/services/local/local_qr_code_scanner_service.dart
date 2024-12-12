import '../qr_code_scanner_service.dart';

class LocalDeviceQrCodeScannerService implements QrCodeScannerService {
  @override
  Future<String?> scanAsync() {
    return Future.value(
        "https://sat.sef.sc.gov.br/nfce/consulta?p=42241282647165000467651300000151401914491001|2|1|1|CA30280198FC864D574CFFDCE4847E93C29F6B73");
  }
}
