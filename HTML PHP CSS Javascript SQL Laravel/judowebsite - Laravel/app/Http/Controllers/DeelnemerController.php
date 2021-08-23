<?php

namespace App\Http\Controllers;

use App\Banden;
use App\deelnemer;
use Illuminate\Http\Request;

class DeelnemerController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $deelnemers = Deelnemer::all();
        return view('Deelnemers.index', compact('deelnemers'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $banden = Banden::All();
        return view('Deelnemers.create', compact('banden'));
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $deelnemer = new deelnemer([
            'naam' => $request->naam,
            'banden_id' => $request->banden_id,
            'win' => $request->win,
            'loss' => $request->loss
        ]);
        $deelnemer->save();

        return redirect('deelnemer');
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
        $deelnemer = Deelnemer::find($id);
        $banden = Banden::All();
        return view('Deelnemers.edit', compact('deelnemer', 'banden'));
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
        $deelnemer = Deelnemer::find($id);
        $deelnemer->naam = $request->naam;
        $deelnemer->banden_id = $request->banden_id;
        $deelnemer->win = $request->win;
        $deelnemer->loss = $request->loss;

        $deelnemer->save();
        return redirect('deelnemer');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $deelnemer = Deelnemer::find($id);
        $deelnemer->delete();

        return redirect('deelnemer');
    }
}
