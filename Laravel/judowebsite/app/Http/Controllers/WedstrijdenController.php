<?php

namespace App\Http\Controllers;

use App\Deelnemer;
use App\Wedstrijden;
use Illuminate\Http\Request;
use phpDocumentor\Reflection\DocBlock\Tags\Formatter\AlignFormatter;

class WedstrijdenController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $wedstrijden = Wedstrijden::all();
        return view('wedstrijden.index', compact('wedstrijden'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $deelnemers = Deelnemer::all();
        return view('wedstrijden.create', compact('deelnemers'));
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $deelnemerBlauw = Deelnemer::find($request->blauwe_judoka);
        $deelnemerWit = Deelnemer::find($request->witte_judoka);

        if($request->winnaar == 'blauw') {
            $deelnemerBlauw->win++;
            $deelnemerWit->loss++;
        }
        else if($request->winnaar == 'wit') {
            $deelnemerBlauw->loss++;
            $deelnemerWit->win++;
        }

        $deelnemerBlauw->save();
        $deelnemerWit->save();

        $wedstrijd = new wedstrijden([
           'blauwe_judoka' => $request->blauwe_judoka,
           'witte_judoka' => $request->witte_judoka,
           'winnaar' => $request->winnaar
        ]);
        $wedstrijd->save();

        return redirect('wedstrijden');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $wedstrijd = Wedstrijden::find($id);
        $deelnemers = deelnemer::All();
        return view('wedstrijden.edit', compact('wedstrijd', 'deelnemers'));
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        $wedstrijd = Wedstrijden::find($id);
        $wedstrijd->blauwe_judoka = $request->blauwe_judoka;
        $wedstrijd->witte_judoka = $request->witte_judoka;

        $deelnemerBlauw = Deelnemer::find($request->blauwe_judoka);
        $deelnemerWit = Deelnemer::find($request->witte_judoka);

        if($wedstrijd->winnaar != $request->winnaar) {
            if($request->winnaar == 'blauw') {
                if($request->winnaar == 'blauw') {
                    $deelnemerBlauw->win++;
                    $deelnemerBlauw->loss--;
                    $deelnemerWit->loss++;
                    $deelnemerWit->win--;
                }
                else if($request->winnaar == 'wit') {
                    $deelnemerBlauw->win--;
                    $deelnemerBlauw->loss++;
                    $deelnemerWit->loss--;
                    $deelnemerWit->win++;
                }
            }
            $deelnemerBlauw->save();
            $deelnemerWit->save();
        }

        $wedstrijd->winnaar = $request->winnaar;

        $wedstrijd->save();


        return redirect('wedstrijden');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $wedstrijd = Wedstrijden::find($id);
        $wedstrijd->delete();

        return redirect('wedstrijden');
    }
}
