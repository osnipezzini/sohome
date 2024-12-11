import '../qr_code_scanner_service.dart';

sealed class DeviceQrCodeScannerService implements QrCodeScannerService {
  @override
  Future<String?> scanAsync() {
    // TODO: implement scanAsync
    throw UnimplementedError();
  }

}