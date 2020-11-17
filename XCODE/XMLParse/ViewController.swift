//
//  ViewController.swift
//  XMLParse
//
//  Created by Frank Boddeke on 17/10/2020.
//

import UIKit

class ViewController: UIViewController, XMLParserDelegate {

    @IBOutlet weak var Monitor: UILabel!
    @IBOutlet weak var Label2: UILabel!
    
    
  
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        //http://lodewijk.edgetech.nl:3343/monitor
        
        
//        let url = NSURL(Ab: "http://lodewijk.edgetech.nl:3343/monitor") as! URL
//        var parser = XMLParser(contentsOf: url)!
    
        
        let anHTTPURL = NSURL (absoluteURLWithDataRepresentation: "Monitor", relativeTo: URL?"http://lodewijk.edgetech.nl:3343/monitor");
        
        let url = NSURL (absoluteURLWithDataRepresentation: "monitor", relativeTo: "http://lodewijk.edgetech.nl:3343/" as URL)
        print(anHTTPURL)
        
        
    
    }
    
    func beginParsing(urlString: String) {
        guard let myURL = NSURL(string: urlString) else {
            print("URL not defined correctly.")
            return
        }
        guard let parser = XMLParser(contentsOf: myURL as URL) else {
            print("cannot read data")
            return
        }
        parser.delegate = self
        
    }
}

