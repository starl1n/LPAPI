using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace LPAPI.iOS
{
    // typedef void (^DzDidOpenedPrinterBlock)(BOOL);
    delegate void OpenPrinterBlock(bool success);


    // @interface LPAPI : NSObject
    [BaseType(typeof(NSObject))]
    interface LPAPI
    {

        // +(void)openSocket;
        [Static]
        [Export("openSocket")]
        void OpenSocket();

        [Export("objectOnIndex:")]
        NSArray ObjectOnIndex(NSObject obj);

        // +(void)closeSocket;
        [Static]
        [Export("closeSocket")]
        void CloseSocket();

        // +(void)setSupportPrefixs:(NSArray *)supportPrefixs;
        [Static]
        [Export("setSupportPrefixs:")]
        void SetSupportPrefixs(NSMutableArray supportPrefixs);

        // +(NSString *)connectingPrinterName;
        [Static]
        [Export("connectingPrinterName")]
        NSString ConnectingPrinterName { get; set; }

        // +(void)openPrinter:(NSString *)printerName completion:(DzDidOpenedPrinterBlock)completion;
        [Static]
        [Export("openPrinter:completion:")]

        void OpenPrinter(NSString printerName, Action<bool> completion);

        // +(void)closePrinter;
        [Static]
        [Export("closePrinter")]
        void ClosePrinter();

        // +(BOOL)startPrint:(CGFloat)width height:(CGFloat)height orientation:(int)orientation scaleUnit:(int)scaleUnit jobName:(NSString *)jobName;
        [Static]
        [Export("startPrint:height:orientation:scaleUnit:jobName:")]
        bool StartPrint(nfloat width, nfloat height, int orientation, int scaleUnit, NSString jobName);

        // +(void)commitPrint:(void (^)(BOOL))completion;
        [Static]
        [Export("commitPrint:")]
        void CommitPrint(Action<bool> completion);

        // +(BOOL)setItemOrientation:(int)orientation;
        [Static]
        [Export("setItemOrientation:")]
        bool SetItemOrientation(int orientation);

        // +(BOOL)setItemHorizontalAlignment:(int)alignment;
        [Static]
        [Export("setItemHorizontalAlignment:")]
        bool SetItemHorizontalAlignment(int alignment);

        // +(BOOL)setItemVerticalAlignment:(int)alignment;
        [Static]
        [Export("setItemVerticalAlignment:")]
        bool SetItemVerticalAlignment(int alignment);

        // +(BOOL)drawText:(NSString *)text x:(CGFloat)x y:(CGFloat)y width:(CGFloat)width height:(CGFloat)height fontName:(NSString *)fontName fontHeight:(CGFloat)fontHeight fontStyle:(int)fontStyle;
        [Static]
        [Export("drawText:x:y:width:height:fontName:fontHeight:fontStyle:")]
        bool DrawText(NSString text, nfloat x, nfloat y, nfloat width, nfloat height, NSString fontName, nfloat fontHeight, int fontStyle);

        // +(BOOL)drawBarcode:(NSString *)text x:(CGFloat)x y:(CGFloat)y width:(CGFloat)width height:(CGFloat)height fontName:(NSString *)fontName fontHeight:(CGFloat)fontHeight fontStyle:(int)fontStyle;
        [Static]
        [Export("drawBarcode:x:y:width:height:fontName:fontHeight:fontStyle:")]
        bool DrawBarcode(NSString text, nfloat x, nfloat y, nfloat width, nfloat height, NSString fontName, nfloat fontHeight, int fontStyle);

        // +(BOOL)drawQRCode:(NSString *)text x:(CGFloat)x y:(CGFloat)y width:(CGFloat)width height:(CGFloat)height;
        [Static]
        [Export("drawQRCode:x:y:width:height:")]
        bool DrawQRCode(NSString text, nfloat x, nfloat y, nfloat width, nfloat height);

        // +(BOOL)drawQRCode:(NSString *)text x:(CGFloat)x y:(CGFloat)y width:(CGFloat)width;
        [Static]
        [Export("drawQRCode:x:y:width:")]
        bool DrawQRCode(NSString text, nfloat x, nfloat y, nfloat width);

        // +(BOOL)drawImage:(NSString *)file x:(CGFloat)x y:(CGFloat)y width:(CGFloat)width height:(CGFloat)height threshold:(int)threshold;
        [Static]
        [Export("drawImage:x:y:width:height:threshold:")]
        bool DrawImage(NSString file, nfloat x, nfloat y, nfloat width, nfloat height, int threshold);

        // +(BOOL)drawImage:(NSString *)file threshold:(int)threshold;
        [Static]
        [Export("drawImage:threshold:")]
        bool DrawImage(NSString file, int threshold);

        // +(BOOL)drawImageWithImage:(UIImage *)image x:(CGFloat)x y:(CGFloat)y width:(CGFloat)width height:(CGFloat)height threshold:(int)threshold;
        [Static]
        [Export("drawImageWithImage:x:y:width:height:threshold:")]
        bool DrawImageWithImage(UIImage image, nfloat x, nfloat y, nfloat width, nfloat height, int threshold);

        // +(BOOL)drawImageWithImage:(UIImage *)image threshold:(int)threshold;
        [Static]
        [Export("drawImageWithImage:threshold:")]
        bool DrawImageWithImage(UIImage image, int threshold);

        // +(BOOL)drawLineWithX:(CGFloat)x y:(CGFloat)y width:(CGFloat)width height:(CGFloat)height;
        [Static]
        [Export("drawLineWithX:y:width:height:")]
        bool DrawLineWithX(nfloat x, nfloat y, nfloat width, nfloat height);

        // +(BOOL)drawRectangleWithX:(CGFloat)x y:(CGFloat)y width:(CGFloat)width height:(CGFloat)height lineWidth:(CGFloat)lineWidth isFilled:(BOOL)isFilled;
        [Static]
        [Export("drawRectangleWithX:y:width:height:lineWidth:isFilled:")]
        bool DrawRectangleWithX(nfloat x, nfloat y, nfloat width, nfloat height, nfloat lineWidth, bool isFilled);

        // +(BOOL)drawRoundRectangleWithX:(CGFloat)x y:(CGFloat)y width:(CGFloat)width height:(CGFloat)height lineWidth:(CGFloat)lineWidth radius:(CGFloat)radius isFilled:(BOOL)isFilled;
        [Static]
        [Export("drawRoundRectangleWithX:y:width:height:lineWidth:radius:isFilled:")]
        bool DrawRoundRectangleWithX(nfloat x, nfloat y, nfloat width, nfloat height, nfloat lineWidth, nfloat radius, bool isFilled);

        // +(BOOL)drawEllipseWithX:(CGFloat)x y:(CGFloat)y width:(CGFloat)width height:(CGFloat)height lineWidth:(CGFloat)lineWidth isFilled:(BOOL)isFilled;
        [Static]
        [Export("drawEllipseWithX:y:width:height:lineWidth:isFilled:")]
        bool DrawEllipseWithX(nfloat x, nfloat y, nfloat width, nfloat height, nfloat lineWidth, bool isFilled);

        // +(BOOL)drawCircleWithX:(CGFloat)x y:(CGFloat)y width:(CGFloat)width height:(CGFloat)height lineWidth:(CGFloat)lineWidth isFilled:(BOOL)isFilled;
        [Static]
        [Export("drawCircleWithX:y:width:height:lineWidth:isFilled:")]
        bool DrawCircleWithX(nfloat x, nfloat y, nfloat width, nfloat height, nfloat lineWidth, bool isFilled);
    }
}
